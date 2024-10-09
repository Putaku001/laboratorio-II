CREATE TABLE Rentas (
    RentaID INT PRIMARY KEY IDENTITY(1,1),
    ClienteID INT NOT NULL,
    VehiculoID INT NOT NULL,
    FechaRenta DATETIME NOT NULL,
    HoraRenta DATETIME NOT NULL,
    FechaDevolucion DATETIME NOT NULL,
    HoraDevolucion DATETIME NOT NULL,
    
    CONSTRAINT FK_Rentas_Clientes FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId),
    CONSTRAINT FK_Rentas_Vehiculos FOREIGN KEY (VehiculoId) REFERENCES Vehiculos(VehiculoId)
);

INSERT INTO Rentas (ClienteID, VehiculoID, FechaRenta, HoraRenta, FechaDevolucion, HoraDevolucion)
VALUES (1, 2, '2024-10-15 10:00:00', '2024-10-09 11:00:00', '2024-10-16 14:00:00', '2024-10-12 18:00:00');

select * from Rentas

SELECT 
R.RentaID,
CONCAT(C.Nombre, C.Email) AS Cliente,
CONCAT(V.Modelo, V.Marca) AS carro,  
FORMAT (R.FechaRenta,'dd-MM-yyyy') AS 'Fecha de Renta',
R.HoraRenta,
FORMAT(R.FechaDevolucion,'dd-MM-yyyy') AS 'Fecha de Retiro',
R.HoraDevolucion
FROM 
Rentas AS R
INNER JOIN 
Clientes AS C ON R.ClienteID = C.ClienteID
INNER JOIN 
  Vehiculos AS V ON R.VehiculoID = V.VehiculoID