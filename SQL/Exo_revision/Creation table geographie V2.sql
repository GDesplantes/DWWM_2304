DROP DATABASE if EXISTS GEOGRAPHIE;

CREATE DATABASE GEOGRAPHIE;

 

USE GEOGRAPHIE;

 

-- CREATION DES TABLES

 

CREATE TABLE PAYS (
                        num_pays INT PRIMARY KEY, 
                        nom_pays VARCHAR(50) NOT NULL, 
                        capitale VARCHAR(50) NOT NULL, 
                        superficieKm2 INT NOT NULL, 
                        date_adhesion_ONU DATE, 
                        population BIGINT NOT NULL, 
                        num_continent INT NOT NULL                        
                        );

CREATE TABLE CONTINENT (
                                num_continent INT AUTO_INCREMENT PRIMARY KEY,
                                nom_continent VARCHAR(50) NOT NULL
                                );

CREATE TABLE FLEUVE (
                            num_fleuve INT AUTO_INCREMENT PRIMARY KEY,
                            nom_fleuve VARCHAR(50)
                            );

CREATE TABLE TRAVERSER (
                                num_fleuve INT NOT NULL,
                                num_pays INT NOT NULL,
                                CONSTRAINT fk_traverser_num_fleuve FOREIGN KEY (num_fleuve) REFERENCES fleuve(num_fleuve),
                                CONSTRAINT fk_traverser_num_pays FOREIGN KEY (num_pays) REFERENCES pays(num_pays)
                                );

-- CREATION CLEF ETRANGERE

 

ALTER TABLE PAYS
                ADD CONSTRAINT fk_pays_num_contient FOREIGN KEY (num_continent) REFERENCES continent(num_continent);

 