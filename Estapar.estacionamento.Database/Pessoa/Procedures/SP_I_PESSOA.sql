USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_I_PESSOA (@cpf varchar(14), @dataNascimento varchar(10), @nome varchar(40))
AS
	INSERT INTO [dbo].[PESSOA]([CPF],[DATA_NASCIMENTO],[NOME],[ATIVO])
	VALUES (@cpf, @dataNascimento, @nome, 1)
GO


