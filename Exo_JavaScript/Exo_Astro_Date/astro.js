function remplirAnnee()
{
    for(i=1953;i<=2005;i++)
    {
        document.getElementById("annee").innerHTML+='<option value= \"'+i+'\">'+i+'</option>';
        
    }
}

let tabMois = ["Janvier","Février","Mars","Avril","Mai","Juin","Juillet","Août","Septembre","Octobre","Novembre","Décembre"];

function afficherMois()
{
    let monOption = document.createElement('option'); //création d'une balise "option"
    monOption.value="";
    monOption.textContent = "Choisir le mois"; //contenue texte
    document.getElementById("mois").appendChild(monOption);// on place la balise option dans le select "mois"

    for (let i=0 ; i<tabMois.length; i++)
    {
        monOption = document.createElement('option') // on recréé une succession d'élément option
        monOption.value= i+1; // on attribut une valeur a monOption
        // if (i+1 == 5) 
        // {
        //     monOption.setAttribute('selected', 'true')  Placer le mois de mais par défaut
        // }
        monOption.textContent =tabMois[i]; // contenue texte de mon option --> string a l'indice i du tableau
        document.getElementById("mois").options[i+1] = monOption; //
    }


}

function valNum(_maChaine)
{
    let somme = 0;
    let chaineMaj = _maChaine.toUpperCase();


    for(let i = 0; i < chaineMaj.length; i++)
    {
        
        somme += chaineMaj.charCodeAt(i) - 64;
    }

    return somme;

}

console.log(valNum("guillaume")); 



function calculerSigne(_mois)
{
    let tableauSigne = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"]
    let moisNaissance = _mois;

    return tableauSigne [moisNaissance-1];
}

console.log(calculerSigne(7));

//console.log(document.prenomUtilisateur.value)


remplirAnnee()

afficherMois()

