class Participants
{
    constructor(_participantJson) { // création d'une copie modifiable du tableau d'objet
        this.prenom = '';
        this.nomDeFamille = '';
        this.pays = _participantJson.pays
        this.temps = _participantJson.temps
        this.SetNomComplet(_participantJson.nom);
    }

    SetNomComplet(_nomComplet) { // fonction afin de split le nom complet en nom/prenom
        _nomComplet = _nomComplet.split(" ");
        this.nomDeFamille = _nomComplet[0];
        this.prenom = _nomComplet [1];

    }
}

export {Participants }