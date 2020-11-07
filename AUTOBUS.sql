CREATE TABLE CHOFER (
 CEDULA VARCHAR2(12),
 NOMBRE VARCHAR2(25) NOT NULL,
 APELLIDO VARCHAR2(25) NOT NULL,
 FECHA_NACIMIENTO DATE,
 ID_AUTOBUS NUMBER(4),
 ID_RUTA NUMBER(4),
 CONSTRAINT pk_chofer PRIMARY KEY (CEDULA),
 CONSTRAINT uq_chofer_id_autobus UNIQUE (ID_AUTOBUS),
 CONSTRAINT uq_chofer_id_ruta UNIQUE (ID_RUTA)
);

ALTER TABLE CHOFER
 ADD CONSTRAINT fk_chofer_id_autobus FOREIGN KEY (ID_AUTOBUS) REFERENCES AUTOBUS (ID_AUTOBUS) ON DELETE SET NULL;

 
ALTER TABLE CHOFER
 ADD CONSTRAINT fk_chofer_id_ruta FOREIGN KEY (ID_RUTA) REFERENCES RUTA (ID_RUTA) ON DELETE SET NULL;
 
CREATE TABLE AUTOBUS (
 ID_AUTOBUS NUMBER(4),
 CEDULA VARCHAR(12),
 MARCA VARCHAR2(10),
 MODELO VARCHAR2(10),
 PLACA VARCHAR2(25),
 COLOR VARCHAR2(10),
 AÑO VARCHAR2(4),
 ID_RUTA NUMBER(4),
 CONSTRAINT pk_autobus PRIMARY KEY (ID_AUTOBUS),
 CONSTRAINT fk_chofer  FOREIGN KEY (CEDULA) REFERENCES CHOFER (CEDULA) ON DELETE SET NULL,
 CONSTRAINT uq_autobus_cedula UNIQUE (CEDULA),
 CONSTRAINT uq_autobus_id_ruta UNIQUE (ID_RUTA)
);

ALTER TABLE AUTOBUS
 ADD CONSTRAINT fk_autobus_id_ruta FOREIGN KEY (ID_RUTA) REFERENCES RUTA (ID_RUTA) ON DELETE SET NULL;
 

CREATE TABLE RUTA (
 ID_RUTA NUMBER(4),
 RUTA VARCHAR2(25),
 ID_AUTOBUS NUMBER(4),
 CONSTRAINT pk_ruta PRIMARY KEY (ID_RUTA),
 CONSTRAINT fk_autobus FOREIGN KEY (ID_AUTOBUS) REFERENCES AUTOBUS (ID_AUTOBUS) ON DELETE SET NULL,
 CONSTRAINT  uq_ruta_id_autobus UNIQUE (ID_AUTOBUS),
 CONSTRAINT  uq_ruta_ruta UNIQUE (RUTA)
);



