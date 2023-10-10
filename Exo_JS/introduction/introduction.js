// OBJETS
const inputPrenom = document.getElementById("prenomUser");
const inputAge = document.getElementById("ageUser");
const btnValider = document.getElementById("bouttonValider");
const textePrenomAge = document.getElementById("textePrenomEtAge");
const texteMajorite = document.getElementById("textePourLaMajorite")
const texteRetraite = document.getElementById("textePourLaRetraite")

// FONCTIONS
function validerPrenomAge() {
    return inputPrenom.value.trim().length > 0  && inputAge.value > 0;
   
}


function estMajeur() {
    return inputAge.value >= 18;

}


function tempRetraite() {
    let age = inputAge.value;
    if(inputAge.value>64) {
        texteRetraite.innerHTML = `Vous êtes à la Retraite depuis ${(age-64)} année(s).`;
    } 
    
    else if (inputAge.value<64) {
        texteRetraite.innerHTML = `Il vous reste ${(64-age)} année(s) avant la retraite.`;
    }

    else {
        texteRetraite.innerHTML = `Vous prenez votre retraite cette année!`
    }

}

// APPELS


btnValider.addEventListener("click", function() {
    if(validerPrenomAge()) {
        textePrenomAge.innerHTML = `Bonjour ${inputPrenom.value}, votre âge est :  ${inputAge.value} ans.`;
        
    }
    else {
        textePrenomAge.innerHTML = `Compléter/corriger le formulaire.`;
    }

    
    
    if(estMajeur()) {
        texteMajorite.innerHTML = `Vous êtes majeur.`;
    }
    else {
        texteMajorite.innerHTML = `Vous êtes mineur.`;
    }

    tempRetraite()

})




