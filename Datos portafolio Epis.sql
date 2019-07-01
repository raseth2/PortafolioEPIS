use Portafolio_db
go

------------------- Tbl Semestre ----------------------
INSERT INTO Tbl_Semestre values('2016-I','2016','False')
INSERT INTO Tbl_Semestre values('2016-II','2016','False')
INSERT INTO Tbl_Semestre values('2017-I','2017','False')
INSERT INTO Tbl_Semestre values('2017-II','2017','False')
INSERT INTO Tbl_Semestre values('2018-I','2018','False')
INSERT INTO Tbl_Semestre values('2018-II','2018','False')
INSERT INTO Tbl_Semestre values('2019-REC','2019','False')
INSERT INTO Tbl_Semestre values('2019-I','2019','True')
 
-------------------Seccion--------------------
INSERT INTO Tbl_Seccion values('A','True')
INSERT INTO Tbl_Seccion values('B','True')
INSERT INTO Tbl_Seccion values('C','False')
 
-------------------Cargo Docente--------------------
INSERT INTO Tbl_CargoDocente values('Director','True')
INSERT INTO Tbl_CargoDocente values('Administrativo','True')
INSERT INTO Tbl_CargoDocente values('Docente','True')
 
------------------- Tbl Profesion ----------------------
INSERT INTO Tbl_Profesion values('Ingeniero','Ing.','True')
INSERT INTO Tbl_Profesion values('Magister','Mag.','True')
INSERT INTO Tbl_Profesion values('Contador Público','C.P.','True')
INSERT INTO Tbl_Profesion values('Arquitecto','Arq.','True')
INSERT INTO Tbl_Profesion values('Abogado','Abg.','True')
INSERT INTO Tbl_Profesion values('Licenciado','Lcdo.','True')
INSERT INTO Tbl_Profesion values('Profesor','Prof.','True')
INSERT INTO Tbl_Profesion values('Licenciado en administración de empresas','LAE','True')
INSERT INTO Tbl_Profesion values('Psicólogo','Psic.','True')
 
-----------------Plan Estudio-----------------
INSERT INTO Tbl_PlanEstudio values(1,'Plan de Estudio 2016-I','2016-03-01','2019-12-30',57,9,211,9,2,3,'True')
 
-------------------Detalle plan de Estudio--------------------
-------------------Ciclo I------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-101','MATEMATICA I',4,2,6,5,'Ninguno','I','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-102','MATEMATICA BASICA I',4,2,6,5,'Ninguno','I','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-103','DISEÑO EN INGENIERIA',2,4,6,4,'Ninguno','I','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-104','COMUNICACIÓN ORAL Y ESCRITA',2,2,4,3,'Ninguno','I','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-105','METODOLOGIA DEL TRABAJO UNIVERSITARIO',2,2,4,3,'Ninguno','I','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-171','INTRODUCCION A LA INGENIERIA DE SISTEMAS',2,0,2,2,'Ninguno','I','Obligatorio','True')
 
-------------------Ciclo II------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-201','MATEMATICA II',4,2,6,5,'ING-101','II','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-202','FSICA I',4,2,6,5,'Min 14 Créditos','II','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-203','TECNICAS PROGRAMACION ',2,4,6,4,'Ninguno','II','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-204','ECONOMIA I',1,2,3,2,'Min 12 Créditos','II','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-205','ESTADISTICA I',2,2,4,3,'Min 12 Créditos','II','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'ING-206','QUIMICA I',3,2,5,4,'Ninguno','II','Obligatorio','True')
-------------------Ciclo III------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-371','MATEMATICA DISCRETA',2,4,6,4,'ING-201','III','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-372','SISTEMAS ELECTRONICOS DIGITALES',2,4,6,4,'ING-202','III','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-373','ALGORITMOS Y ESTRUCTURA DE DATOS',2,4,6,4,'ING-203','III','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-374','DISEÑO Y MODELAMIENTO VIRTUAL',2,2,4,3,'ING-103','III','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-375','MODELO DE PROCESOS DE NEGOCIOS',2,4,6,4,'Min 36 Creditos','III','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-376','SISTEMAS DE INFORMACION',2,2,4,3,'Min 36 Creditos','III','Obligatorio','True')
 