CREATE OR REPLACE PROCEDURE SP_CARGARCHOFERCOMPLETO ( refcargar out sys_refcursor, v_nombre in VARCHAR2 )
AS
 BEGIN
 OPEN refcargar for
 SELECT c.nombre, c.apellido, c.cedula, c.fecha_nacimiento, a.marca, a.modelo, r.ruta
 FROM chofer c JOIN autobus a ON (c.cedula = a.cedula)
 JOIN ruta r ON (a.id_autobus = r.id_autobus)
 WHERE c.nombre LIKE '%'||v_nombre||'%';
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_CARGARCHOFER ( refcargar out sys_refcursor, v_nombre in VARCHAR2 )
AS
 BEGIN
 OPEN refcargar for
 SELECT cedula, nombre, apellido, fecha_nacimiento  FROM chofer
 WHERE nombre LIKE '%'||v_nombre||'%';
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_CARGARCHOFERDISPONIBLE ( refcargar out sys_refcursor, v_nombre in VARCHAR2 )
AS
 BEGIN
 OPEN refcargar for
 SELECT cedula, nombre, apellido, fecha_nacimiento  FROM chofer
 WHERE nombre LIKE '%'||v_nombre||'%' AND ID_AUTOBUS IS NULL;
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_CARGARAUTOBUS ( refcargar out sys_refcursor, v_modelo in VARCHAR2 )
AS
 BEGIN
 OPEN refcargar for
 SELECT a.modelo, a.marca, c.nombre, c.apellido, a.cedula, a.color, a.placa, a.año
 FROM autobus a JOIN chofer c ON (a.cedula = c.cedula)
 WHERE a.modelo LIKE '%'||v_modelo||'%';
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_CARGARAUTOBUSDISPONIBLE ( refcargar out sys_refcursor, v_modelo in VARCHAR2 )
AS
 BEGIN
 OPEN refcargar for
 SELECT id_autobus, marca, modelo, placa, color, año
 FROM autobus 
 WHERE modelo LIKE '%'||v_modelo||'%' AND cedula IS NULL;
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_CARGARRUTA ( refcargar out sys_refcursor, v_ruta in VARCHAR2 )
AS
 BEGIN
 OPEN refcargar for
 SELECT id_ruta, ruta  FROM ruta
 WHERE ruta LIKE '%'||v_ruta||'%';
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_CARGARRUTADISPONIBLE ( refcargar out sys_refcursor, v_ruta in VARCHAR2 )
AS
 BEGIN
 OPEN refcargar for
 SELECT id_ruta, ruta  FROM ruta
 WHERE ruta LIKE '%'||v_ruta||'%' AND ID_AUTOBUS IS NULL;
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_INSERTARCHOFER ( v_cedula in VARCHAR2, v_nombre in VARCHAR2, v_apellido in VARCHAR2,
v_fecha_nacimiento in DATE)
AS
 BEGIN
 INSERT INTO CHOFER (cedula, nombre, apellido, fecha_nacimiento)
 VALUES (v_cedula, v_nombre, v_apellido, v_fecha_nacimiento);
 END;
 /
 
CREATE SEQUENCE SEQ_AUTOBUS
                START WITH 1
                MINVALUE 1
                INCREMENT BY 1
                NOCYCLE
                NOCACHE;
                
 
 
CREATE OR REPLACE PROCEDURE SP_INSERTARAUTOBUS ( v_marca in VARCHAR2, v_modelo in VARCHAR2, 
v_placa in VARCHAR2, v_color in VARCHAR2, v_año in VARCHAR2 )
AS
 BEGIN
 INSERT INTO AUTOBUS (id_autobus, marca, modelo, placa, color, año)
 VALUES (SEQ_AUTOBUS.NEXTVAL, v_marca, v_modelo, v_placa, v_color, v_año);
 END;
 /
 
CREATE SEQUENCE SEQ_RUTA
                START WITH 1
                MINVALUE 1
                INCREMENT BY 1
                NOCYCLE
                NOCACHE;
                
 
CREATE OR REPLACE PROCEDURE SP_INSERTARRUTA ( v_ruta in VARCHAR2 )
 AS
 BEGIN
 INSERT INTO RUTA (id_ruta, ruta)
 VALUES (SEQ_RUTA.NEXTVAL, v_ruta);
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_INSERTARCHOFER_AUTOBUS ( v_cedula in VARCHAR2, v_id_autobus in NUMBER )
AS
 BEGIN
 UPDATE CHOFER SET ID_AUTOBUS = v_id_autobus
 WHERE cedula = v_cedula;
 UPDATE AUTOBUS SET CEDULA = v_cedula
 WHERE ID_AUTOBUS = v_id_autobus;
 END;
 /
 
CREATE OR REPLACE PROCEDURE SP_INSERTARAUTOBUS_RUTA ( v_id_autobus in NUMBER, v_id_ruta in NUMBER )
AS
 BEGIN
 UPDATE AUTOBUS SET ID_RUTA = v_id_ruta;
 UPDATE RUTA SET ID_AUTOBUS = v_id_autobus;
 END;
 /

                
 
INSERT INTO RUTA(ID_RUTA, RUTA)
VALUES (SEQ_RUTA.NEXTVAL, 'Villa Mella');

INSERT INTO RUTA(ID_RUTA, RUTA)
VALUES (SEQ_RUTA.NEXTVAL, 'Sabana');

INSERT INTO RUTA(ID_RUTA, RUTA)
VALUES (SEQ_RUTA.NEXTVAL, 'Charles de Gaulle');

INSERT INTO RUTA(ID_RUTA, RUTA)
VALUES (SEQ_RUTA.NEXTVAL, 'La Churchill');

INSERT INTO RUTA(ID_RUTA, RUTA)
VALUES (SEQ_RUTA.NEXTVAL, 'Puente Juan Carlos');

--- Crear procedure de autobus asignados

COMMIT;

