SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT Airplanes ON 

INSERT INTO Airplanes (Id,Codigo,Modelo,QuantidadePassageiros,DataRegistro) VALUES (1, N'111', N'444', 777, CONVERT(DateTime, N'2019-05-13 08:25:00.000'))
INSERT INTO Airplanes (Id,Codigo,Modelo,QuantidadePassageiros,DataRegistro) VALUES (2, N'222', N'555', 888, CONVERT(DateTime, N'2019-06-13 08:25:00.000'))
INSERT INTO Airplanes (Id,Codigo,Modelo,QuantidadePassageiros,DataRegistro) VALUES (3, N'333', N'666', 999, CONVERT(DateTime, N'2019-07-13 08:25:00.000'))

SET IDENTITY_INSERT Airplanes OFF