-------------------Ciclo IV------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-471','INTRODUCCION AL DESARROLLO WEB',2,2,4,3,'Min 60 Créditos','IV','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-472','ARQUITECTURA DEL COMPUTADOR',2,4,6,4,'SI-372','IV','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-473','PROGRAMACION I',2,4,6,4,'SI-373','IV','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-474','INGENIERIA ECONOMICA Y FINANCIERA',2,2,4,3,'SI-371','IV','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-475','INGENIERIA DE REQUERIMIENTOS',2,4,6,4,'SI-375','IV','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-476','PROGRAMACION ORIENTADA A OBJETOS',2,4,6,4,'Min 60 Créditos','IV','Obligatorio','True')
 
-------------------Ciclo V------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-571','DISEÑO DE BASE DE DATOS',2,4,6,4,'SI-475','V','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-572','SISTEMAS OPERATIVOS I',2,4,6,4,'SI-472','V','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-573','PROGRAMACION II',2,4,6,4,'SI-473','V','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-574','INVESTIGACION DE OPERACIONES',2,2,4,3,'SI-474','V','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-575','DISEÑO Y ARQUITECTURA DE SOFTWARE',2,4,6,4,'SI-475','V','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-576','INTERACCION Y DISEÑO DE INTERFACES',2,2,4,3,'Min 80 Creditos','V','Obligatorio','True')
-------------------Ciclo VI------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-671','BASE DE DATOS I',2,4,6,4,'SI-571','VI','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-672','SISTEMAS OPERATIVOS II',2,4,6,4,'SI-572','VI','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-673','PROGRAMACION III ',2,4,6,4,'SI-573','VI','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-674','DESARROLLO DE APLICACIONES WEB I',2,4,6,4,'SI-571','VI','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-675','INGENIERIA DE SOFTWARE',2,2,4,3,'SI-575','VI','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-676','ETICA PROFESIONAL',3,0,3,3,'Min 100 Créditos','VI','Obligatorio','True')
-------------------Ciclo VII------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-771','BASE DE DATOS II',2,4,6,4,'SI-671','VII','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-772','REDES Y COMUNICACIONES DE DATOS I',2,2,4,3,'SI-672','VII','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-773','SOLUCIONES MOVILES I',2,4,6,4,'SI-673','VII','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-774','GESTION DE PROYECTOS DE TI',2,4,6,4,'SI-474','VII','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-775','CALIDAD Y PRUEBAS DE SOFTWARE',2,4,6,4,'Min 120 Creditos','VII','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-776','MEDIO AMBIENTE Y DESARROLLO SOSTENIBLE ',2,2,4,3,'Min 120 Creditos','VII','Electivo','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-777','CONTABILIDAD GENERAL',2,2,4,3,'Min 120 Creditos','VII','Electivo','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-778','PATRONES DE SOFTWARE',2,2,4,3,'SI-575','VII','Electivo','True')
 
