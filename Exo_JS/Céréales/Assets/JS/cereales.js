//VARIABLES




//FONCTION
function afficherInfo() {
    let monTd = document.createElement('td')
    monTd.value="";
    document.getElementById("contenuTableau").appendChild(monTd);

    for (let i = 0; i<json.length ; i++) {
        console.log("test");
    }

}