USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_D_MANOBRA_CARRO(@idManobraCarro int)
AS
	UPDATE [dbo].[MANOBRAR_CARRO]
    SET
		ATIVO = 0
	WHERE 
		ID_MANOBRAR_CARRO = @idManobraCarro
GO