-------------------Ciclo VIII------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-871','INTELIGENCIA DE NEGOCIOS',2,4,6,4,'SI-771','VIII','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-872','REDES Y COMUNICACIONES DE DATOS II',2,4,6,4,'SI-772','VIII','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-873','INGLES TECNICO',2,4,6,4,'(*)','VIII','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-874','DESARROLLO DE APLICACIONES WEB II',2,4,6,4,'SI-674','VIII','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-875','SEGURIDAD INFORMATICA',2,4,6,4,'Min 140 Créditos','VIII','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-876','DERECHO INFORMATICO',2,2,4,3,'Min 140 Créditos','VIII','Electivo','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-877','DISEÑO Y CREACION DE VIDEOJUEGOS',2,2,4,3,'SI-673','VIII','Electivo','True')
-------------------Ciclo IX------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-971','AUDITORIA DE SISTEMAS',2,4,4,3,'SI-875','IX','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-972','REDES Y COMUNICACIONES DE DATOS III',2,4,6,4,'SI-872','IX','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-973','METODOLOGÍA DE LA INVESTIGACIÓN APLICADA ',2,2,4,3,'SI-873','IX','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-974','CONSTRUCCION DE SOFTWARE I ',2,4,6,4,'SI-774','IX','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-975','PLANEAMIENTO ESTRATEGICO DE TI',3,2,5,4,'Min 180 Creditos','IX','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-976','GESTION DE LA CONFIGURACION Y ADMINISTRACION DE SOFTWARE',2,2,4,3,'SI-775','IX','Obligatorio','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-977','NEGOCIOS Y MARKETING POR INTERNET',2,2,4,3,'Min 180 Creditos','IX','Electivo','True')
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-978','TOPICOS DE BASE DE DATOS AVANZADOS',2,2,4,3,'SI-871','IX','Electivo','True')
-------------------Ciclo X------------------------------------
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-071','TALLER DE LIDERAZGO Y EMPRENDIMIENTO',2,2,4,3,'Min 180 Créditos','X','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-072','TALLER DE REDES Y COMUNICACIÓN DE DATOS',2,4,6,4,'SI-972','X','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-073','PROYECTO DE TESIS',2,4,6,4,'SI-973','X','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-074','CONSTRUCCION DE SOFTWARE II',2,4,6,4,'SI-974','X','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-075','GERENCIA DE TI',2,2,4,3,'SI-975','X','Obligatorio','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-076','SISTEMAS DE INFORMACION DE BANCA Y FINANZAS',2,2,4,3,'Min 180 Créditos','X','Electivo','True') 
INSERT INTO Tbl_DetallePlanEstudio values(1,'SI-077','SOLUCIONES MOVILES II',2,2,4,3,'SI-773','X','Electivo','True')
------------------- Tbl Docente ------------------------
 
------Primer ciclo docentes-----------
INSERT INTO Tbl_Docente values('201900',3,1,'78451285','Silvia Marlene','Centella Vildoso','False','Casado','12/08/84','Calle Apurimac 145 S/N','Colegio Justo Arias','silviacentella@gmail.com','052457812','952647845','docente1.jpg','True')
INSERT INTO Tbl_Docente values('201901',3,1,'78485896','Felipe Remigio','Atencio Maquera','True','Casado','02/09/70','Calle Alto Lima 1010','Calle Alto Lima','fatencio@gmail.com','052586945','952893719','docente2.jpg','True')
INSERT INTO Tbl_Docente values('201902',3,1,'00256235','Nelida Brigida','Maquera Cardenas','False','Casado','10/02/81','Av. Bolognesi','Calle paseo de las aguas','nmaquera@gmail.com','052869563','952037891','docente3.jpg','True')
INSERT INTO Tbl_Docente values('201903',3,1,'00256211','Claudia Susy','Alvarez Sanchez','False','Casado','10/08/79','Av. San Martin','Calle San Martin','csusy@gmail.com','052869550','952037888','docente4.jpg','True')
INSERT INTO Tbl_Docente values('201904',3,1,'79556222','Lourdes Vanessa','Revollar Vildoso','False','Casado','01/09/80','Av. Jorge Basadre','Cerca al Restaurant la  glorieta','lrevollar@gmail.com','052108692','952647845','docente32.jpg','True')
 
