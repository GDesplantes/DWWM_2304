INSERT INTO continent (num_continent, nom_continent)
                VALUES
                        (1, 'Afrique'),
                        (2, 'Amerique'),
                        (3, 'Asie'),
                        (4, 'Europe'),
                        (5, 'Oceanie');

 

INSERT INTO PAYS (num_pays, nom_pays, capitale, superficieKm2, date_adhesion_ONU, population, num_continent)
                VALUES 
                        (1, 'Allemagne', 'Berlin', 356850, '1973-09-18', 83149300, 4),
                        (2, 'Australie', 'Canberra', 7682300, '1945-11-01', 24000300, 5),
                        (3, 'Autriche', 'Vienne', 83859, '1955-12-14', 8822267, 4),
                        (4, 'Brésil', 'Brasilia', 8511996, '1945-10-24', 211158000, 2),
                        (5, 'Bulgarie', 'Sofia', 110994, '1955-12-14', 7050034, 4),
                        (6, 'Canada', 'Ottawa', 9970610, '1945-11-09', 36963854, 2),
                        (7, 'Egypte', 'Le Caire', 997739, '1945-10-24', 101200000, 1),
                        (8, 'Etats Unis', 'Washington DC', 9529063, '1945-10-24', 3293160000, 2),
                        (9, 'France', 'Paris', 543965, '1945-10-24', 67064000, 4),
                        (10, 'Hongrie','Budapest', 93033, '1955-12-14', 9778371, 4),
                        (11, 'Slovaquie', 'Bratislava', 49035, '1993-01-19', 5443120, 4),
                        (12, 'Japon', 'Tokyo', 377832, '1956-12-18', 126010000, 3),
                        (13, 'Laos', 'Vientiane', 236800, '1955-12-14', 6803699, 3),
                        (14, 'Soudan', 'Khartoum', 2503890, '1956-11-12', 41511526, 1),
                        (16, 'Grèce', 'Athènes', 131957, '1945-10-25', 10738868, 4),
                        (17, 'Roumanie', 'Bucarest', 238397, '1955-12-14', 60317000, 4),
                        (20, 'Italie', 'Rome', 301336, '1955-12-14', 60317000, 4),
                        (23, 'Perou', 'Lima', 1285216, '1945-10-31', 32207685, 2),
                        (73, 'Espagne', 'Madrid', 505911, '1955-12-14', 46659302, 4),
                        (149, 'Belgique', 'Bruxelles', 30688, '1945-12-27', 11413203, 4),
                        (154, 'Luxembourg', 'Luxembourg', 2586, '1945-10-24', 602005, 4);

UPDATE PAYS
        SET population = 329316000
        WHERE num_pays = 8;

INSERT INTO fleuve (num_fleuve, nom_fleuve)
                VALUES
                        (1, 'Amazone'),
                        (2, 'Loire'),
                        (3, 'Seine'),
                        (4, 'Garonne'),
                        (5, 'Rhône'),
                        (6, 'Rhin'),
                        (7, 'Danube');

INSERT INTO traverser (num_fleuve, num_pays)
                VALUES
                        (1,4),
                        (1,23),
                        (2, 9),
                        (3,9),
                        (4,9),
                        (4, 73),
                        (5, 9);
