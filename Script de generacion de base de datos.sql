------------------------------------------------CREAR BASE DE DATOS---------------------------------------------------------
CREATE DATABASE Portafolio_db
go
USE Portafolio_db
go
 
------------------------------------------------TABLA SEMESTRE---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_Semestre'))
 
CREATE TABLE Tbl_Semestre
( 
    Codigo_Semestre int IDENTITY(1,1) NOT NULL ,
    Nombre_Semestre varchar(20) unique NOT NULL ,
    Anio_Semestre int NOT NULL ,
    Estado_Semestre bit NOT NULL,
    PRIMARY KEY (Codigo_Semestre)
)
go
 
-------------------------------------------------TABLA PLAN DE ESTUDIO---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_PlanEstudio'))
 
CREATE TABLE Tbl_PlanEstudio
(
    Codigo_PlanEstudio int IDENTITY(1,1) NOT NULL ,
    Codigo_Semestre int NOT NULL ,
    Nombre_PlanEstudio varchar(200) NOT NULL ,
    FechaInicio_PlanEstudio date NOT NULL,
    FechaFin_PlanEstudio date NOT NULL,
    TotalCursosObligatorios_PlanEstudio int NULL ,
    TotalCursosElectivos_PlanEstudio int NULL ,
    TotalCreditosObligatorios_PlanEstudio int NULL ,
    TotalCreditosElectivos_PlanEstudio int NULL ,
    TotalCreditosExtracurriculares_PlanEstudio int NULL ,
    TotalCreditosPracticas_PlanEstudio int NULL ,
    Estado_PlanEstudio bit NOT NULL,
    PRIMARY KEY (Codigo_PlanEstudio),
    FOREIGN KEY(Codigo_Semestre) REFERENCES Tbl_Semestre
)
 
-------------------------------------------------TABLA DETALLE PLAN DE ESTUDIO---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_DetallePlanEstudio'))
 
CREATE TABLE Tbl_DetallePlanEstudio
(
    Codigo_DetallePlanEstudio int IDENTITY(1,1) NOT NULL ,
    Codigo_PlanEstudio int NOT NULL ,
    CodigoCurso_DetallePlanEstudio varchar(20) NOT NULL,
    Asignatura_DetallePlanEstudio varchar(150) NOT NULL ,
    HorasTeoricas_DetallePlanEstudio int NOT NULL,
    HorasPracticas_DetallePlanEstudio int NOT NULL,
    TotalHoras_DetallePlanEstudio int NOT NULL,
    TotalCreditos_DetallePlanEstudio int NOT NULL,
    PreRequisito_DetallePlanEstudio varchar(150) NOT NULL ,
    Ciclo_DetallePlanEstudio varchar(10) NOT NULL ,
    TipoCurso_DetallePlanEstudio varchar(20) NOT NULL ,
    Estado_DetallePlanEstudio bit NOT NULL,
    PRIMARY KEY (Codigo_DetallePlanEstudio),
    FOREIGN KEY(Codigo_PlanEstudio) REFERENCES Tbl_PlanEstudio
)
 
 
-------------------------------------------------TABLA CARGA ACADEMICA---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_CargaAcademica'))
 
CREATE TABLE Tbl_CargaAcademica
( 
    Codigo_CargaAcademica int IDENTITY(1,1) NOT NULL ,
    Codigo_Semestre int NOT NULL,
    Nombre_CargaAcademica varchar(50) NOT NULL,
    FechaInicio_CargaAcademica date NOT NULL,
    FechaFin_CargaAcademica date NOT NULL,
    Estado_CargaAcademica bit NOT NULL,
    PRIMARY KEY (Codigo_CargaAcademica),
    FOREIGN KEY(Codigo_Semestre) REFERENCES Tbl_Semestre
)
go
 
-------------------------------------------------TABLA SECCION---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_Seccion'))
 
CREATE TABLE Tbl_Seccion
( 
    Codigo_Seccion int IDENTITY(1,1) NOT NULL ,
    Nombre_Seccion varchar(10) NOT NULL ,
    Estado_Seccion bit NOT NULL,
    PRIMARY KEY (Codigo_Seccion)
)
go
 
-------------------------------------------------TABLA CARGO DOCENTE---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_CargoDocente'))
 