INSERT INTO Tbl_Docente values('201905',3,6,'23568596','Americo','Alca Gomez','True','Casado','22/05/65','Calle Uruguay 475','Cerca a Ferrteria Peru','agomez@gmail.com','052758489','955692335','docente5.jpg','True')
INSERT INTO Tbl_Docente values('201906',3,9,'58964785','Mariella Carmen','Berrios Flores','False','Casado','15/03/78','Calle Siempre viva','Cerca al Hotel Peschay','mberridos@gmail.com','052424578','952457630','docente6.jpg','True')
INSERT INTO Tbl_Docente values('201907',3,9,'02314566','Yanira','Valdivia Tapia','False','Casado','22/11/80','Av. Tarata 558','Cerca al grifo Caplina','yvaldivia@gmail.com','052124578','952025865','docente7.jpg','True')
INSERT INTO Tbl_Docente values('201908',3,1,'25647895','Oliver','Santana Carbajal','True','Casado','10/03/75','Urb. Santa Ana 85','Cerca al grifo Pecsa','osantana@gmail.com','052124578','988688563','docente8.jpg','True')
-------Segundo Ciclo---------
INSERT INTO Tbl_Docente values('201909',3,1,'20314698','Nestor Andres','Sanjinez Ticona','True','Casado','19/04/83','Calle los Olivos 788','Cerca al restarurante Turistico Sin fronteras','nsanjinez@gmail.com','052369875','952555555','docente9.jpg','True')
INSERT INTO Tbl_Docente values('201910',2,1,'45696789','Liliana Mercedes','Vega Bernal','False','Casado','14/05/75','Calle los Escritores','Diario Correo','lvega@gmail.com','052457585','952238695','docente10.jpg','True')
INSERT INTO Tbl_Docente values('201911',2,1,'12547866','Elard Ricardo','Rodriguez Marca','True','Casado','15/04/72','Calle los pintores 78','Palza principal de cono sur','elardroma@gmail.com','052120363','952917630','docente11.jpg','True')
INSERT INTO Tbl_Docente values('201912',3,1,'28963111','Maritza Marleni',' Catari Cutipa','False','Casado','18/06/78','Jiron La molina 788','Mercado Grau','mcatari@gmail.com','052129635','952089716','docente12.jpg','True')
 
 
 
