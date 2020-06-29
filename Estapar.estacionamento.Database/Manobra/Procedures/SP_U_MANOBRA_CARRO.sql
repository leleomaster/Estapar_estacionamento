USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_U_MANOBRA_CARRO(@idManobraCarro int ,@idModeleCarro int,@placaCarro varchar(8),@idPessoa int)
AS
	UPDATE [dbo].[MANOBRAR_CARRO]
    SET
		[PLACA_CARRO] = @placaCarro,
		[ID_MODELO_CARRO] =  @idModeleCarro,
		[ID_PESSOA] = @idPessoa
	WHERE 
		ID_MANOBRAR_CARRO = @idManobraCarro
GO
