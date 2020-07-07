<template>
    <div>
        <br /><br />
        <h1>Add A Beautiful Bean</h1>
        <br /><br />
        <label>Enter name</label>
        <input type="text" class="form-control" placeholder="Name" v-model.trim="bean.name">

        <br /><br />
        <label>Enter cost</label>
        <input type="text" class="form-control" placeholder="Cost" v-model.trim="bean.cost">

        <br /><br />
        <label>Enter aroma</label>
        <input type="text" class="form-control" placeholder="Aroma" v-model.trim="bean.aroma">

        <br /><br />
        <label>Choose colour</label>
        <select v-model.trim="bean.colour" class="form-control">
            <option>Very light</option>
            <option>Light</option>
            <option>Medium</option>
            <option>Dark</option>   
            <option>Very dark</option>
        </select>

        <br /><br />
        <label>Date to advertise</label>
        <input type="date" class="form-control" placeholder="Date" v-model.trim="bean.date">
        <br /><br />
        <label>Upload image</label>
        <input type="file" class="form-control-file" accept="image/*" ref="file" v-on:change="handleFileUpload($event)">
        <img id="output" width="200" />

        <br />
        <button type="button" class="btn btn-info" v-on:click="submitForm()" style="float:right">Add Bean</button>
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
                    cost: "",             // has to be double format
                    date: "",             // has to be format => 2020-02-05
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
                formData.set('file', this.file, timestamp + "_" + this.file.name)

                this.$store.dispatch('addBean', [formData, this.bean])
            }
        }
    }
</script>