CREATE TABLE Tbl_CargoDocente
( 
    Codigo_CargoDocente int IDENTITY(1,1) NOT NULL ,
    Nombre_CargoDocente varchar(30) NOT NULL ,
    Estado_CargoDocente bit NOT NULL,
    PRIMARY KEY (Codigo_CargoDocente)
)
go
 
-------------------------------------------------TABLA PROFESION---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_Profesion'))
 
CREATE TABLE Tbl_Profesion
( 
    Codigo_Profesion int IDENTITY(1,1) NOT NULL ,
    Nombre_Profesion varchar(100) NOT NULL ,
    Abrebiatura_Profesion varchar(10) NOT NULL ,
    Estado_Profesion bit NOT NULL,
    PRIMARY KEY (Codigo_Profesion)
)
go
 
 
-------------------------------------------------TABLA DOCENTE---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_Docente'))
 
CREATE TABLE Tbl_Docente
(
    Codigo_Docente int IDENTITY(1,1) NOT NULL ,
    Codigo_Docenteepis varchar(6) unique NOT NULL ,
    Codigo_CargoDocente int NOT NULL,
    Codigo_Profesion int NOT NULL,
    DNI_Docente varchar(8) NOT NULL,
    Nombres_Docente varchar(100) NOT NULL ,
    Apellidos_Docente varchar(100) NOT NULL ,
    Sexo_Docente bit NOT NULL ,
    EstadoCivil_Docente  varchar(30) NULL ,
    FechaNac_Docente date NOT NULL ,
    DireccionActual_Docente varchar(200) NOT NULL ,
    DireccionReferencia_Docente varchar(200) NULL ,
    Correo_Docente varchar(100) NOT NULL ,
    TelefonoFijo_Docente varchar(9) NULL ,
    TelefonoCelular_Docente varchar(9)  NOT NULL ,
    Foto_Docente varchar(250) NULL ,
    Estado_Docente bit NOT NULL ,
    PRIMARY KEY (Codigo_Docente),
    FOREIGN KEY(Codigo_CargoDocente) REFERENCES Tbl_CargoDocente,
    FOREIGN KEY(Codigo_Profesion) REFERENCES Tbl_Profesion
)
go
 
 
-------------------------------------------------TABLA DETALLE CARGA ACADEMICA---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_DetalleCargaAcademica'))
 
CREATE TABLE Tbl_DetalleCargaAcademica
( 
    Codigo_DetalleCargaAcademica int IDENTITY(1,1) NOT NULL ,
    Codigo_PlanEstudio int NOT NULL,
    Codigo_CargaAcademica int NOT NULL,
    Codigo_Docente int NOT NULL,
    Codigo_Seccion int NOT NULL,
    Codigo_DetallePlanEstudio int NOT NULL,
    Codigo_Semestre int NOT NULL,
    Matriculados_DetalleCargaAcademica int NOT NULL,
	URL_DetalleCargaAcademica varchar(250) NULL,
    Estado_DetalleCargaAcademica bit NOT NULL,
    PRIMARY KEY (Codigo_DetalleCargaAcademica),
    FOREIGN KEY(Codigo_PlanEstudio) REFERENCES Tbl_PlanEstudio,
    FOREIGN KEY(Codigo_CargaAcademica) REFERENCES Tbl_CargaAcademica,
    FOREIGN KEY(Codigo_Docente) REFERENCES Tbl_Docente,
    FOREIGN KEY(Codigo_Seccion) REFERENCES Tbl_Seccion,
    FOREIGN KEY(Codigo_DetallePlanEstudio) REFERENCES Tbl_DetallePlanEstudio,
    FOREIGN KEY(Codigo_Semestre) REFERENCES Tbl_Semestre
)
go
 
-------------------------------------------------TABLA PRUEBA DE ENTRADA---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_PruebaEntrada'))
 
CREATE TABLE Tbl_PruebaEntrada
( 
    Codigo_PruebaEntrada int IDENTITY(1,1) NOT NULL ,
    Codigo_DetalleCargaAcademica int NOT NULL,
    Evaluados_PruebaEntrada int NOT NULL,    
    Fecha_PruebaEntrada date NOT NULL,
    Estado_PruebaEntrada char(1) NOT NULL,
    
    PRIMARY KEY (Codigo_PruebaEntrada),
    FOREIGN KEY(Codigo_DetalleCargaAcademica) REFERENCES Tbl_DetalleCargaAcademica,
)
go
 
 
-------------------------------------------------TABLA MEDIDAS CORRECTIVAS---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_MedidasCorrectivas'))
 
