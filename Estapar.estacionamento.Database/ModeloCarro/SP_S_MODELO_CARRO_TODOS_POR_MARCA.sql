USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_S_MODELO_CARRO_TODOS_POR_MARCA(@idMarcaCarro int)
AS
	SELECT 
		mde.ID_MODELO_CARRO AS Id,
		mde.NOME AS Nome
	FROM 
		[dbo].[MODELO_CARRO] AS mde
	WHERE 
		ID_MARCA_CARRO = @idMarcaCarro
GO
