<template>
    <div>
        <h1>Add A Beautiful Bean</h1>
        <br /><br />
        <input type="text" class="form-control" placeholder="Name" v-model.trim="bean.name">
        <input type="text" class="form-control" placeholder="Cost" v-model.trim="bean.cost">
        <input type="text" class="form-control" placeholder="Aroma" v-model.trim="bean.aroma">
        <input type="text" class="form-control" placeholder="Colour" v-model.trim="bean.colour">
        <input type="date" class="form-control" placeholder="Date" v-model.trim="bean.date">
        <br /><br />

        <label>Select image:</label>
        <input type="file" class="form-control-file" accept="image/*" ref="file" v-on:change="handleFileUpload($event)">
        <img id="output" width="200" />

        <button type="button" class="btn btn-info" v-on:click="submitForm()">Add Bean</button>
        <br /><br />
    </div>
</template>

<script>
    export default {
        props: ['beans'],

        data() {
            return {
                bean: {
                    aroma: "",
                    colour: "",
                    cost: 3.99,             // has to be double format
                    date: "2020-02-05",     // has to be format => 2020-02-05
                    id: null,
                    image: "",
                    name: ""
                },
                file: ''
            }
        },

        methods: {
            handleFileUpload(event) {
                this.file = event.target.files[0]
            },

            submitForm() {
                let formData = new FormData()
                let timestamp = Math.round((new Date()).getTime() / 1000).toString()

                this.bean.image = timestamp

                formData.set('file', this.file, "image_" + timestamp)
                this.$store.dispatch('addBean', [formData, this.bean])
            }
        }
    }
</script>
