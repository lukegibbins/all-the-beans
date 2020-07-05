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
        <input type="file" class="form-control-file" accept="image/*" onchange="loadFile(event)">
        <img id="output" width="200" />

        <button type="button" class="btn btn-info" v-on:click="">Add Bean</button>
        <br /><br />
    </div>
</template>

<script>
    export default {
        props: ['beans'],

        data() {
            return {
                bean: {
                    name: "",
                    cost: "",
                    aroma: "",
                    colour: "",
                    date: "",
                    image: "",
                }
            }
        },

        methods: {
            addBean(bean) {

            },

            loadFile(event) {
                var image = document.getElementById('output');
                image.src = URL.createObjectURL(event.target.files[0]);
            }
        }
    }
 </script>
