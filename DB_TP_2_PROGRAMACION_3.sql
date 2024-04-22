
-- CREATE DATABASE TP_2_PROGRAMACION_3 
-- GO 
-- USE TP_2_PROGRAMACION_3
-- GO 
-- CREATE TABLE ARTICULOS 
-- (
-- IDARTICULO INT NOT NULL PRIMARY KEY IDENTITY (1,1),
-- NOMBRE VARCHAR(50) NOT NULL,
-- MARCA VARCHAR(50) NOT NULL, 
-- PRECIO MONEY NOT NULL, 
-- CANTIDAD INT NOT NULL, 
-- )

INSERT INTO ARTICULOS (NOMBRE, MARCA,PRECIO,CANTIDAD)
VALUES 
('Laptop', 'Dell', 800, 20),
('Teléfono', 'Samsung', 500, 30),
('Tablet', 'Apple', 600, 25),
('Teclado', 'Logitech', 50, 100),
('Mouse', 'Microsoft', 30, 150),
('Monitor', 'LG', 200, 50),
('Impresora', 'HP', 150, 40),
('Altavoces', 'Bose', 100, 60),
('Auriculares', 'Sony', 80, 70),
('Cámara', 'Canon', 400, 15);
