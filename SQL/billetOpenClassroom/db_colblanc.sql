DROP DATABASE if EXISTS db_colblanc;

CREATE DATABASE if NOT EXISTS db_colblanc;

DROP TABLE if EXISTS `institutions`

CREATE TABLE IF NOT EXISTS `institutions` (
  `identifiant` int(20) unsigned NOT NULL AUTO_INCREMENT,
  `nom_resp` varchar(100) DEFAULT NULL,
  `nom_etab` varchar(100) NOT NULL,
  `type_etab` varchar(100) NOT NULL,
  `nom_tut` varchar(100) DEFAULT NULL,
  `adresse` varchar(100) DEFAULT NULL,
  `cp` int(5) unsigned DEFAULT NULL,
  `ville` varchar(60) DEFAULT NULL,
  `depart` int(5) unsigned DEFAULT NULL,
  `Telephone` varchar(20) NOT NULL,
  `Fax` varchar(20) DEFAULT NULL,
  `email` varchar(60) DEFAULT NULL,
  `service` varchar(100) DEFAULT NULL,
  `desc` text,
  `mobile` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`identifiant`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=67 ;

--
-- Contenu de la table `institutions`
--

INSERT INTO `institutions` (`identifiant`, `nom_resp`, `nom_etab`, `type_etab`, `nom_tut`, `adresse`, `cp`, `ville`, `depart`, `Telephone`, `Fax`, `email`, `service`, `desc`, `mobile`) VALUES
(1, 'Jean SISSLER', 'SONY France', 'GE', 'Philippe TROESCH  ', 'ZA de Mulhbach', 68153, 'RIBEAUVILLE', 68, '0389735742', '', 'sidonie.halbout@eu.sony.com', 'Recherche et développement', '   Réalisation projet c# et winforms naviagation choix par  émotion de films par thème affichage jaquettes...         \r\nVisite SONY le 21 Mai 2012\r\ngestion des \r\nSuivis ingénieurs\r\nLuc BOUCHARD: 03.89.73.45.14\r\nJean SISSLER: 03.89.73.57.42\r\n', ''),
(2, 'GOUBET ', 'ESAT APF RIVERY', 'AUTRES', 'MIARD Julien', '14 rue Hélène Boucher', 80136, 'RIVERY', 80, '0322702090', '0', 'test@wanadoo.fr', 'informatique', 'fonctionnement          \r\n                        \r\n                        \r\n                        \r\n            ', '0322913776'),
(3, 'ABABSA TUFEK', 'GONZO compagnie', 'ASSOC', 'ABABSA Tufek', '14 rue Emmanuel CHABRIER', 76000, 'Rouen', 76, '0631293488', '', 'regiegonzo@gmail.com', 'communication web', 'Conception développement d''un site web \r\nUTILISATION PHP CRATION D''UN BASE DE DONNEES MySQL METHODE MERISE\r\nUtilisation de Wordpress.\r\ntuteur: Travail OK\r\nAssisuité: OK \r\nAvancement Rapport:OK\r\nappel téléphonique le 04/06/2012 ', '0631293488'),
(4, 'DELUBAC Lucille', 'Veolia', 'GE', 'DORNEVAL', '1 rue Giovanni Battista Pirelli \n<br>Saint-Maurice', 94410, 'Saint-Maurice', 94, '0171333342', '0171333500', 'lucille.delubac@veoliawater.com', 'Informatique central', 'Travail en Business Intelligence<br/>\r\nSatisfaction Entreprise: <br/> \r\nen B.I.<br/> \r\nAvancement projet OK <br/> \r\nEntretien téléphonique :14/05/2012 <br/> \r\nAvec Dorneval\r\nEntretien téléphonique :12/06/2012<br/>  \r\nAvec Delubac\r\ncontenu :\r\nOpus business Objet.\r\nAvec Datastage\r\nDesigner\r\ncreateview\r\nOutil de reporting\r\nBases de données : requête SQL\r\nEnvoie de la F.I.S.E\r\nvolonte de poursuivre en CDI\r\n\r\n', ''),
(5, 'MEYER Philippe', 'communauté Urbaine Strasbourg', 'CT', 'MEYER Philippe', '1, Parc de l''Etoile', 67076, 'Strasbourg', 67, '0388609090', '', 'Philippe.MEYER2@strasbourg.eu', 'informatique', 'geolocalisation', 'Poste37953'),
(7, NULL, 'Recherches en cours ', '', '', '', 0, '', NULL, '', NULL, NULL, NULL, '', NULL),
(15, 'DAUMAS', 'AMPLOI', 'PME', 'Daumas', '21 rue Bocquet Boulie', 60240, 'Montagny-en-Vexin', 60, '0670292504', '', 'jjdaumas@gmail.com', 'consultant  ISAGRI', '                        Mission Isagri\r\n            \r\n                        \r\n            ', '0670292504'),
(16, 'HURST Chantal', 'Mairie Mulhouse', 'AUTRES', 'DELALEX', '2 Rue Pierre et Marie Curie  ', 68200, 'Mulhouse', 68, '0389337835', '', 'Chantal.Hurst@mulhouse-alsace.fr', 'Services Personnes Âgées, Famille et Personnes Handicapées', '                                                            service info Mairie            \r\n                        \r\n                        \r\n                        \r\n                        \r\n                        \r\n                        \r\n            ', '0629485604'),
(19, '', 'OPEN', 'GE', '', '20 B, rue Chemnitz ZAC Mer Rouge', 68200, 'Mulhouse', 68, '03 87 74 26 00', '', 'contact@open-groupe.com', '', '', ''),
(20, '', 'AEMO', 'PME', '', '1 rue des Alpes F', 68390, 'SAUSHEIM', 68, '', '', 'info@aemofrance.fr', 'automatisme et  info. indus', 'www.aemofrance.fr ', ''),
(21, '', 'Alcatel-Lucent', 'GE', '', '1 Rue du Docteur Albert Schweitzer', 67400, 'Illkirch-Graffenstaden', 67, '03 90 67 67 90', '', 'contact@alcatel-lucent.com', 'developpement informatique', '', ''),
(22, 'Zimmermann', 'ALTRAN', 'GE', '', 'BOULEVARD SEBASTIEN BRANT IMM GAUSSE', 67400, 'ILLKIRCH GRAFFENSTADEN', 67, '', '', '', '', '', ''),
(23, 'LUCE', 'Air France KLM', 'GE', 'LUCE ', '2 rue Robert Esnault-Pelterie', 67000, 'Strasbourg', 67, '0030303030', '', 'contact@airfrance.fr', '', '                        \r\n            ', ''),
(24, 'Terrin', 'Schaeffler france', 'PME', 'Christ', '93, route de Bitche', 67506, 'HAGUENAU', 67, '0388053186', '0388634215', 'Geraldine.terrin@schaeffler.com', 'informatique', 'Projet info. développement .asp et sqlserver 2005.              \r\n            ', ''),
(25, 'SCHWOB-DUMALIN Isabelle', 'ADTourisme CG68', 'CT', 'SCHWOB-DUMALIN', '1,rue Schlumberger', 68000, 'Colmar', 68, '0389201068', '0389233391', 'contact@adtcg68.fr', 'agence départementale du tourisme', 'réalisation site internet dynamique webserveur .php tourisme guerre 14-18           \r\n            ', ''),
(26, 'LEOPOLD Charles', 'Mission locale Mairie  ', 'CT', 'RITZENTHALER Stéphanie', '2 rue Saint Léonard', 67000, 'Selestat', 67, '0388580015', '0388923846', 'stephanie@milosel.fr', 'Direction', '            réalisation, site internet .php objet insertion professionnelle mission Locale Sélestat.                     \r\n                        \r\n                        \r\n            ', '  '),
(27, 'Karine CLAMER & Nadia Moussaki', 'ORANGE: IT & LABS  ', 'GE', 'Michel PARUSSINI ', '139 rue Vendôme', 69006, 'Lyon', 69, '0437246284', '', 'michel.parussini@orange.fr', 'developpement info.', '            Projet de refonte du Système de gestion et Accréditations pour enceintes événementielles. .asp C# sqlServer                                \r\n                        \r\n                        \r\n            ', '0437246962'),
(30, 'Ferrie-cano ', 'Music Al Sol', 'ASSOC', 'Ferrie-cano Nathalie', '8 lot. Pelissié', 11700, 'La REDORTE', 11, '0468439376', '', 'musicalsol11@gmail.com', 'facturation', '            création d''un logiciel ADO.NET et SGBD ACCESS            \r\n            ', ''),
(31, 'Huget RÃ©mi', 'TIKIMOVE', 'PME', 'HUGUET Rémi', '2, rue du Commandant Cousteau ', 33100, 'BORDEAUX', 33, '0556671501', '', 'remi.huguet@tikimove.com', 'dÃ©veloppement appli. mobile', 'CrÃ©ation d''application Mobile.\r\n\r\n', ''),
(32, 'PETITEAU ludovic', 'TALARON Services', 'PME', 'BENHAIM Sandrine', 'Parc EurÃªka - BÃ¢timent HellÃ¨ne - 222, Rue d\\''Odin', 34000, 'MONTPELLIER', 34, '0411280030', '', 'lpetiteau@talaron.com', 'Production', '            Partie du SI Ã  rÃ©aliser plus la conception gÃ©nÃ©rale du S.I.            \r\n                        \r\n            ', ''),
(33, 'RIOULT', 'LGR INFORMATIQUE', 'PME', 'STÉPHANE RIOULT', '5 Place de la Poissonnerie', 50200, 'COUTANCES', 50, '0233475550', '', 'stephane@option-ouest.com', 'DÃ©veloppement informatique', 'Projet liaison site web avec systÃ¨me gestion compta. des ventes (stocks).', ''),
(34, 'SENLANNE', 'SOGETI Siège PARIS', 'GE', 'Monsieur SENLANNE', '22-24, Rue Du Gouverneur GÃ©nÃ©ral EbouÃ©', 92136, 'Issy les Moulinaux', 92, '0155 001200', '0155001230', 'ebmaster.s.fr@sogeti.com', 'projet informatique interne', '            java JEE, PHP et Symphonie2            \r\n            ', ''),
(36, 'DELAYE Mathieu', 'M.D.S.I.', 'PME', 'DARNIS Nicolas', '3 rue AndrÃ© BÃ©nac', 33190, 'LA RÃ©ole', 33, '0556713235', '0957683235', 'mdsi@mdsi.fr ', 'creation de site internet ou intranet', 'services aux professionnels ', ''),
(37, 'Olivier Salomon', 'PROSODIE filiale CAPGEMINI', 'GE', 'SOUCHON Fréderic', '81, Boulevard du Parc d\\''Artillerie', 69007, 'LYON', 69, '04 72 80 72 80', '04 72 80 72 66', 'prosodie@test.fr', 'Projet developpement en JAVA', '            Développement d\\''un applicatif de test client serveur en JAVA            \r\n                        \r\n            ', '0472807272'),
(38, 'OLIVES Alain', 'Arche SI', 'PME', 'Olives Alain', '2, Rue Marcel DORET', 31700, 'Blagnac', 31, '0682884933', '', 'alain.olives@archesi-ea.com', 'SSII ', 'Entreprise SSII AdaptÃ©e dans le dÃ©veloppement informatique.            \r\n                        \r\n            ', ''),
(39, 'BERTOU eric ', 'Webecom-Studio', 'TPE', 'Bertou Eric', '20, Antoine DURAFOUR', 42000, 'Saint-Etienne', 42, '0953416402', '', 'contact@webecom-studio.com', 'Service developpement site web', 'DÃ©veloppement d''un  WebServeur...\r\n', ''),
(41, 'PRETTRE KÃ©vin', 'GRAPH-E', 'PME', 'Kévin PRETTRE', '3, rue du Bicentenaire ', 92800, 'PUTEAUX', 92, '0661439111', '', 'kprettre@graph-e.com', 'webagency', 'dÃ©veloppement applicatif site internet', '0661439111'),
(42, 'Fabrice GROSJEAN ', 'ISICONCEPT', 'PME', 'Fabrice GROSJEAN', '6, avenue du Parc', 25000, 'BESANÃ‡ON', 25, '0381412488', '', 'info@isiconcept.fr ', 'Progiciel ', 'RÃ©alisation applicatif logiciel ', ''),
(43, 'Maryline Dietrich', 'Inventiv Creative ', 'TPE', 'Cyril Hekpazo', '17, route de strasbourg', 67500, 'Haguenau', 67, '0388932445', '', 'maryline.dietrich@inventiv.fr', 'Developpement', 'Applicatif web via CMS', '0679786221'),
(44, 'IENCO LUCIE', 'Imagin L''Agence', 'TPE', 'Lucie IENCO', '15, rue du Conte de la Suze ', 90000, 'Belfort', 90, '0384226148', '', 'lucieienco@imaginlagence.fr', 'Conception ', 'Responsable de la rÃ©alisation de site web Responsive... ', ''),
(45, 'Gille LEFRANC ', 'CGI Bretagne', 'GE', 'CHOSSAT Benjamin', 'Immeuble Newton 3 bis avenue  de Belle fontaine', 35510, 'CESSON SEVIGNE', 35, '0214378000', '', 'benjamin.chossat@cgi.com', 'Consultant Solutions senior', '', ''),
(46, 'GUY BÃ©atrice', 'SOGETI  Ile de France', 'GE', 'GUY Béatrice', '22,24 rue  du Gouverneur Général Ebouée', 92136, 'ISSY les MOULINAUX', 92, '0155001200', '', 'beatrice.guy@sogeti.com', '', ' FSL Fiche Stratigraphique numérique archeologue  application pour mobile archeologue                                               \r\n                        \r\n                        \r\n            ', ''),
(47, 'ACKER Geoffroy', 'CGI ILLKICH (Logica)', 'GE', 'ACKER Geoffroy', 'Boulevard SÃ©bastien BRANDT', 67400, 'ILLKIRCH', 67, '0388553370', '', 'acker.geoffroy@cgi.fr', '', '                        \r\n            ', ''),
(48, 'EGGENSPIELLER Thomas', 'SADEF', 'PME', 'EGGENSPIELLER Thomas', '30, rue de la station', 68700, 'ASPACH LE BAS', 68, '0389627230', '', 'thomas@eggenspieler.net', 'Expertise des intrants', '       DES EXPERTS EN AGRONOMIE ET EN ENVIRONNEMENT A VOTRE SERVICE                    \r\n            ', ''),
(49, 'CHAUX Pierre', 'ALPAMAYO', 'PME', 'CHAUX Pierre', '1, rue Saint FranÃ§ois', 38000, 'GRENOBLE', 38, '0476860935', '', 'contact@alpamayo.net', 'DÃ©veloppement de logiciels techniques et scientifiques, ', 'DÃ©veloppement de logiciels techniques et scientifiques\r\nSIG base de donnÃ©es', ''),
(50, 'M. HECKMANN Dominique', 'IMMOBILIERE HECKMANN', 'TPE', 'HECKMANN Dominique ', '4b rue de la Chapelle', 67120, 'DACHSTEIN', 67, '0388493910', '', 'immo.heckmann@sfr.fr', 'direction commerciale', '', ''),
(51, 'Diana MARIBEL  RIOS RIVERA', 'COLOMVIENNE', 'ASSOC', 'Jairo MERCHANCANO', 'residence du Petit BREUIL', 862000, 'Poitiers', 86, '0651722776', '', 'test@test.fr', '', '                                    Développement d\\''un site Internet...\r\nStage en Télétravail.\r\n\r\n            \r\n                        \r\n                        \r\n                        \r\n            ', ''),
(52, 'GUICHEREAU  Anne-Marie ', 'SOGETI TOULOUSE', 'GE', 'TOULOT Eric', '3 Chemin Laporte', 31300, 'Toulouse', 31, '0534469011', '', 'anne-marie.guichereau@sogeti.com', '', '            Ajout de fonctionnalitÃ©s d''un site intranet de gestion centralisÃ©s de compÃ©tences.\r\nApache-PHP5/MYSQL            \r\n            ', ''),
(53, 'Philippe GRAND', 'EDF -UNITED ESIP', 'GE', 'Gaudin', '99 cours Gambetta', 69009, 'LYON', 69, '0557352433', '', 'philippe.grand@edf.fr', 'EDF-DPI  DAIP UNITED ESIP', '', '0662267468'),
(54, 'Laurie MELLOT', 'MODIS', 'PME', 'Laurie MELLOT', '15 Rue  La Tannerie', 57, 'Saint Julien lÃ¨s Metz', 57, '03 87 18 78 78', '', 'laurie.mellot@modisfrance.fr', 'Developpement', '', ''),
(55, 'Marie-josephe Jacquemart', 'Banque Populaire  Besancon', 'GE', 'Maillet Gilles', '1, place de la 1Ã¨re ArmÃ©e  FranÃ§aise', 25087, 'BesanÃ§on', 25, '0381652588', '0381652588', 'marie-josephe.jacquemart@bpbfc.banquepopulaire.fr', 'informatique', 'modÃ©lisation base de donnÃ©es... ', ''),
(56, 'Jacques LOSSON', 'Le Phare Fondation', 'ASSOC', 'Jacques LOSSON', '16 rue de Kingersheim', 68110, 'ILLZACH CEDEX', 68, '06.71.20.41.97', '', 'jlosson@ids-lephare.com', 'informatique', 'Adaptation projet  .PHP et MySqL pour Jaws\r\n\r\nAssociation siret 778 921 437 00019 ', ''),
(60, 'BAUDOUIN', 'Union Dept.Asso. Familiales UDAF', 'AUTRE', 'GILDAS', '171 Avenue de Nantes ', 79025, 'NIORT', 79, '05 16  06 23 00', '05 17 87 00 85', 'mt.baudouin@udaf79.asso.fr', 'DSI', 'Projet desvpt WEB php Mysql (migration bases données EXCEL                        \r\n            ', ''),
(61, 'Mireille STREBLY', 'SNCF-Mulhouse', 'GE', ' Springer  Emmanuel', '3 boulevard wilson  ', 67063, 'Strasbourg', 67, '0354734433', '03 88 75 43 43', 'ludivine.degruttola@sncf.fr', 'developpement Info', '                        \r\n            ', ''),
(62, 'MARCHAL Dragica ', 'ATOS', 'GE', 'MARCHAL Dragica ', '28 rue Gustave Eiffel', 38027, 'GRENOBLE', 38, '0438125630', '0438125630', 'dragica.marchal@atos.net', 'conception developpement', 'Recherche', ''),
(63, 'FAGES jean-Marc', 'histoiredutemps', 'TPE', 'FAGES jean-Marc', ' 11 rue des Fabriques HÃ´tel Marozeau', 68470, 'Husseren-Wesserling', 68, '03 89 26 94 99', '', 'info@histoiredutemps.fr', 'developpement site internet', 'DÃ©veloppement site internet', '');


-- Structure de la table `departements`
--

DROP TABLE if EXISTS `departements`

CREATE TABLE `departements` (
  `id_dep` int(10) UNSIGNED NOT NULL,
  `Name` varchar(50) NOT NULL,
  `dep_actif` int(10) UNSIGNED NOT NULL,
  `dep_taux` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Departements';

--
-- chargement des données de la table `departements`
--

INSERT INTO `departements` (`id_dep`, `Name`, `dep_actif`, `dep_taux`) VALUES
(1, '01 - Ain', 1, 1.00),
(2, '02 - Aisne', 1, 1.00),
(3, '03 - Allier', 1, 1.00),
(4, '04 - Alpes-de-Haute-Provence', 1, 1.00),
(5, '05 - Hautes-Alpes', 1, 1.00),
(6, '06 - Alpes-Maritimes', 1, 1.00),
(7, '07 - Ardèche', 1, 1.00),
(8, '08 - Ardennes', 1, 1.00),
(9, '09 Ariège', 1, 1.00),
(10, '10 - Aube', 1, 1.00),
(11, '11 - Aude', 1, 1.00),
(12, '12 - Aveyron', 1, 1.00),
(13, '13 - Bouches-du-Rhône', 1, 1.00),
(14, '14 - Calvados', 1, 1.00),
(15, '15 - Cantal', 1, 1.00),
(16, '16 - Charente', 1, 1.00),
(17, '17 - Charente-Maritime', 1, 1.00),
(18, '18 - Cher', 1, 1.00),
(19, '19 - Corrèze', 1, 1.00),
(20, '2A 2B - Départements Corse', 1, 1.00),
(21, '21 - Côte-d Or', 1, 1.00),
(22, '22 - Côtes-d Armor', 1, 1.00),
(23, '23 - Creuse', 1, 1.00),
(24, '24 - Dordogne', 1, 1.00),
(25, '25 - Doubs', 1, 1.00),
(26, '26 - Drôme', 1, 1.00),
(27, '27 - Eure', 1, 1.00),
(28, '28 - Eure-et-Loir', 1, 1.00),
(29, '29 - Finistère', 1, 1.00),
(30, '30 - Gard', 1, 1.00),
(31, '31 - Haute-Garonne', 1, 1.00),
(32, '32 - Gers', 1, 1.00),
(33, '33 - Gironde', 1, 1.00),
(34, '34 - Hérault', 1, 1.00),
(35, '35 - Ille-et-Vilaine', 1, 1.00),
(36, '36 - Indre', 1, 1.00),
(37, '37 - Indre-et-Loire', 1, 1.00),
(38, '38 - Isère', 1, 1.00),
(39, '39 - Jura', 1, 1.00),
(40, '40 - Landes', 1, 1.00),
(41, '41 - Loir-et-Cher', 1, 1.00),
(42, '42 - Loire', 1, 1.00),
(43, '43 - Haute-Loire', 1, 1.00),
(44, '44 - Loire-Atlantique', 1, 1.00),
(45, '45 - Loiret', 1, 1.00),
(46, '46 - Lot', 1, 1.00),
(47, '47 - Lot-et-Garonne', 1, 1.00),
(48, '48 - Lozère', 1, 1.00),
(49, '49 - Maine-et-Loire', 1, 1.00),
(50, '50 - Manche', 1, 1.00),
(51, '51 - Marne', 1, 1.00),
(52, '52 - Haute-Marne', 1, 1.00),
(53, '53 - Mayenne', 1, 1.00),
(54, '54 - Meurthe-et-Moselle', 1, 1.00),
(55, '55 - Meuse', 1, 1.00),
(56, '56 - Morbihan', 1, 1.00),
(57, '57 - Moselle', 1, 1.00),
(58, '58 - Nièvre', 1, 1.00),
(59, '59 - Nord', 1, 1.00),
(60, '60 - Oise', 1, 1.00),
(61, '61 - Orne', 1, 1.00),
(62, '62 - Pas-de-Calais', 1, 1.00),
(63, '63 - Puy-de-Dôme', 1, 1.00),
(64, '64 - Pyrénées-Atlantiques', 1, 1.00),
(65, '65 - Hautes-Pyrénées', 1, 1.00),
(66, '66 - Pyrénées-Orientales', 1, 1.00),
(67, '67 - Bas-Rhin', 1, 1.00),
(68, '68 - Haut-Rhin', 1, 1.00),
(69, '69 - Rhône', 1, 1.00),
(70, '70 - Haute-Saône', 1, 1.00),
(71, '71 - Saône-et-Loire', 1, 1.00),
(72, '72 - Sarthe', 1, 1.00),
(73, '73 - Savoie', 1, 1.00),
(74, '74 - Haute-Savoie', 1, 1.00),
(75, '75 - Paris', 1, 1.00),
(76, '76 - Seine-Maritime', 1, 1.00),
(77, '77 - Seine-et-Marne', 1, 1.00),
(78, '78 - Yvelines', 1, 1.00),
(79, '79 - Deux-Sèvres', 1, 1.00),
(80, '80 - Somme', 1, 1.00),
(81, '81 - Tarn', 1, 1.00),
(82, '82 - Tarn-et-Garonne', 1, 1.00),
(83, '83 - Var', 1, 1.00),
(84, '84 - Vaucluse', 1, 1.00),
(85, '85 - Vendée', 1, 1.00),
(86, '86 - Vienne', 1, 1.00),
(87, '87 - Haute-Vienne', 1, 1.00),
(88, '88 - Vosges', 1, 1.00),
(89, '89 - Yonne', 1, 1.00),
(90, '90 - Territoire de Belfort', 1, 1.00),
(91, '91 - Essonne', 1, 1.00),
(92, '92 - Hauts-de-Seine', 1, 1.00),
(93, '93 - Seine-Saint-Denis', 1, 1.00),
(94, '94 - Val-de-Marne', 1, 1.00),
(95, '95 - Val-dOise', 1, 1.00);

--

--

--
-- Index pour la table `departements`
--
ALTER TABLE `departements`
  ADD PRIMARY KEY (`id_dep`);
