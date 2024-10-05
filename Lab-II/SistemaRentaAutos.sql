CREATE DATABASE SistemaRentaAutos;

USE SistemaRentaAutos;

CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20),
    Email NVARCHAR(100)
);

CREATE TABLE Vehiculos (
    VehiculoID INT PRIMARY KEY IDENTITY(1,1),
    Marca NVARCHAR(50),
    Modelo NVARCHAR(50),
    Año INT,
    Disponibilidad BIT NOT NULL
);

CREATE TABLE Rentas (
    RentaID INT PRIMARY KEY IDENTITY(1,1),
    ClienteID INT,
    VehiculoID INT,
    FechaRenta DATETIME NOT NULL,
    FechaDevolucion DATETIME,
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
    FOREIGN KEY (VehiculoID) REFERENCES Vehiculos(VehiculoID)
);