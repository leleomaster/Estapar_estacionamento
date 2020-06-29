USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_S_PESSOA_TODOS 
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
		[dbo].[PESSOA] AS pes
	WHERE	
		pes.ATIVO = 1
GO