CREATE TABLE Tbl_MedidasCorrectivas
( 
    Codigo_MedidasCorrectivas int IDENTITY(1,1) NOT NULL ,
    Codigo_PruebaEntrada int NOT NULL ,
    Medida1_MedidasCorrectivas bit NULL,
    Medida2_MedidasCorrectivas bit NULL,
    Medida3_MedidasCorrectivas bit NULL,
    Medida4_MedidasCorrectivas bit NULL,
    Medida5_MedidasCorrectivas bit NULL,
    Medida6_MedidasCorrectivas bit NULL,
    Medida7_MedidasCorrectivas varchar(250) NULL,
    
    PRIMARY KEY (Codigo_MedidasCorrectivas),
    FOREIGN KEY(Codigo_PruebaEntrada) REFERENCES Tbl_PruebaEntrada
)
go
 
-------------------------------------------------TABLA CONOCIMIENTO HABILIDAD---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_ConocimientoHabilidad'))
 
CREATE TABLE Tbl_ConocimientoHabilidad
( 
    Codigo_ConocimientoHabilidad int IDENTITY(1,1) NOT NULL ,
    Codigo_PruebaEntrada int NOT NULL ,
    Nombre_ConocimientoHabilidad varchar(250) NOT NULL ,
    Deficiente_ConocimientoHabilidad int NOT NULL ,
    Suficiente_ConocimientoHabilidad int NOT NULL ,
    Bueno_ConocimientoHabilidad int NOT NULL ,
    PRIMARY KEY (Codigo_ConocimientoHabilidad),
    FOREIGN KEY(Codigo_PruebaEntrada) REFERENCES Tbl_PruebaEntrada
)
go
-------------------------------------------------TABLA PORTAFOLIO---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_Portafolio'))
 
CREATE TABLE Tbl_Portafolio
(
    Codigo_Portafolio int IDENTITY(1,1) NOT NULL ,
    Codigo_DetalleCargaAcademica int NOT NULL,
    Unidad_Portafolio varchar(5) NULL,
    Retirados_Portafolio int NULL,
    Abandono_Portafolio int NULL,
    Aprobados_Portafolio int NULL,
    Fecha_Portafolio date  NULL,
    Estado_Portafolio char(1)  NULL,
    
    PRIMARY KEY (Codigo_Portafolio),
    FOREIGN KEY(Codigo_DetalleCargaAcademica) REFERENCES Tbl_DetalleCargaAcademica,
)
go
 
 
-------------------------------------------------TABLA MATERIAL---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_Material'))
 
CREATE TABLE Tbl_Material
(
    Codigo_Material int IDENTITY(1,1) NOT NULL,
    Codigo_Portafolio int NOT NULL,
    Tipo_Material varchar(21) NULL,  -- aqui ira el tipo "DOCENTE" o "ESTUDIANTE"
    Nombre_Material varchar(250) NULL,
    Estado_Material varchar(21)  NULL, --- Aqui es un combobox con tres campos DIGITAL,IMPRESO o AMBOS
    Cantidad_Material int  NULL,
    Archivo_Material varchar(250) NULL,
    TipoArchivo_Material varchar(10) NULL,
    PesoArchivo_Material varchar (50) NULL,
    Descripcion_Material varchar(250) NULL,
	UrlOnline_Material varchar(250) NULL,
    PRIMARY KEY (Codigo_Material),
    FOREIGN KEY(Codigo_Portafolio) REFERENCES Tbl_Portafolio
)
go
 
-------------------------------------------------INFORME FINAL---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_InformeFinal'))
 
