import axios from "axios"

export default {
    loadBeanOfDay({ commit }) {
        axios.get('/Bean/GetBeanOfDay')
            .then(res => {
                var beanObj = res.data
                commit("setBeanOfDay", beanObj)
            })
            .catch(error => {
                console.log(error)
            })
    }
}