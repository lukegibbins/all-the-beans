<template>
    <div>
        <h1>Manage My Beautiful Beans</h1>
        <br /><br />

        <button type="button" class="btn btn-info" v-on:click="addBean()">Add bean</button>
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
                        <input type="text" v-model="bean.image" class="form-control">
                    </td>
                    <td>
                        <button type="button" class="btn btn-danger" v-on:click="deleteBean(index)">Delete</button>
                    </td>
                </tr>
            </tbody>
        </table>
        <button type="button" class="btn btn-success" style="float:right">Save all beans</button>
    </div>
</template>

<script>
    export default {
        computed: {
            beans() {
                let beans = this.$store.getters["getAllBeans"]
                beans.forEach(bean => bean.date = bean.date.split('T')[0])

                return beans
            }
        },

        created() {
            this.$store.dispatch("loadAllBeans")
        },

        methods: {
            addBean() {
                let newBean = {name: "", cost: "", aroma: "", colour: "", date: "", image: ""}
                this.beans.push(newBean)
            },

            deleteBean(beanIndex) {
                this.beans.splice(beanIndex, 1)
            }
        }
    }
</script>

<style>
    btn-position {
        float: right
    }
</style>