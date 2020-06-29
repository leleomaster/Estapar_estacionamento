USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_D_PESSOA (@idPessoa int)
AS
	update [dbo].[PESSOA]
	set ATIVO = 0	
	where ID_PESSOA = @idPessoa
GO