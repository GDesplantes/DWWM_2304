const btnCalculer = document.getElementById("bouttonCalculerDates");
const inputDateNaissance = document.getElementById("dateNaissance");
const textDate = document.getElementById("textePourLaDate")


const dateActuel = new Date();



//FONCTIONS// A CHIER A REFAIRE
function validerInputNaissance() {
    if (inputDateNaissance.value<=dateActuel.value) {

        textDate.innerHTML = `La date est valide `; // A MODIFIER
    }

    else {
        textDate.innerHTML = `Nope`
    }
    
}




//APPELS//
btnCalculer.addEventListener('click', function() {
console.log(inputDateNaissance.value);

validerInputNaissance();
})




//TEST//


//console.log(dateActuel.getTime());