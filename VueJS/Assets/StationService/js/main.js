const { createApp } = Vue;

const appExemple = {
    data() {
        return  {
            prixAuLitre: 0,
            quantiteEnLitre: 0,
            prixAPayer: 0,
            boutonDemmarer: ''
            
        }
    },
    computed: {


    },
    mounted() {
        
    },
    methods: {
        calcul() {
            console.log("Bonjour")

        }
        
    }
}

createApp(appExemple).mount('#app');