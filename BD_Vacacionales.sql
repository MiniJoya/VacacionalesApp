CREATE DATABASE activaciones_prueba;

USE activaciones_prueba;

--Tablas--

CREATE TABLE usuarios(
    id_usuario int not null PRIMARY KEY AUTO_INCREMENT,
    user varchar(40) not null,
    pass varchar(40) not null
);

CREATE TABLE clientes(
    id_cliente int not null PRIMARY KEY AUTO_INCREMENT,
    no_contrato int not null UNIQUE,
    nombre varchar(40) not null,
    desarrollo varchar(40) not null,
    departamento varchar(40) not null,
    fechainiciocontrato date not null,
    fechafinalcontrato date not null,
    estadoact varchar(11)
);

CREATE TABLE desarrollos(
    id_desarrollo int not null PRIMARY KEY AUTO_INCREMENT,
    desarrollo varchar(40) not null
);

CREATE TABLE dias(
    no_contrato int,
    totaldias int,
    diasconsum int,
    diasdisp int
);

CREATE TABLE activacion(
    id_activacion int not null PRIMARY KEY AUTO_INCREMENT,
    fechainicioact date not null,
    fechafinalact date,
    no_contrato int not null,
    dias_consumidos int,
    indefinido varchar(10) not null
);

--Llaves foraneas--

ALTER TABLE activacion ADD FOREIGN KEY (no_contrato) REFERENCES clientes(no_contrato);
ALTER TABLE dias ADD FOREIGN KEY (no_contrato) REFERENCES clientes(no_contrato);