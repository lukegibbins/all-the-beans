import Vue from 'vue'
import BeanOfDay from '../Components/BeanOfDay/BeanOfDay.vue'

import store from "../Stores/BeanOfDayStore"

new Vue({
    el: '#app',
    render: h => h(BeanOfDay)
})