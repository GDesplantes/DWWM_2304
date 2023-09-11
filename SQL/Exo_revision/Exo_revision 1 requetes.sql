USE exo_revision_1;

/*1) Afficher la liste des clients appartenant à la catégorie tarifaire n°1, classée par ordre alphabétique */
SELECT clients.Nom_clt,clients.Num_cat
FROM clients WHERE Num_cat=1;


/*2) Afficher la liste des clients (code, nom de client) rattachés au représentant HINAUD */
SELECT clients.Code_clt,clients.Nom_clt
FROM clients
INNER JOIN representant ON clients.Num_rep = representant.Num_rep
WHERE representant.Nom_rep='HINAUD';

/*3) Afficher la liste des clients bénéficiant d'une remise de 10% */
SELECT clients.Nom_clt
FROM clients 
INNER JOIN categorie_tarifaire ON clients.Num_cat = categorie_tarifaire.Num_cat
WHERE categorie_tarifaire.Remise=0.10;
/*4) Afficher la liste des représentants (Numéro et nom) dépendant du chef de secteur PONS */
SELECT representant.Num_rep,representant.Nom_rep
FROM representant
INNER JOIN couvrir ON representant.Num_rep= couvrir.Num_rep
INNER JOIN departement ON couvrir.Code_dep= departement.Code_dep
WHERE departement.Chef_secteur='PONS';

/*5) Afficher la liste des départements (code, nom, chef de secteur) */
SELECT departement.Code_dep, departement.Nom_dep, departement.Chef_secteur
FROM departement;
/*6) Afficher la liste des chefs de secteur */
SELECT DISTINCT departement.Chef_secteur 
FROM departement;