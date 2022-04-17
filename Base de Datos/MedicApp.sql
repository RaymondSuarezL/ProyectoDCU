CREATE DATABASE MedicApp;
USE MedicApp;

CREATE TABLE Nuevos_Pacientes
(
ID_NPacientes INT IDENTITY(1,1) PRIMARY KEY, 
Nombres VARCHAR(100),
Apellidos VARCHAR(100),
Consulta BIT,
Seguro BIT,
TipoSeguro VARCHAR(100),
Correo VARCHAR(70),
Telefono NUMERIC,
Direccion VARCHAR(100)
)

CREATE TABLE	
(
ID_Soporte INT IDENTITY (1,1) PRIMARY KEY,
Nombre_Completo VARCHAR(100),
Correo VARCHAR(100),
Descripcion VARCHAR(150)
)


CREATE TABLE MedicamentosDisp
(
ID_MedD INT IDENTITY(1,1) PRIMARY KEY,
NombreMed VARCHAR(50)
)

CREATE TABLE Usuarios
(
ID_Usuario INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(50),
Usuario VARCHAR(50)NULL,
Password VARCHAR(50)NULL,
)
 
INSERT INTO Usuarios VALUES('UsuarioPrueba', 'admin', 'admin')
INSERT INTO Usuarios VALUES('Raymond Suarez', 'admin1', 'admin1')
INSERT INTO Usuarios VALUES('Joan Cuevas', 'admin2', 'admin2')

