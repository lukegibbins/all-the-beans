import Vue from 'vue'
import AdminPage from '../Components/Admin/AdminCms.vue'
import store from "../Stores/AdminStore"

new Vue({
    el: "#app",
    store,
    render: h => h(AdminPage)
})