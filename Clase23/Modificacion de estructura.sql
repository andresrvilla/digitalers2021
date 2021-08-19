select * from products

--Agrego columna
ALTER TABLE Products
ADD Outlet BIT
-- Quito columna
ALTER TABLE Products
DROP COLUMN Outlet
-- Agrego columna "not null" que necesita un valor por defecto
ALTER TABLE Products
ADD Outlet BIT NOT NULL DEFAULT 0

--Ahora quiero modificar la columna para que admita nulos
Alter table products
ALTER column Outlet BIT

EXEC sp_rename 'MisOrdenes', 'Ordenes'

ALTER TABLE LasOrdenes
DROP CONSTRAINT PK__MisOrden__C3905BAFE55E979C 

ALTER TABLE LasOrdenes
ADD CONSTRAINT PK_MisOrdenes Primary Key (OrderId)