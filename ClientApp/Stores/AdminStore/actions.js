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
    }
}