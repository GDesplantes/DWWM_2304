const text = document.getElementById("Compteur")
const btnClick = document.getElementById("btn");
let nbClick=0;



btnClick.addEventListener('click', function() {
    nbClick++;
    text.innerHTML ="Vous avez cliqué "+nbClick+ " fois"

})
