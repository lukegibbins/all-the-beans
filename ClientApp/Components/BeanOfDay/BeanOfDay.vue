<template>
    <div>
        <h1>Bean of day</h1>
        <p>Lets all bean together</p>

        <p>My bean is called: {{bean}}</p>
    </div>
</template>

<script>
    import { mapGetters } from "vuex"

    export default {
        computed: {
            ...mapGetters({
                bean: "getBeanOfDay"
            })
        },

        created() {
            this.$store.dispatch("loadBeanOfDay")
        }
    }
</script>

<style>

</style>