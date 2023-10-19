const texteDeLaDouille = document.getElementById("texteDouille");
const btnLaDouille = document.getElementById("laDouille");
const dialog = document.querySelector("dialog");
const showButton = document.querySelector("dialog + button");
const closeButton = document.querySelector("dialog button");


function Douille() {
    let _texte = window.prompt("Est-ce la Douille  oui/non/tg");
    
    if(_texte == "oui") {
        texteDeLaDouille.innerHTML = "CHEEEEEEEEEEEEEEEEEEEH";
    } 
    else if (_texte.toLowerCase() == "non") {
        texteDeLaDouille.innerHTML = " et ba si CHEEEEEEEEEEEEEEEEEEEH";
    }
    else if (_texte.toLowerCase() == "tg") {
        texteDeLaDouille.innerHTML = "\uD83D\uDD95"
    }
    else {
        texteDeLaDouille.innerHTML = "cette réponse n'est pas une de celles souhaitée \uD83D\uDD95"
    }


}

btnLaDouille.addEventListener('click', function() {
    
    Douille()
})

// Le bouton "Afficher la fenêtre" ouvre le dialogue
showButton.addEventListener("click", () => {
  dialog.showModal();
});

// Le bouton "Fermer" ferme le dialogue
closeButton.addEventListener("click", () => {
  dialog.close();
});