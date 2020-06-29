USE [Estapar_estacionamento]
GO

CREATE PROCEDURE SP_S_MANOBRA_CARRO(@idManobraCarro int)
AS
	SELECT 
		MAN.ID_MANOBRAR_CARRO AS Id,
		MAN.PLACA_CARRO AS Placa,
		MAN.DATA_MANOBRA AS [Data],
		case 
		when MAN.ATIVO = 1		
		then 'Ativo'
		else 'Desativado' END AS Ativo,

		'' as idPessoa,
		PES.ID_PESSOA AS Id,
		PES.NOME AS Nome,
		PES.CPF AS Cpf,
		PES.DATA_NASCIMENTO AS DataNascimento,		
		case 
		when PES.ATIVO = 1		
		then 'Ativo'
		else 'Desativado' END AS Ativo,

		'' as idModeloCarro ,
		MDE.ID_MODELO_CARRO AS Id,
		MDE.NOME AS Nome,

		'' as idMarcaCarro ,
		MAR.ID_MARCA_CARRO AS Id,
		MAR.NOME AS Nome

	FROM [dbo].[MANOBRAR_CARRO] AS MAN
	INNER JOIN PESSOA AS PES
		ON MAN.ID_PESSOA = PES.ID_PESSOA
	INNER JOIN MODELO_CARRO AS MDE
		ON MAN.ID_MODELO_CARRO = MDE.ID_MODELO_CARRO
	INNER JOIN MARCA_CARRO AS MAR
		ON MDE.ID_MARCA_CARRO = MAR.ID_MARCA_CARRO
	WHERE 
		MAN.ID_MANOBRAR_CARRO = @idManobraCarro
	AND
		MAN.ATIVO = 1
GO

