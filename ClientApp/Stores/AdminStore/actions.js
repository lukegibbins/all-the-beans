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
                console.log("bean =>", bean)
                axios.post('/Bean/AddBean', bean, {
                    headers: {
                        'Content-Type': 'application/json',
                    }})
                    .then(res => {
                        console.log(res)
                        alert("1 beautiful bean added successfully :)")
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
        alert(state.beans)
        axios.post('/Bean/UpdateAllBeans', state.beans, {
            headers: {
                'Content-Type': 'application/json',
            }})
            .then(res => {
                console.log(res)
                alert("Beans updated")
            })
            .catch(error => {
                console.log(error)
            })
    }
}