<template>
    <div>
        <br /><br />
        <div v-if="!bean">
            <div class="jumbotron">
                <h1 class="display-3">No beans today :'(</h1>
                <p class="lead">Unfortunately, there are no bean adverts being displayed today. </p>
                <p>Please try checking again tomrrow.</p>
            </div>
        </div>
        <div v-else="bean">
            <h1>Bean of the day</h1>
            <p><i>Lets all bean together</i></p>
            <br />
            <div class="card mb-3" style="border: black solid 1px">
                <h3 class="card-header">{{formatDate()}}</h3>
                <div class="card-body">
                    <h5 class="card-title">Today's bean advert is: <b>{{bean.name}}</b></h5>
                    <h6 class="card-subtitle text-muted">We hope you enjoy</h6>
                </div>
                <img style="height: 350px; width: 100%; display: block;" :src="getImageUrl(bean.image)">
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">Bean name: {{bean.name}}</li>
                    <li class="list-group-item">Bean cost (per 100g): £{{bean.cost}}</li>
                    <li class="list-group-item">Bean aroma: {{bean.aroma}}</li>
                    <li class="list-group-item">Bean date: {{formatDate()}}</li>
                    <li class="list-group-item">Bean colour: {{bean.colour}}</li>
                </ul>
            </div>
        </div>

    </div>
</template>

<script>
    export default {
        computed: {
            bean() {
                let bean = this.$store.getters["getBeanOfDay"]                
                return bean
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
                return this.bean.date == undefined ? null : this.getFormat(this.bean.date.split('T')[0])
            },

            getFormat(date) {
                var arr = date.split('-')
                return arr[2]+"/"+arr[1]+"/"+arr[0]
            }
        }
    }
</script>

<style>

</style>