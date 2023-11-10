const { createApp } = Vue;
const appExemple = {

    data() {
        return {
            compteur:  0
        }
    },

    methods: {
        incrementer() {
            this.compteur++;
        }
        
    }
}


Vue.createApp(appExemple).mount('#app');