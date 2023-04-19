CREATE DATABASE RESTAURANTE;
USE RESTAURANTE;
GO

CREATE TABLE CATEGORIA (
    categoria_id          VARCHAR(3) NOT NULL,
    categoria_nombre      VARCHAr(30) NOT NULL UNIQUE,
    categoria_descripcion VARCHAR(200) NOT NULL,
    categoria_encargado   VARCHAR(50) NOT NULL
);
GO

ALTER TABLE CATEGORIA ADD CONSTRAINT categoria_pk PRIMARY KEY ( categoria_id );

CREATE TABLE INGREDIENTE (
    ingrediente_id               VARCHAR(4) NOT NULL,
    ingrediente_nombre           VARCHAR(30) UNIQUE,
    ingrediente_unidad_medida           VARCHAR(20) NOT NULL,
    ingrediente_cantidad_almacen VARCHAR(4) NOT NULL
);


ALTER TABLE INGREDIENTE ADD CONSTRAINT ingrediente_pk PRIMARY KEY ( ingrediente_id );

CREATE TABLE PLATILLO (
    plato_id               VARCHAR(3) NOT NULL,
    plato_nombre           VARCHAR(50) NOT NULL,
    plato_descripcion      VARCHAR(200) NOT NULL,
    plato_dificultad       VARCHAR(8) NOT NULL,
    plato_foto             IMAGE NOT NULL,
    plato_preciof          DECIMAL(6, 2),
    categoria_id VARCHAR(3) NOT NULL
);

ALTER TABLE PLATILLO ADD CONSTRAINT platillo_pk PRIMARY KEY ( plato_id );

ALTER TABLE PLATILLO
    ADD CONSTRAINT platillo_categoria_fk FOREIGN KEY (categoria_id )
        REFERENCES categoria ( categoria_id );

CREATE TABLE RECETA (
    no_paso        VARCHAR(2) NOT NULL,
    plato_id VARCHAR(3) NOT NULL,
    descripcion    VARCHAR(200) NOT NULL
);

ALTER TABLE RECETA ADD CONSTRAINT receta_pk PRIMARY KEY ( plato_id,
                                                          no_paso );

ALTER TABLE RECETA
    ADD CONSTRAINT receta_plato_fk FOREIGN KEY ( plato_id )
        REFERENCES platillo ( plato_id );

CREATE TABLE PLATILLO_INGREDIENTE (
    platillo_id             VARCHAR(3) NOT NULL,
    ingrediente_id       VARCHAR(4) NOT NULL,
    cantidad_ingre_plato decimal(6, 3) NOT NULL
);

ALTER TABLE PLATILLO_INGREDIENTE ADD CONSTRAINT platillo_ingrediente_pk PRIMARY KEY ( platillo_id,
                                                                                      ingrediente_id );

ALTER TABLE platillo_ingrediente
    ADD CONSTRAINT platillo_ingrediente_fk FOREIGN KEY ( ingrediente_id )
        REFERENCES ingrediente ( ingrediente_id );

ALTER TABLE platillo_ingrediente
    ADD CONSTRAINT ingrediente_plato_fk FOREIGN KEY ( platillo_id )
        REFERENCES platillo ( plato_id );