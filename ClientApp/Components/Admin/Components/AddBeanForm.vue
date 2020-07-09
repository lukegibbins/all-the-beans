<template>
    <div>
        <br /><br />
        <h1>Add A Beautiful Bean</h1>
        <br /><br />

        <button class="btn btn-info" v-on:click="back()">Back</button>
        <div>
            <br /><br />
            <p v-for="error in formErrors" class="form-errors">
                {{ error }}
            </p>
        </div>

        <label>Enter name</label>
        <input type="text" class="form-control" placeholder="Name" v-model.trim="$v.bean.name.$model">
        <div class="validation-error" v-if="$v.bean.name.$error">Required</div>

        <br /><br />
        <label>Enter cost (£)</label>
        <p><small><i>*Beans have a maximum cost of £9.99.</i></small></p>
        <input type="text" class="form-control" placeholder="Cost" v-model.trim="$v.bean.cost.$model">
        <div class="validation-error" v-if="$v.bean.cost.$error">
            <div v-if="!$v.bean.cost.required">Required</div>
            <div v-if="!$v.bean.cost.isValidCost">Invalid price</div>
        </div>

        <br /><br />
        <label>Enter aroma</label>
        <input type="text" class="form-control" placeholder="Aroma" v-model.trim="$v.bean.aroma.$model">
        <div class="validation-error" v-if="$v.bean.aroma.$error">Required</div>

        <br /><br />
        <label>Choose colour</label>
        <select v-model.trim="$v.bean.colour.$model" class="form-control">
            <option>Very light</option>
            <option>Light</option>
            <option>Medium</option>
            <option>Dark</option>
            <option>Very dark</option>
        </select>
        <div class="validation-error" v-if="$v.bean.colour.$error">Required</div>

        <br /><br />
        <label>Date to advertise</label>
        <input type="date" class="form-control" placeholder="Date" v-model.trim="$v.bean.date.$model">
        <div class="validation-error" v-if="$v.bean.date.$error">Required</div>

        <br /><br />
        <label>Upload image</label>
        <p><small><i>*Wider images are more suited for our bean adverts.</i></small></p>
        <input type="file" class="form-control-file" accept="image/*" ref="file" v-on:change="handleFileUpload($event)">
        <div class="validation-error" v-if="$v.file.$error">Required</div>

        <br />
        <button type="button" class="btn btn-info" v-on:click="submitForm()" style="float:right">Add Bean</button>
        <br /><br />
    </div>
</template>

<script>
    const { required } = require('vuelidate/lib/validators')
    const isValidCost = (value) => value.match(new RegExp("^[0-9]\\.[0-9]{2}$")) !== null

    export default {
        props: ['beans'],

        data() {
            return {
                bean: {
                    aroma: "",
                    colour: "",
                    cost: "",             
                    date: "",           
                    id: null,
                    image: "",
                    name: ""
                },
                file: '',
                formErrors: []
            }
        },

        validations: {
            bean: {
                aroma: {
                    required
                },
                colour: {
                    required,
                },
                cost: {
                    required,
                    isValidCost
                },
                date: {
                    required,
                },
                name: {
                    required
                }
            },
            file: {
                required
            }
        },

        methods: {
            handleFileUpload(event) {
                this.file = event.target.files[0]
            },
              
            submitForm() {                
                this.formErrors = []

                this.$v.$touch()
                if (this.$v.$invalid) { return }
     
                let currentBeanDates = this.beans.map(value => value.date)

                if (currentBeanDates.indexOf(this.bean.date) !== -1) {
                    this.formErrors.push("There is already a bean advertised on that date. Choose another.")
                    return
                }

                let validExtensions = ["jpg", "png", "jpeg"]
                let hasValidFilExtension = validExtensions.indexOf(this.file.name.split('.').pop().toLowerCase())

                if (hasValidFilExtension == -1) {
                    this.formErrors.push("Invalid file extension. Use jpg, png or jpeg.")
                    return
                } 
             
                let formData = new FormData()
                let timestamp = Math.round((new Date()).getTime() / 1000).toString()

                this.bean.image = timestamp + "_" + this.file.name            
                formData.set('file', this.file, timestamp + "_" + this.file.name)

                this.$store.dispatch('addBean', [formData, this.bean])
            },

            back() {
                location.reload()
            }
        }
    }
</script>

<style>
 .validation-error{
     color:red
 }
</style>
