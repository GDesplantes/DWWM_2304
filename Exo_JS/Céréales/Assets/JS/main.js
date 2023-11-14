// import { Db } from "./Db.js";

// const jsonUrl = './cereales.json'

// for ()

// console.log(jsonUrl);


const apiUrl = './Assets/JS/cereales.json';

async function fetchUrl() {
    let reponse = await fetch(apiUrl)
    let json = await reponse.json();

    console.log(json)

    function afficherInfo() {
        let monTr = document.createElement('tr')
        let monTd = document.createElement('td')
        monTd.textContent=json[i];
        for (let i = 0; i<json.length ; i++) {
            
            monTd.textContent=json[i];
            document.getElementById("contenuTableau").appendChild(monTr);
            document.getElementById("tr").appendChild(monTd)
    
        }

    }

}


fetchUrl();

