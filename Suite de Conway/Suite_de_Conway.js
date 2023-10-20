const btnSimulation = document.getElementById("CommencerLaSimulation")
const debutSuite = '1';
const texteSuiteDeConway = document.getElementById("affichageSuiteConway")




function testWindowPrompt () {
    let _occurenceSimulation =Number(window.prompt("Combien de fois voulez vous effectuer la simulation",""));
    texteSuiteDeConway.innerHTML = _occurenceSimulation;
}

function CalculerSuiteConway() {
    console.log(debutSuite)


}





btnSimulation.addEventListener('click',function() {

testWindowPrompt()


CalculerSuiteConway()
})