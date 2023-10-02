function remplirAnnee()
{
    for(i=1915;i<=2015;i++)
    {
        document.getElementById("annee").innerHTML+='<option>'+i+'</option>';
        
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

console.log(document.prenomUtilisateur.value)




