// // OBJETS
// const inputPrenom = document.getElementById("prenomUser");
// const inputAge = document.getElementById("ageUser");
// const btnValider = document.getElementById("bouttonValider");
// const textePrenomAge = document.getElementById("textePrenomEtAge");
// const texteMajorite = document.getElementById("textePourLaMajorite")
// const texteRetraite = document.getElementById("textePourLaRetraite")

// // FONCTIONS
// function validerPrenomAge() {
//     return inputPrenom.value.trim().length > 0  && inputAge.value > 0;
   
// }


// function estMajeur() {
//     return inputAge.value >= 18;

// }


// function tempRetraite() {
//     let age = inputAge.value;
//     if(inputAge.value>64) {
//         texteRetraite.innerHTML = `Vous êtes à la Retraite depuis ${(age-64)} année(s).`;
//     } 
    
//     else if (inputAge.value<64) {
//         texteRetraite.innerHTML = `Il vous reste ${(64-age)} année(s) avant la retraite.`;
//     }

//     else {
//         texteRetraite.innerHTML = `Vous prenez votre retraite cette année!`
//     }

// }

// // APPELS


// btnValider.addEventListener("click", function() {
//     if(validerPrenomAge()) {
//         textePrenomAge.innerHTML = `Bonjour ${inputPrenom.value}, votre âge est :  ${inputAge.value} ans.`;
        
//     }
//     else {
//         textePrenomAge.innerHTML = `Compléter/corriger le formulaire.`;
//     }

    
    
//     if(estMajeur()) {
//         texteMajorite.innerHTML = `Vous êtes majeur.`;
//     }
//     else {
//         texteMajorite.innerHTML = `Vous êtes mineur.`;
//     }

//     tempRetraite()

// })




// VARIABLES ==============================================
const btnValider = document.getElementById("valider");
const inputAge = document.getElementById("age");
const inputPrenom = document.querySelector("#prenom");
const divResultat = document.querySelector("#resultat");
const ageRetraite = 67;

// FONCTIONS===============================================
function agePrenomValide() {
    let prenom = inputPrenom.value.trim();
    let age = inputAge.value;
    return(prenom.length > 0 && age > 0);
}

function estMajeur(){
    return(inputAge.value >= 18)
}

function etatRetraite(){
    let reste;
    if(inputAge.value < ageRetraite){
        reste = ageRetraite - inputAge.value;
        return "Il vous reste <span>" + reste + "</span> année(s) avant la retraite."
    }
    else if(inputAge.value > ageRetraite){
        return "Vous êtes à la retraite depuis <span>" + (inputAge.value - ageRetraite) + "</span> année(s)."
    }
    else{
        return "Vous prenez votre retraite cette année."
    }
}
// EVENEMENTS====================================================

btnValider.addEventListener("click", ()=>{
    if(agePrenomValide()){
        divResultat.innerHTML = `Bonjour <span>${inputPrenom.value}</span>, votre âge est : <span>${inputAge.value}</span>.`;

        if(estMajeur()){
            divResultat.innerHTML += "<p>Vous êtes <span>majeur</span>.</p>"
        }
        else{
            divResultat.innerHTML += "<p>Vous êtes <span>mineur</span>.</p>"
        }

        divResultat.innerHTML += etatRetraite();
    }
    else{
        divResultat.innerHTML = "Compléter ou corriger le formulaire!";
    }
})