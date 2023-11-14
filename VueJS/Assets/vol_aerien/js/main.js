import { JsonDb } from "./Db.js";
import { Vol } from "./vol.js";


const jsonUrl = './Assets/vol_aerien/js/flights.json';

const app = {
    data() {
        return {
            vols: [], //Tableau qui sera manipuler
            volsSource:[], // tableau plein qui servira de comparatif
            recherche : "",
            asc: true

        }
    },


    async mounted() {
        this.vols = await JsonDb.fetchJson(jsonUrl);
        this.vols = this.vols.map(vol => new Vol(vol));
        console.log(this.vols)

        this.volsSource = [...this.vols];

    },


    methods: {

        filtrerCompagnie(){
            // console.log("test")
            this.vols = this.volsSource.filter(vol => vol.nomCompagnie.toLowerCase().includes(this.recherche.toLowerCase().trim()))
        },

        trier(evenement) {

            let attribut = evenement.target.id;
            // console.log(attribut)

            this.vols.sort((a,b) => { //fonction de tri
                if (a[attribut] > b[attribut]) {
                    return 1;
                }

                else if (a[attribut] < b[attribut]) {
                    return -1;
                }

                else {
                    return 0;
                }
            } )
            if(this.asc == false) {
                this.vols.reverse()
        }
        this.asc=!this.asc;

        

        }

    }
}




Vue.createApp(app).mount("#app");