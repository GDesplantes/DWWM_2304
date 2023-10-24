const { createApp } = Vue;

const appExemple = {
    data() {
        return  {
            prixAuLitre: 1.65,
            inputReadonly: false,
            quantiteEnLitre: 0,
            btnStart: false,
            libeleBtn: "Start",
            intervalle: null
            
        }
    },
    computed: { //  : Object
        

        calculPrix() { // fonction --> chaîne 
            if(this.prixAuLitre > 0) {
                return (this.prixAuLitre*this.quantiteEnLitre).toFixed(2)
            } else {
                return "Prix au litre invalide"
            }
        },

        quantiteArrondie() {
            return this.quantiteEnLitre.toFixed(2)

        },
    },
    methods: {

        calculerPrix() {
            if(this.btnStart) {
                this.libeleBtn = "Start"
                clearInterval(this.intervalle)
            } else {
                this.quantiteEnLitre = 0;
                this.libeleBtn = "Stop"
                this.intervalle = setInterval(() => {
                    this.quantiteEnLitre += 0.09;
                }, 50);
            }
        

        this.btnStart = !this.btnStart
        },
        reset() {
            this.quantiteEnLitre = 0;
            
        }
        
        
    }
    
}


Vue.createApp(appExemple).mount('#app');