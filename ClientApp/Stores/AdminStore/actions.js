import axios from "axios"

export default {
    loadAllBeans({ commit }) {
        axios.get('/Bean/GetAllBeans')
            .then(res => {
                var allBeans = res.data
                commit("setAllBeans", allBeans)
            })
            .catch(error => {
                console.log(error)
            })
    },

    addBean(context, [file, bean]) {
        axios.post('/Bean/AddImage', file, {
            headers: {
                'Content-Type': 'multipart/form-data',
            }})
            .then(res => {
                console.log(res)
                if (res.status !== 200) {
                    alert("Error adding bean")
                    return
                }
                axios.post('/Bean/AddBean', bean, {
                    headers: {
                        'Content-Type': 'application/json',
                    }})
                    .then(res => {
                        console.log(res)
                        if (res.status == 200) {
                            alert("1 beautiful bean added successfully")
                            location.reload()
                        } else {
                            alert("Error adding bean")
                        }
                    })
                    .catch(error => {
                        console.log(error)
                    })
            })
            .catch(error => {
                console.log(error)
            })
    },

    saveAll({ state }) {
        axios.post('/Bean/UpdateAllBeans', state.beans, {
            headers: {
                'Content-Type': 'application/json',
            }})
            .then(res => {
                console.log("res =>", res)
                if (res.status == 200) {                    
                    alert("Beans updated successfully")
                } else {
                    alert("Error updating beans")
                }
            })
            .catch(error => {
                console.log(error)
            })
    }
}