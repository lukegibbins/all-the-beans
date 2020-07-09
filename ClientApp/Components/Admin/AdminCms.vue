<template>
    <div>
   
        <add-bean-component v-show="addNewBean" :beans="beans"></add-bean-component>

        <div v-show="!addNewBean">
            <br /><br />
            <h1>Manage My Beautiful Beans</h1>
            <br /><br />

            <button type="button" class="btn btn-info" v-on:click="addBean()">Add a new bean</button>

            <div>
                <br /><br />
                <p v-for="error in formErrors" class="form-errors">
                    {{ error }}
                </p>
            </div>

            <table class="table">
                <thead>
                    <tr>
                        <th scope="col"></th>
                        <th scope="col">Name</th>
                        <th scope="col">Cost</th>
                        <th scope="col">Aroma</th>
                        <th scope="col">Colour</th>
                        <th scope="col">Date Advertised</th>
                        <th scope="col">Image thumbnail</th>
                        <th scope="col">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="(bean, index) in beans" :key="index">
                        <td>
                            {{index+1}}
                        </td>
                        <td>
                            {{bean.name}}
                        </td>
                        <td>
                            £{{bean.cost}}
                        </td>
                        <td>
                            {{bean.aroma}}
                        </td>
                        <td>
                            {{bean.colour}}
                        </td>
                        <td>
                            <input type="date" v-model="bean.date" class="form-control">
                        </td>
                        <td>
                            <img :src="getImageUrl(bean.image)" class="rounded img-thumbnail" style="width:150px; height:150px; border: black solid 1px">
                        </td>
                        <td>
                            <button type="button" class="btn btn-danger" v-on:click="deleteBean(index)">Delete</button>
                        </td>
                    </tr>
                </tbody>
            </table>
            <button type="button" class="btn btn-success" style="float:right" v-on:click="saveAll(beans)">Save all</button>

        </div>
    </div>
</template>

<script>
    import AddBeanForm from './Components/AddBeanForm.vue'

    export default {
        data() {
            return {
                addNewBean: false,
                formErrors: []
            }
        },

        components: {
            "add-bean-component": AddBeanForm
        },

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
                this.addNewBean = true
            },

            deleteBean(beanIndex) {
                this.beans.splice(beanIndex, 1)
            },

            saveAll(beans) {
                this.formErrors = []

                var beanDates = beans.map(value => value.date);

                if (beanDates.length > [...new Set(beanDates)].length) {
                    this.formErrors.push("There is already a bean advertised on that date. Choose another.")
                }

                if (this.formErrors.length > 0) { return }

                this.$store.dispatch("saveAll")
            },

            getImageUrl(url) {
                let arr = window.location.href.split("/")
                let domainUrl = arr[0] + "//" + arr[2] + "/bean_images/" + url
                return domainUrl
            },
        }
    }
</script>

<style>
    .form-errors {
        color:red
    }


</style>