
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
     let moisSigne = _mois

    let moisNaissance = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"]

    for(let i = 0; i < moisNaissance.length; i++ )
    {
        moisSigne=moisNaissance[i]
    }
    return _mois

}

console.log(calculerSigne(5));
