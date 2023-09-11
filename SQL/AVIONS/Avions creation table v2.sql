DROP DATABASE if EXISTS travail_sql_avions;

CREATE DATABASE if NOT EXISTS travail_sql_avions;

USE travail_sql_avions;

DROP TABLE if EXISTS AVIONS

CREATE TABLE if NOT EXISTS AVIONS
(AV INT PRIMARY KEY,
AVMARQ VARCHAR(100),
AVTYPE VARCHAR(50),
CAP TINYINT,
LOC VARCHAR(100)
);

