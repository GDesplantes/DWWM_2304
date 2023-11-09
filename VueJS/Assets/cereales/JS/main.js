import { Cereales } from "./Cereales.js";

const app = {
    
    data() 
        {
        return {
            cereales :[],

        }

    },

    async mounted() {
        let response = await fetch('./Assets/cereales/cereales.json');
        this.cereales = await response.json();
        this.cereales = this.cereales.data;
        console.log(this.cereales);

        for ( let i = 0; i<this.cereales.length; i++) {
            this.cereales[i] = new Cereales(this.cereales [i]);
            console.log(this.cereales);

        }

    },

    methods : {

    },

    computed : {

    }

}


Vue.createApp(app).mount('#app');