CREATE TABLE Tbl_InformeFinal
(
	Codigo_InformeFinal int IDENTITY(1,1) NOT NULL ,
    Codigo_DetalleCargaAcademica int NOT NULL,
	PorcentajeSilabo_InformeFinal int NULL,
	PracticasCalificadas_InformeFinal int NULL,
	LaboratoriosRealizados_InformeFinal int NULL,
	TrabajosRealizados_InformeFinal int NULL,
	---numero de matriculados sale de codigo Detalle carga academica
	---Codigo_Portafolio int NOT NULL, no sirve
	---asisten se calcula automaticamnete
	EstudiantesMatriculados_InformeFinal int NULL,
	EstudiantesRetiro_InformeFinal int NULL,
	EstudiantesAbandono_InformeFinal int NULL,
	EstudiantesAsisten_InformeFinal int null,
	EstudiantesAprobados_InformeFinal int null,
	EstudiantesDesaprobados_InformeFinal int NULL,
	NotaAlta_InformeFinal int NULL,
	NotaPromedio_InformeFinal int NULL,
	NotaBaja_InformeFinal int NULL,
    Fecha_InformeFinal date  NULL,
    Estado_InformeFinal char(1)  NULL,
    PRIMARY KEY (Codigo_InformeFinal),
    FOREIGN KEY(Codigo_DetalleCargaAcademica) REFERENCES Tbl_DetalleCargaAcademica,
	
)
go

-------------------------------------------------TABLA CAPACIDAD DEL CURSO---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_CapacidadesCurso'))
 
CREATE TABLE Tbl_CapacidadesCurso
( 
    Codigo_CapacidadesCurso int IDENTITY(1,1) NOT NULL ,
    Codigo_InformeFinal int NOT NULL ,
	Descripcion_CapacidadesCurso varchar(250) NULL,
    Nada_CapacidadesCurso int NULL,
    Poco_CapacidadesCurso int NULL,
    Aceptable_CapacidadesCurso int NULL,
    Bien_CapacidadesCurso int NULL,
    MuyBien_CapacidadesCurso int NULL,    
   
    
    PRIMARY KEY (Codigo_CapacidadesCurso),
    FOREIGN KEY(Codigo_InformeFinal) REFERENCES Tbl_InformeFinal
)
go

-------------------------------------------------TABLA Motivo capacidad curso---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_Motivo'))
 
CREATE TABLE Tbl_Motivo
( 
    Codigo_Motivo int IDENTITY(1,1) NOT NULL ,
    Codigo_InformeFinal int NOT NULL ,
	Descripcion_Motivo varchar(250) NULL,    
    PRIMARY KEY (Codigo_Motivo),
    FOREIGN KEY(Codigo_InformeFinal) REFERENCES Tbl_InformeFinal
)
go

-------------------------------------------------TABLA OBSERVACIONES---------------------------------------------------------
if (not exists(select 1 from sys.tables
where name='Tbl_Observaciones'))
 
CREATE TABLE Tbl_Observaciones
( 
    Codigo_Observaciones int IDENTITY(1,1) NOT NULL ,
    Codigo_InformeFinal int NOT NULL ,
	Estudiantes_Observaciones varchar(250) NULL,
	AsistenciaPuntualidad_Observaciones varchar(250) NULL,
	Silabo_Observaciones varchar(250) NULL,
	MaterialCurso_Observaciones bit NULL,
	Cuestionarios_Observaciones bit NULL,
	TareasEncargadas_Observaciones bit NULL,
	Foros_Observaciones bit NULL,
	ExamenesVirtuales_Observaciones bit NULL,
	Slideshow_Observaciones bit NULL,
	Administrativas_Observaciones varchar(250) NULL,
	SilaboCompetencias_Observaciones varchar(250)NULL,
	MejoraContinua_Observaciones varchar(250)NULL,
	ActualizacionDocente_Observaciones varchar(250)Null,
	ComentariosRecomendaciones_Observaciones varchar(250) NULL,
    PRIMARY KEY (Codigo_Observaciones),
    FOREIGN KEY(Codigo_InformeFinal) REFERENCES Tbl_InformeFinal
)
go

-------------------------------------------------TABLA USUARIO---------------------------------------------------------

if (not exists(select 1 from sys.tables
where name='Tbl_Usuario'))
 
CREATE TABLE Tbl_Usuario
( 
	 Codigo_Usuario int IDENTITY(1,1) NOT NULL ,
	 Codigo_Docente int Not NULL, ---Con este ID se obtiene tambien cargo docente 
	 Nombre_Usuario varchar(100) NULL,
	 Password_Usuario varchar(100) NULL,
	 FechaCreacion_Usuario date NULL,
	 FechaActualizacion_Usuario date NULL,
	 Estado_Usuario bit NULL,
	 PRIMARY KEY (Codigo_Usuario),
	 FOREIGN KEY(Codigo_Docente) REFERENCES Tbl_Docente
)
go


--TRUNCATE TABLE Tbl_Docente
--go 
--TRUNCATE TABLE Tbl_Docente
--go
 
