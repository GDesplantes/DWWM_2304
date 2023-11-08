/* App 10000 mètres */
import { Participants } from "./participants.js";

const app = {
    data() {
        return {
            participants: [],

        }
    },

    async mounted() {

         let response = await fetch('./Assets/cereales/resultats.json');
         this.participants = await response.json();
         console.log(this.participants);

         for( let i = 0; i < this.participants.length; i++) {
                this.participants[i] =  new Participants(this.participants[i]);
         }
         //console.log(this.participants);

        

    }, 
    computed: {

        nbParticipant() {
            return this.participants.length;
        },

        trouverLeGagnant() {
             this.participants.sort((a,b) => a.temps - b.temps);
        },

        // tempsEnMin() {
        
        //     let minute =  parseFloat(this.participants.temps);
        //     minute = minute/60;
        // }

    },

    methods: {
        
    }
}


Vue.createApp(app).mount('#app');