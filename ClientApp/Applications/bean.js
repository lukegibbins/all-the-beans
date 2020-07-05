import Vue from 'vue'
import BeanOfDayPage from '../Components/BeanOfDay/BeanOfDay.vue'
import store from "../Stores/BeanOfDayStore"

new Vue({
    el: "#app",
    store,
    render: h => h(BeanOfDayPage)
})