const { createApp } = Vue;

const appExemple = {
    data() {
        return  {
            prixAuLitre: 1.65,
            quantiteEnLitre: 2,
            btnStart: false,
            libeleBtn: "Start",
            intervalle: null
            
        }
    },
    computed: {

        calculPrix() {
            return (this.prixAuLitre*this.quantiteEnLitre).toFixed(2)
        }


    },
    mounted() {
        
    },
    methods: {

    calculerPrix() {
        if(this.btnStart) {
            this.libeleBtn = "Start"
            clearInterval(this.intervalle)
        } else {
            this.quantiteEnLitre = 0;
            this.libeleBtn = "Stop"
        }

    this.distribution = !this.distribution
    }
    
    }
    
}

createApp(appExemple).mount('#app');