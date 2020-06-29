USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_I_MANOBRA_CARRO(@idModeleCarro int,@placaCarro varchar(8),@idPessoa int)
AS
	INSERT INTO [dbo].[MANOBRAR_CARRO]
    (
		[PLACA_CARRO],
		[ID_MODELO_CARRO],
		[ID_PESSOA],
		[DATA_MANOBRA],
		[ATIVO]
	)
     VALUES
	(
		@idModeleCarro,
		@placaCarro,
		@idPessoa,
		GETDATE(),
		1
	)
GO