------- Tercer Ciclo ----------------
INSERT INTO Tbl_Docente values('201914',3,1,'78885566','Alex Juan','Yanqui Constancio','True','Casado','25/12/75','Urbanizacion centenario 2do piso 555','Cerca al arco parabolico','ayanqui@gmail.com','052128594','952097855','docente14.jpg','True')
INSERT INTO Tbl_Docente values('201915',3,1,'00558866','Milagros Gleny ','Cohaila Gonzales','False','Casado','30/05/84','Calle los rosales 45','Cerca al restaurante Sabores Marinos','mcoahila@gmail.com','052305478','952067593','docente15.jpg','True')
INSERT INTO Tbl_Docente values('201916',3,1,'89657585','Mariella Rosario ','Ibarra Montecinos','False','Casado','10/06/80','Calle Don patricio 785','Cerca al aeropuerto Jorge Chavez','mibarra@gmail.com','052301045','952089746','docente16.jpg','True')
--------Cuarto ciclo-----------------
INSERT INTO Tbl_Docente values('201917',1,1,'78556633','Tito Fernando ','Ale Nieto','True','Casado','26/07/89','Av. Dos de Mayo S/N','Cerca a al museo Peru','titofale@gmail.com','052124578','952097685','docente17.jpg','True')
--------Quinto ciclo-----------------
INSERT INTO Tbl_Docente values('201918',2,1,'65985566','Enrique Felix ','Lanchipa Valencia','True','Casado','10/12/79','Calle los barrancos 78','Cerca a la plaza dos de mayo','elanchipa@gmail.com','052101425','952232323','docente18.jpg','True')
INSERT INTO Tbl_Docente values('201919',3,1,'42758695','Alberto Johnatan ','Flor Rodriguez','True','Casado','12/08/87','Av. El sol S/N','Cerca a la riel del tren ','frodriguez@gmail.com','052104262','952252928','docente19.jpg','True')
--------Sexto Ciclo-------------------
INSERT INTO Tbl_Docente values('201920',3,1,'10524875','Carlos Alberto ','Ruiz Cancino','True','Casado','20/09/88','Av. el Solar 75','Una cuadra de solari plaza','carlozruiz@gmail.com','052336699','952262728','docente20.jpg','True')
INSERT INTO Tbl_Docente values('201921',3,1,'26598632','Martha Judith ','Paredes Vignola','False','Casado','15/04/70','Calle Tupac Amaru 45','Cerca a la Universidad Nacional','mparedes@gmail.com','052108534','952783912','docente21.jpg','True')
INSERT INTO Tbl_Docente values('201922',3,1,'02178965','Erbert Francisco ','Osco Mamani','True','Casado','26/02/89','Av. Los Molles','Cerca a la Plaza 1era de Mayo','eosco@gmail.com','052102363','952197382','docente22.jpg','True')
--------Setimo Ciclo-----------------
INSERT INTO Tbl_Docente values('201923',3,1,'12758495','Patrick Jose','Cuadros Quiroga','True','Casado','15/02/59','Av.Piura 755','Cerca al restaurante Puro gusto','pcuaros@gmail.com','052967852','952021365','docente23.jpg','True')
INSERT INTO Tbl_Docente values('201924',3,1,'23859476','Hugo Martin','Alcantara Martinez','True','Casado','21/09/75','Av. El Mirador S/N','Cerca al Restaurante Lomazo','halcantara@gmail.com','052037598','952453695','docente24.jpg','True')
INSERT INTO Tbl_Docente values('201925',3,1,'00775588','Rafael Humberto','Poma Laura','True','Casado','24/08/75','Calle Heroes del Pacifico','Cerca al Parque Peru','rpoma@gmail.com','052109875','952647845','docente25.jpg','True')
--------Octavo ciclo------
INSERT INTO Tbl_Docente values('201926',3,1,'99966554','Ricardo Manuel','Sante Zavaleta','True','Casado','12/11/78','Av. Giron la union 85','Mas abajo de Cochera el Causa','rsante@gmail.com','052036475','952083691','docente26.jpg','True')
INSERT INTO Tbl_Docente values('201927',3,6,'15427036','Hiraida Yesenia','Pacheco Quispe','False','Casado','14/05/69','Av. Bolognesi 554','Una cuadra de la cancha sintetica ','hpacheco@gmail.com','052109875','952026475','docente27.jpg','True')
INSERT INTO Tbl_Docente values('201928',3,1,'18975630','Carlos Alberto','Pajuelo Beltran','True','Casado','22/08/74','Av. Leguia 5522','Cerca al colegio Manuel A Odria','cpajuelo@gmail.com','052037691','952037562','docente28.jpg','True')
---------Noveno Ciclo-----
INSERT INTO Tbl_Docente values('201929',3,1,'09763189','Oscar Juan','Jemenez Flores','True','Casado','06/07/90','Av. los Escritores 5','Cerca a la casa del Tapiz','ojimenez@gmail.com','052108564','952083692','docente29.jpg','True')
INSERT INTO Tbl_Docente values('201930',3,1,'08769317','Luis Alfredo ','Fernandez Vizcarra','True','Casado','14/11/74','Av. Los Conquistadores 85','Una Cuadra del Colegio Peru Vir','lfernandez@gmail.com','052029798','952080808','docente30.jpg','True')
INSERT INTO Tbl_Docente values('201931',3,1,'07853322','Ricardo Manuel','Valcarcel Alvarado','True','Casado','10/12/69','Calle Los Geranios 22','Cerca a la plaza Miguel Grau','rvarcarcel@gmail.com','052124578','952090909','docente31.jpg','True')
 
 
--------Docentes Agregados del 2018 II-----------------
 
--INSERT INTO Tbl_Docente values('201932',3,1,'07853300','Javier','Alca Gomez','True','Casado','10/12/69','Cono sur Miraflores 356','Cerca del Mercado Santa Rosa','jalca@gmail.com','052124586','952098899','docente32.jpg','False')
--INSERT INTO Tbl_Docente values('201933',3,2,'07853300','Grovert','Quino Villanueva','True','Casado','10/12/65','Av. Bolognesi 365','Cerca del Mercado Central','gQuintino@gmail.com','052124511','952098811','docente33.jpg','False')
--INSERT INTO Tbl_Docente values('201934',3,1,'07853300','Henry Wilson','Chaiña Condori','True','Casado','10/12/88','Av. UrbaTacna','Cerca del Mercado Central','HChaina@gmail.com','052124500','952098877','docente34.jpg','False')
--INSERT INTO Tbl_Docente values('201936',3,1,'07853300','Rodolfo Mariano','Alanoca Llanos','True','Casado','10/12/69','Av. Bolognesi','Cerca del Mercado Central','Rmariano@gmail.com','052124599','952098899','docente35.jpg','False')
 
 
 
