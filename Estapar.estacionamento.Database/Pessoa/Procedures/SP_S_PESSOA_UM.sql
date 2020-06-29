USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_S_PESSOA_UM (@idPessoa int)
AS
	SELECT 
		pes.ID_PESSOA AS Id,
		case 
		when pes.ATIVO = 1		
		then 'Ativo'
		else 'Desativado' END AS Ativo,
		pes.CPF AS Cpf,
		pes.DATA_NASCIMENTO AS DataNascimento,
		pes.NOME AS Nome
	FROM 
		[dbo].[PESSOA] AS Pes
	WHERE 
		ID_PESSOA = @idPessoa
	AND
		pes.ATIVO = 1
GO
