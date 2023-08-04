USE db_architecte;


/*
9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet.
*/

SELECT projet_date_depot, projet_date_fin_prevue,projet_date_fin_effective,projet_prix
FROM PROJETS
FULL JOIN