--------------------------------------Tbl_CargaAcademica-----------------------------------
INSERT INTO Tbl_CargaAcademica Values(1,'Carga Academica 2016-I','2016-03-01','2016-07-10','False')
INSERT INTO Tbl_CargaAcademica Values(2,'Carga Academica 2016-II','2016-08-15','2016-12-14','False')
INSERT INTO Tbl_CargaAcademica Values(3,'Carga Academica 2017-I','2017-03-01','2017-07-10','False')
INSERT INTO Tbl_CargaAcademica Values(4,'Carga Academica 2017-II','2017-08-15','2017-12-14','False')
INSERT INTO Tbl_CargaAcademica Values(5,'Carga Academica 2018-I','2018-03-01','2018-07-10','False')
INSERT INTO Tbl_CargaAcademica Values(6,'Carga Academica 2018-II','2018-08-15','2018-12-14','False')
INSERT INTO Tbl_CargaAcademica Values(7,'Carga Academica 2019-REC','2019-01-07','2019-02-28','False')
INSERT INTO Tbl_CargaAcademica Values(8,'Carga Academica 2019-I','2019-03-01','2019-07-10','True')
 
----------------------------------------Tbl_DetalleCargaAcademica 2019 I-------------------------------------------------------------------------------
 
----------------------------------------Primer Ciclo--------------------------------------------------------------------------------------------
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,1,1,1,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,2,2,1,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,3,1,2,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,1,2,2,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,4,1,3,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,5,2,3,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,6,1,4,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,7,2,4,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,8,1,5,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,7,2,5,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,9,1,6,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,9,2,6,8,'30','','True')
 
----------------------------------------Segundo Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,3,1,7,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,2,1,8,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,10,1,9,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,11,1,10,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,12,1,11,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,13,1,12,8,'30','','True')
 
----------------------------------------Tercer Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,1,1,13,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,14,1,14,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,15,1,15,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,10,1,16,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,16,1,17,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,9,1,18,8,'30','','True')
 
----------------------------------------Cuarto Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,17,1,19,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,14,1,20,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,10,1,21,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,11,1,22,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,16,1,23,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,12,1,24,8,'30','','True')
 
----------------------------------------Quinto Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,9,1,25,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,18,1,26,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,12,1,27,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,15,1,28,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,19,1,29,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,10,1,30,8,'30','','True')
 
 
----------------------------------------Sexto Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,20,1,31,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,12,1,32,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,18,1,33,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,17,1,34,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,21,1,35,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,22,1,36,8,'30','','True')
 
 
----------------------------------------Septimo Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,23,1,37,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,24,1,38,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,19,1,39,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,21,1,40,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,25,1,41,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,22,1,42,8,'30','','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',43,8,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',44,8,'30','True')
 
----------------------------------------Octavo Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,23,1,45,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,26,1,46,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,27,1,47,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,18,1,48,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,9,1,49,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,28,1,50,8,'30','','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',51,8,'30','True')
 
 
 
 
 
 
----------------------------------------Noveno Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,29,1,52,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,24,1,53,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,30,1,54,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,25,1,55,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,25,1,56,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,31,1,57,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,20,1,58,8,'30','','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'','',59,8,'30','True')
 
 
----------------------------------------Decimo Ciclo--------------------------------------------------------------------------------------------
 
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,11,1,60,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,24,1,61,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,30,1,62,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,19,1,63,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,31,1,64,8,'30','','True')
INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,29,1,65,8,'30','','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'','',66,8,'30','True')
 
 
 
------------------------------------------Tbl_DetalleCargaAcademica 2018 II-------------------------------------------------------------------------------
 
------------------------------------------Primer Ciclo--------------------------------------------------------------------------------------------
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,1,1,1,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,32,1,2,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,4,1,3,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,6,2,4,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,8,1,5,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,32,1,6,6,'30','True')
 
 
 
 
 
 
------------------------------------------Segundo Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,32,1,7,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,33,1,8,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,10,1,9,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,11,1,10,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,33,1,11,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,13,1,12,6,'30','True')
 
 
 
 
 
