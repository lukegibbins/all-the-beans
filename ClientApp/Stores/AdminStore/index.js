import state from './state'
import mutations from './mutations'
import getters from './getters'
import actions from './actions'

import Vue from 'vue'
import Vuex from 'vuex'
import Vuelidate from 'vuelidate'

Vue.use(Vuelidate)
Vue.use(Vuex)

const store = new Vuex.Store({
    state,
    getters,
    mutations,
    actions
});

export default store