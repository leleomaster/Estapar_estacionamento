USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_U_PESSOA (@idPessoa int, @cpf varchar(14), @dataNascimento varchar(10), @nome varchar(40))
AS
	update [dbo].[PESSOA]
	set CPF = @cpf, 
		DATA_NASCIMENTO = @dataNascimento, 
		NOME = @nome
	where ID_PESSOA = @idPessoa
GO