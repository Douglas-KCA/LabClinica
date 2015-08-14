--
-- ER/Studio 8.0 SQL Code Generation
-- Company :      company
-- Project :      ERLaboratorio.DM1
-- Author :       Windows User
--
-- Date Created : Thursday, August 13, 2015 16:49:38
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: MaASEGURADORA 
--

CREATE TABLE MaASEGURADORA(
    ncodaseguradora    INT(10)    NOT NULL AUTO_INCREMENT,
    cempresaseguro     CHAR(100)         NOT NULL,
    PRIMARY KEY (ncodaseguradora)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDEUDA 
--

CREATE TABLE MaDEUDA(
    ncoddeuda      INT(10)    NOT NULL AUTO_INCREMENT,
    ntotaldeuda    DECIMAL(10, 2)    NOT NULL,
    nsaldodeuda    DECIMAL(10, 2)    NOT NULL,
    ncodfactura    DECIMAL(10, 0),
    PRIMARY KEY (ncoddeuda)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaETIQUETA 
--

CREATE TABLE MaETIQUETA(
    ncodetiqueta    INT(10)    NOT NULL AUTO_INCREMENT,
    ncodmuestra     DECIMAL(10, 0),
    PRIMARY KEY (ncodetiqueta)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaFACTURA 
--

CREATE TABLE MaFACTURA(
    ncodfactura      INT(10)    NOT NULL AUTO_INCREMENT,
    ctipopago        CHAR(10)          NOT NULL,
    dfechafactura    DATE              NOT NULL,
    ncodpaciente     DECIMAL(10, 0),
    PRIMARY KEY (ncodfactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaMEMBRESIA 
--

CREATE TABLE MaMEMBRESIA(
    ncodmembresia     INT(10)    NOT NULL AUTO_INCREMENT,
    ctipomembresia    CHAR(100)         NOT NULL,
    cporcentaje       CHAR(10)          NOT NULL,
    PRIMARY KEY (ncodmembresia)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaMUESTRA 
--

CREATE TABLE MaMUESTRA(
    ncodmuestra        INT(10)    NOT NULL AUTO_INCREMENT,
    crequerimientos    CHAR(250),
    cdescmuestra       CHAR(200)         NOT NULL,
    PRIMARY KEY (ncodmuestra)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPERSONA 
--

CREATE TABLE MaPERSONA(
    ncodpersona         INT(10)    NOT NULL AUTO_INCREMENT,
    cnombrepersona      CHAR(200)         NOT NULL,
    capellidopersona    CHAR(250)         NOT NULL,
    cdpipersona         CHAR(20)          NOT NULL,
    dfechanacpersona    CHAR(10)          NOT NULL,
    csexopersona        CHAR(10)          NOT NULL,
    cnitpersona         CHAR(10)          NOT NULL,
    PRIMARY KEY (ncodpersona)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaPUESTO 
--

CREATE TABLE MaPUESTO(
    ncodpuesto     INT(10)    NOT NULL AUTO_INCREMENT,
    ndescpuesto    CHAR(250)        NOT NULL,
    PRIMARY KEY (ncodpuesto)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaSUCURSAL 
--

CREATE TABLE MaSUCURSAL(
    ncodsucursal       INT(10)    NOT NULL AUTO_INCREMENT,
    cnombresucursal    CHAR(100),
    cubicacion         CHAR(100)         NOT NULL,
    PRIMARY KEY (ncodsucursal)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTARIFASEGURO 
--

CREATE TABLE MaTARIFASEGURO(
    ncodtarifa           INT(10)    NOT NULL AUTO_INCREMENT,
    nporcentajetarifa    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (ncodtarifa)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTIPOEXAMEN 
--

CREATE TABLE MaTIPOEXAMEN(
    ncodtipo             INT(10)    NOT NULL AUTO_INCREMENT,
    cdesctipoexamen      CHAR(100),
    cpreciotipoexamen    CHAR(10)          NOT NULL,
    ncodmuestra          DECIMAL(10, 0),
    PRIMARY KEY (ncodtipo)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrANALISIS 
--

CREATE TABLE TrANALISIS(
    ncodanalisis    INT(10)    NOT NULL AUTO_INCREMENT,
    cdescripcion    CHAR(250)        NOT NULL,
    ncodservicio    DECIMAL(10, 0),
    ncodigocita     DECIMAL(10, 0),
    ncodsucursal    DECIMAL(10, 0),
    ncodtipo        DECIMAL(10, 0),
    ncodpaciente    DECIMAL(10, 0),
    ncodetiqueta    DECIMAL(10, 0),
    PRIMARY KEY (ncodanalisis)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrBITACORA 
--

CREATE TABLE TrBITACORA(
    ncodbitacora          INT(10)    NOT NULL AUTO_INCREMENT,
    ncodusuario           DECIMAL(10, 0)    NOT NULL,
    dfechabitacora        DATE              NOT NULL,
    chorabitacora         CHAR(10),
    cactividadbitacora    CHAR(100)         NOT NULL,
    PRIMARY KEY (ncodbitacora, ncodusuario)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrCITA 
--

CREATE TABLE TrCITA(
    ncodigocita     INT(10)    NOT NULL AUTO_INCREMENT,
    ncodsucursal    DECIMAL(10, 0)    NOT NULL,
    ncodpaciente    DECIMAL(10, 0)    NOT NULL,
    dfechacita      DATE              NOT NULL,
    choracita       CHAR(10)          NOT NULL,
    PRIMARY KEY (ncodigocita, ncodsucursal, ncodpaciente)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrDIRECCION 
--

CREATE TABLE TrDIRECCION(
    ncoddireccion    INT(10)    NOT NULL AUTO_INCREMENT,
    cdireccion       CHAR(250),
    ncodpersona      DECIMAL(10, 0),
    PRIMARY KEY (ncoddireccion)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrEMAIL 
--

CREATE TABLE TrEMAIL(
    ncodemail      INT(10)    NOT NULL AUTO_INCREMENT,
    cemail         CHAR(100),
    ncodpersona    DECIMAL(10, 0),
    PRIMARY KEY (ncodemail)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrEMPLEADO 
--

CREATE TABLE TrEMPLEADO(
    ncodempleado    INT(10)    NOT NULL AUTO_INCREMENT,
    ncodpersona     DECIMAL(10, 0),
    ncodpuesto      DECIMAL(10, 0),
    PRIMARY KEY (ncodempleado)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrPACIENTE 
--

CREATE TABLE TrPACIENTE(
    ncodpaciente     INT(10)    NOT NULL AUTO_INCREMENT,
    crefpaciente     CHAR(100)         NOT NULL,
    ncodpersona      DECIMAL(10, 0),
    ncodseguro       DECIMAL(10, 0),
    ncodmembresia    DECIMAL(10, 0),
    PRIMARY KEY (ncodpaciente)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrSEGURO 
--

CREATE TABLE TrSEGURO(
    ncodseguro         INT(10)    NOT NULL AUTO_INCREMENT,
    ndeducible         DECIMAL(10, 0),
    ncodtarifa         DECIMAL(10, 0),
    ncodaseguradora    DECIMAL(10, 0),
    PRIMARY KEY (ncodseguro)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrSERVICIO 
--

CREATE TABLE TrSERVICIO(
    ncodservicio      INT(10)    NOT NULL AUTO_INCREMENT,
    ncodigocita       DECIMAL(10, 0)    NOT NULL,
    ncodsucursal      DECIMAL(10, 0)    NOT NULL,
    ncodtipo          DECIMAL(10, 0)    NOT NULL,
    ncodpaciente      DECIMAL(10, 0)    NOT NULL,
    dfechaservicio    DATE,
    ncodfactura       DECIMAL(10, 0)    NOT NULL,
    ncodempleado      DECIMAL(10, 0),
    PRIMARY KEY (ncodservicio, ncodigocita, ncodsucursal, ncodtipo, ncodpaciente)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrTELEFONO 
--

CREATE TABLE TrTELEFONO(
    ncodtelefono    INT(10)    NOT NULL AUTO_INCREMENT,
    ctelefono       CHAR(10)          NOT NULL,
    ncodpersona     DECIMAL(10, 0),
    PRIMARY KEY (ncodtelefono)
)ENGINE=MYISAM
;



-- 
-- TABLE: TrUSUARIO 
--

CREATE TABLE TrUSUARIO(
    ncodusuario         INT(10)    NOT NULL AUTO_INCREMENT,
    cnombreusuario      CHAR(100)         NOT NULL,
    ctipousuario        CHAR(10)          NOT NULL,
    cpasswordusuario    CHAR(100)         NOT NULL,
    ncodempleado        DECIMAL(10, 0),
    PRIMARY KEY (ncodusuario)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaDEUDA 
--

ALTER TABLE MaDEUDA ADD CONSTRAINT RefMaFACTURA30 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;


-- 
-- TABLE: MaETIQUETA 
--

ALTER TABLE MaETIQUETA ADD CONSTRAINT RefMaMUESTRA36 
    FOREIGN KEY (ncodmuestra)
    REFERENCES MaMUESTRA(ncodmuestra)
;


-- 
-- TABLE: MaFACTURA 
--

ALTER TABLE MaFACTURA ADD CONSTRAINT RefTrPACIENTE33 
    FOREIGN KEY (ncodpaciente)
    REFERENCES TrPACIENTE(ncodpaciente)
;


-- 
-- TABLE: MaTIPOEXAMEN 
--

ALTER TABLE MaTIPOEXAMEN ADD CONSTRAINT RefMaMUESTRA35 
    FOREIGN KEY (ncodmuestra)
    REFERENCES MaMUESTRA(ncodmuestra)
;


-- 
-- TABLE: TrANALISIS 
--

ALTER TABLE TrANALISIS ADD CONSTRAINT RefTrSERVICIO34 
    FOREIGN KEY (ncodservicio, ncodigocita, ncodsucursal, ncodtipo, ncodpaciente)
    REFERENCES TrSERVICIO(ncodservicio, ncodigocita, ncodsucursal, ncodtipo, ncodpaciente)
;

ALTER TABLE TrANALISIS ADD CONSTRAINT RefMaETIQUETA37 
    FOREIGN KEY (ncodetiqueta)
    REFERENCES MaETIQUETA(ncodetiqueta)
;


-- 
-- TABLE: TrBITACORA 
--

ALTER TABLE TrBITACORA ADD CONSTRAINT RefTrUSUARIO23 
    FOREIGN KEY (ncodusuario)
    REFERENCES TrUSUARIO(ncodusuario)
;


-- 
-- TABLE: TrCITA 
--

ALTER TABLE TrCITA ADD CONSTRAINT RefMaSUCURSAL15 
    FOREIGN KEY (ncodsucursal)
    REFERENCES MaSUCURSAL(ncodsucursal)
;

ALTER TABLE TrCITA ADD CONSTRAINT RefTrPACIENTE21 
    FOREIGN KEY (ncodpaciente)
    REFERENCES TrPACIENTE(ncodpaciente)
;


-- 
-- TABLE: TrDIRECCION 
--

ALTER TABLE TrDIRECCION ADD CONSTRAINT RefMaPERSONA46 
    FOREIGN KEY (ncodpersona)
    REFERENCES MaPERSONA(ncodpersona)
;


-- 
-- TABLE: TrEMAIL 
--

ALTER TABLE TrEMAIL ADD CONSTRAINT RefMaPERSONA45 
    FOREIGN KEY (ncodpersona)
    REFERENCES MaPERSONA(ncodpersona)
;


-- 
-- TABLE: TrEMPLEADO 
--

ALTER TABLE TrEMPLEADO ADD CONSTRAINT RefMaPERSONA10 
    FOREIGN KEY (ncodpersona)
    REFERENCES MaPERSONA(ncodpersona)
;

ALTER TABLE TrEMPLEADO ADD CONSTRAINT RefMaPUESTO38 
    FOREIGN KEY (ncodpuesto)
    REFERENCES MaPUESTO(ncodpuesto)
;


-- 
-- TABLE: TrPACIENTE 
--

ALTER TABLE TrPACIENTE ADD CONSTRAINT RefMaPERSONA9 
    FOREIGN KEY (ncodpersona)
    REFERENCES MaPERSONA(ncodpersona)
;

ALTER TABLE TrPACIENTE ADD CONSTRAINT RefTrSEGURO29 
    FOREIGN KEY (ncodseguro)
    REFERENCES TrSEGURO(ncodseguro)
;

ALTER TABLE TrPACIENTE ADD CONSTRAINT RefMaMEMBRESIA32 
    FOREIGN KEY (ncodmembresia)
    REFERENCES MaMEMBRESIA(ncodmembresia)
;


-- 
-- TABLE: TrSEGURO 
--

ALTER TABLE TrSEGURO ADD CONSTRAINT RefMaTARIFASEGURO26 
    FOREIGN KEY (ncodtarifa)
    REFERENCES MaTARIFASEGURO(ncodtarifa)
;

ALTER TABLE TrSEGURO ADD CONSTRAINT RefMaASEGURADORA28 
    FOREIGN KEY (ncodaseguradora)
    REFERENCES MaASEGURADORA(ncodaseguradora)
;


-- 
-- TABLE: TrSERVICIO 
--

ALTER TABLE TrSERVICIO ADD CONSTRAINT RefMaFACTURA3 
    FOREIGN KEY (ncodfactura)
    REFERENCES MaFACTURA(ncodfactura)
;

ALTER TABLE TrSERVICIO ADD CONSTRAINT RefTrCITA16 
    FOREIGN KEY (ncodigocita, ncodsucursal, ncodpaciente)
    REFERENCES TrCITA(ncodigocita, ncodsucursal, ncodpaciente)
;

ALTER TABLE TrSERVICIO ADD CONSTRAINT RefMaTIPOEXAMEN20 
    FOREIGN KEY (ncodtipo)
    REFERENCES MaTIPOEXAMEN(ncodtipo)
;

ALTER TABLE TrSERVICIO ADD CONSTRAINT RefTrEMPLEADO39 
    FOREIGN KEY (ncodempleado)
    REFERENCES TrEMPLEADO(ncodempleado)
;


-- 
-- TABLE: TrTELEFONO 
--

ALTER TABLE TrTELEFONO ADD CONSTRAINT RefMaPERSONA44 
    FOREIGN KEY (ncodpersona)
    REFERENCES MaPERSONA(ncodpersona)
;


-- 
-- TABLE: TrUSUARIO 
--

ALTER TABLE TrUSUARIO ADD CONSTRAINT RefTrEMPLEADO7 
    FOREIGN KEY (ncodempleado)
    REFERENCES TrEMPLEADO(ncodempleado)
;


