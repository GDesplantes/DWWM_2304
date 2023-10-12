const texteDeLaDouille = document.getElementById("texteDouille");
const btnLaDouille = document.getElementById("laDouille");


function Douille() {
    let _texte = window.prompt("Est-ce la Douille  oui/non");
    
    if(_texte == "oui") {
        texteDeLaDouille.innerHTML = "CHEEEEEEEEEEEEEEEEEEEH";
    } 
    else if (_texte.toLowerCase() == "non") {
        texteDeLaDouille.innerHTML = " et ba si CHEEEEEEEEEEEEEEEEEEEH";
    }


}

btnLaDouille.addEventListener('click', function() {
    
    Douille()
})
