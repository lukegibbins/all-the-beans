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

    saveAll({ state }) {
        axios.post('/Bean/UpdateAllBeans', state.beans, {
            headers: {
                'Content-Type': 'application/json', 
            }
        })
        .then(res => {
            console.log(res)
            alert("Beans updated")
            location.reload()
        })
        .catch(error => {
            console.log(error)
        })
    }
}