------------------------------------------Tercer Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,1,1,13,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,26,1,14,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,10,1,15,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,12,1,16,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,12,1,17,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,10,1,18,6,'30','True')
 
 
 
 
 
------------------------------------------Cuarto Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,17,1,19,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,34,1,20,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,11,1,21,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,11,1,22,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,16,1,23,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,12,1,24,6,'30','True')
 
 
 
 
 
 
------------------------------------------Quinto Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,20,1,25,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,18,1,26,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,12,1,27,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,15,1,28,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,16,1,29,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,10,1,30,6,'30','True')
 
 
------------------------------------------Sexto Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,20,1,31,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,34,1,32,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,18,1,33,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,17,1,34,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,21,1,35,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,22,1,36,6,'30','True')
 
 
------------------------------------------Septimo Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,23,1,37,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,24,1,38,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,19,1,39,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,21,1,40,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,25,1,41,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,22,1,42,6,'30','True')
----INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',43,8,'30','True')
----INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',44,8,'30','True')
 
------------------------------------------Octavo Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,23,1,45,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,26,1,46,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,27,1,47,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,18,1,48,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,19,1,49,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,28,1,50,6,'30','True')
----INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',51,8,'30','True')
 
 
 
 
 
 
------------------------------------------Noveno Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,35,1,52,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,24,1,53,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,30,1,54,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,25,1,55,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,25,1,56,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,31,1,57,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,35,1,58,6,'30','True')
----INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'','',59,8,'30','True')
 
 
------------------------------------------Decimo Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,11,1,60,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,24,1,61,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,30,1,62,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,19,1,63,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,31,1,64,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,35,1,65,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'','',66,8,'30','True')
 
 
 
 
----------------------------------------Tbl_DetalleCargaAcademica 2018 I-------------------------------------------------------------------------------
 
----------------------------------------Primer Ciclo--------------------------------------------------------------------------------------------
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,1,1,1,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,32,1,2,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,4,1,3,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,6,2,4,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,8,1,5,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,32,1,6,6,'30','True')
 
 
 
 
 
 
----------------------------------------Segundo Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,32,1,7,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,33,1,8,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,10,1,9,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,11,1,10,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,33,1,11,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,13,1,12,6,'30','True')
 
 
 
 
 
----------------------------------------Tercer Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,1,1,13,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,26,1,14,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,10,1,15,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,12,1,16,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,12,1,17,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,10,1,18,6,'30','True')
 
 
 
 
 
----------------------------------------Cuarto Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,17,1,19,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,34,1,20,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,11,1,21,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,11,1,22,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,16,1,23,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,12,1,24,6,'30','True')
 
 
 
 
 
 
----------------------------------------Quinto Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,20,1,25,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,18,1,26,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,12,1,27,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,15,1,28,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,16,1,29,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,10,1,30,6,'30','True')
 
 
----------------------------------------Sexto Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,20,1,31,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,34,1,32,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,18,1,33,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,17,1,34,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,21,1,35,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,22,1,36,6,'30','True')
 
 
----------------------------------------Septimo Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,23,1,37,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,24,1,38,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,19,1,39,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,21,1,40,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,25,1,41,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,22,1,42,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',43,8,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',44,8,'30','True')
 
----------------------------------------Octavo Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,23,1,45,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,26,1,46,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,27,1,47,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,18,1,48,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,19,1,49,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,28,1,50,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'...','...',51,8,'30','True')
 
 
 
 
----------------------------------------Noveno Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,35,1,52,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,24,1,53,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,30,1,54,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,25,1,55,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,25,1,56,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,31,1,57,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,35,1,58,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'','',59,8,'30','True')
 
 
----------------------------------------Decimo Ciclo--------------------------------------------------------------------------------------------
 
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,11,1,60,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,24,1,61,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,30,1,62,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,19,1,63,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,31,1,64,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,6,35,1,65,6,'30','True')
--INSERT INTO Tbl_DetalleCargaAcademica Values(1,8,'','',66,8,'30','True')



  















