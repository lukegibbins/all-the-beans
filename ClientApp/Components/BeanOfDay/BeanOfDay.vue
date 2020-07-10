<template>
    <div>
        <br /><br />
        <div v-if="bean" v-cloak>
            <h1>Bean of the day</h1>
            <p><i>Lets all bean together</i></p>
            <br />
            <div class="card mb-3 custom-style" style="border: black solid 1px">
                <h3 class="card-header">{{formatDate()}}</h3>
                <div class="card-body">
                    <h5 class="card-title">Today's bean advert is: <b>{{bean.name}}</b></h5>
                    <h6 class="card-subtitle text-muted">We hope you enjoy</h6>
                </div>
                <img :src="getImageUrl(bean.image)" style="max-height: 450px;" >
                <ul class="list-group list-group-flush" style="color:black">
                    <li class="list-group-item">Bean name: {{bean.name}}</li>
                    <li class="list-group-item">Bean cost (per 100g): £{{bean.cost}}</li>
                    <li class="list-group-item">Bean aroma: {{bean.aroma}}</li>
                    <li class="list-group-item">Bean date: {{formatDate()}}</li>
                    <li class="list-group-item">Bean colour: {{bean.colour}}</li>
                </ul>
            </div>
        </div>
        <div v-else v-cloak>
            <div class="jumbotron">
                <h1 class="display-3">No beans today :'(</h1>
                <p class="lead">Unfortunately, there are no bean adverts being displayed today. </p>
                <p>Please try checking again tomrrow.</p>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        computed: {
            bean() {
                return this.$store.getters["getBeanOfDay"]                
            }
        },

        created() {
            this.$store.dispatch("loadBeanOfDay")
        },

        methods: {
            getImageUrl(url) {
                let arr = window.location.href.split("/")
                let domainUrl = arr[0] + "//" + arr[2] + "/bean_images/" + url
                return domainUrl
            },

            formatDate() {
                if (this.bean.date == undefined) {
                    return null
                } else {
                    var dateOnly = this.bean.date.split('T')[0]
                    var dateParts = dateOnly.split('-')
                    return dateParts[2] + "/" + dateParts[1] + "/" + dateParts[0]
                }
            }
        }
    }
</script>

<style>
    [v-cloak] {
        display:none
    }

    .custom-style {
        background-color: #1a1a1a;
        color:white        
    }
</style>