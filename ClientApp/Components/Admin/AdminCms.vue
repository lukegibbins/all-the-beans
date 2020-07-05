<template>
    <div>
   
        <add-bean-component v-show="!addNewBean"></add-bean-component>

        <div v-show="!addNewBean">
            <h1>Manage My Beautiful Beans</h1>
            <br /><br />

            <button type="button" class="btn btn-info" v-on:click="">Add a new bean</button>

            <table class="table">
                <thead>
                    <tr>
                        <th scope="col"></th>
                        <th scope="col">Name</th>
                        <th scope="col">Cost</th>
                        <th scope="col">Aroma</th>
                        <th scope="col">Colour</th>
                        <th scope="col">Date Advertised</th>
                        <th scope="col">Image</th>
                        <th scope="col">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="(bean, index) in beans" :key="index">
                        <td>
                            {{index+1}}
                        </td>
                        <td>
                            <input type="text" v-model="bean.name" class="form-control">
                        </td>
                        <td>
                            <input type="text" v-model="bean.cost" class="form-control">
                        </td>
                        <td>
                            <input type="text" v-model="bean.aroma" class="form-control">
                        </td>
                        <td>
                            <input type="text" v-model="bean.colour" class="form-control">
                        </td>
                        <td>
                            <input type="date" v-model="bean.date" class="form-control">
                        </td>
                        <td>
                            <button type="button" class="btn btn-dark" v-on:click="viewImage(bean)">View</button>
                        </td>
                        <td>
                            <button type="button" class="btn btn-danger" v-on:click="deleteBean(index)">Delete</button>
                        </td>
                    </tr>
                </tbody>
            </table>
            <button type="button" class="btn btn-success" style="float:right">Save all</button>
        </div>
    </div>
</template>

<script>
    import AddBeanForm from './Components/AddBeanForm.vue'

    export default {
        data() {
            return {
                addNewBean: false
            }
        },

        components: {
            "add-bean-component": AddBeanForm
        },

        computed: {
            beans() {
                let beans = this.$store.getters["getAllBeans"]
                beans.forEach(bean => bean.date = bean.date.split('T')[0])
                beans.forEach(bean => bean.cost = "£" + bean.cost)
                return beans
            }
        },

        created() {
            this.$store.dispatch("loadAllBeans")
        },

        methods: {
            addBean() {
                this.addNewBean = true
            },

            deleteBean(beanIndex) {
                this.beans.splice(beanIndex, 1)
            },

            viewImage(bean) {
                alert("Launch image with modal")
            }
        }
    }
</script>

<style>
    btn-position {
        float: right
    }
</style>