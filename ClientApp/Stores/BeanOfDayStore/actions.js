import axios from "axios"

export default {
    loadBeanOfDay({ commit }) {
        axios.get('/Bean/GetBeanOfDay')
            .then(data => {
                commit("setBeanOfDay", data.data)
            })
            .catch(error => {
                console.log(error)
            })
    }
}