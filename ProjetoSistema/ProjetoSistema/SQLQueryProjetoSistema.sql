USE master
GO 

DROP DATABASE IF EXISTS Projeto_sistema;
GO

--NOME DA BASE DE DADOS "PROJETO_SISTEMA"

IF (NOT EXISTS(SELECT* FROM INFORMATION_SCHEMA.SCHEMATA WHERE CATALOG_NAME = 'Projeto_sistema'))
	BEGIN 
		CREATE DATABASE Projeto_sistema
	END
GO

USE Projeto_sistema
GO


/*SCRIPT DAS TABELAS DO SISTEMA*/
--------------------------------------------
IF OBJECT_ID(N'dbo.S2_USUARIO',N'U') IS NULL
	BEGIN
	CREATE TABLE S2_USUARIO 
	(
		COD_USUR INT IDENTITY(1,1),
		LOGIN_USUR VARCHAR (50),
		SENHA_USUR VARCHAR (20),
		COD_STAT INT 	
	)
	END
GO

-----------------------------------------------------

IF OBJECT_ID(N'dbo.S2_FUNCIONARIO',N'U') IS NULL
	BEGIN
	CREATE TABLE S2_FUNCIONARIO 
	(
		COD_FUNC INT IDENTITY(1,1),
		NOM_FUNC VARCHAR (50),
		DAT_NASC DATE,
		DAT_CONTRATADO DATE,
		COD_STAT INT

	)
	END
GO
---------------------------------------------
IF OBJECT_ID(N'dbo.S2_HOSPEDE',N'U') IS NULL
	BEGIN
	CREATE TABLE S2_HOSPEDE 
	(
		COD_HOSPEDE INT IDENTITY(1,1),
		NOM_HOSPEDE VARCHAR (50),
		CPF_HOSPEDE VARCHAR (14),
		DATA_CHECKIN DATETIME,
		DATA_CHECKOUT DATETIME,
		NUM_QUART INT
	)
	END
GO
---------------------------------------------
IF OBJECT_ID(N'dbo.S2_QUARTO',N'U') IS NULL
	BEGIN
	CREATE TABLE S2_QUARTO 
	(
		COD_QUART INT IDENTITY(1,1),
		NOM_QUART	 VARCHAR (50)
	)
	END
GO
----------------------------------------------------
IF OBJECT_ID(N'dbo.S2_STATUS_USUARIO',N'U') IS NULL
	BEGIN
	CREATE TABLE S2_STATUS_USUARIO 
	(
		COD_STAT INT IDENTITY(1,1),
		DESCR_STAT_USUR VARCHAR (15)
	)
	END
GO

------------------------------------------------------
IF OBJECT_ID(N'dbo.S2_STATUS_FUNCIONARIO',N'U') IS NULL
	BEGIN
	CREATE TABLE S2_STATUS_FUNCIONARIO 
	(
		COD_STAT INT IDENTITY(1,1),
		DESCR_STAT VARCHAR (15)
	)
	END
GO


/*SCRIPT DAS STORED PROCEDURES DO SISTEMA*/
--------------------------------------------------------------------------------------------------------------------

IF OBJECT_ID ('dbo.uspUsuarioLocalizarLogin', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspUsuarioLocalizarLogin ;
GO

CREATE PROCEDURE dbo.uspUsuarioLocalizarLogin

@LOGIN_USUR VARCHAR (30),
@SENHA_USUR VARCHAR (30)
AS
BEGIN
	
	SELECT LOGIN_USUR, SENHA_USUR FROM S2_USUARIO WHERE LOGIN_USUR = @LOGIN_USUR AND SENHA_USUR = @SENHA_USUR  ORDER BY S2_USUARIO.LOGIN_USUR

END
GO
----------------------------------------------------------------------------------------------------------------
IF OBJECT_ID ('dbo.uspUsuarioIncluir', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspUsuarioIncluir ;
GO

CREATE PROCEDURE dbo.uspUsuarioIncluir
	@LOGIN_USUR VARCHAR(50),
	@SENHA_USUR VARCHAR(20),
	@COD_STAT  INT
AS 
BEGIN

	INSERT INTO S2_USUARIO(LOGIN_USUR, SENHA_USUR, COD_STAT)
	VALUES(@LOGIN_USUR, @SENHA_USUR, @COD_STAT)

	SELECT @@IDENTITY AS retorno
END
GO
-------------------------------------------------------------------------------------------


IF OBJECT_ID ('dbo.uspUsuarioLocalizar', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspUsuarioLocalizar ;
GO

CREATE PROCEDURE dbo.uspUsuarioLocalizar

AS
BEGIN
	
	SELECT 
		S2_USUARIO.LOGIN_USUR,
		S2_STATUS_USUARIO.DESCR_STAT_USUR
	FROM 
		S2_USUARIO
		INNER JOIN S2_STATUS_USUARIO ON S2_STATUS_USUARIO.COD_STAT = S2_USUARIO.COD_STAT

END
GO
------------------------------------------------------

IF OBJECT_ID ('dbo.uspLocalizarUsuarioStatus', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspLocalizarUsuarioStatus;
GO

CREATE PROCEDURE dbo.uspLocalizarUsuarioStatus
AS 
BEGIN
	 
	SELECT COD_STAT, DESCR_STAT_USUR FROM S2_STATUS_USUARIO ORDER BY S2_STATUS_USUARIO.COD_STAT ASC

END
GO
---------------------------------------------------------------------------------------------------

IF OBJECT_ID ('dbo.uspFuncionarioLocalizar', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspFuncionarioLocalizar ;
GO

CREATE PROCEDURE dbo.uspFuncionarioLocalizar

AS
BEGIN
	
	SELECT 
		S2_FUNCIONARIO.NOM_FUNC,
		S2_FUNCIONARIO.DAT_NASC,
		S2_FUNCIONARIO.DAT_CONTRATADO,
		S2_STATUS_FUNCIONARIO.DESCR_STAT
	FROM 
		S2_FUNCIONARIO
		INNER JOIN S2_STATUS_FUNCIONARIO ON S2_STATUS_FUNCIONARIO.COD_STAT = S2_FUNCIONARIO.COD_STAT

END
GO

-------------------------------------------------------------------------------------------------------

IF OBJECT_ID ('dbo.uspFuncionarioIncluir', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspFuncionarioIncluir ;
GO

CREATE PROCEDURE dbo.uspFuncionarioIncluir
	@NOM_FUNC VARCHAR(50),
	@DAT_NASC DATETIME,
	@DAT_CONTRATADO DATETIME,
	@COD_STAT  VARCHAR(9)
AS 
BEGIN

	INSERT INTO S2_FUNCIONARIO(NOM_FUNC, DAT_NASC, DAT_CONTRATADO, COD_STAT)
	VALUES(@NOM_FUNC, @DAT_NASC, @DAT_CONTRATADO,@COD_STAT)

	SELECT @@IDENTITY AS retorno
END
GO

------------------------------------------------------

IF OBJECT_ID ('dbo.uspLocalizarFuncionarioStatus', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspLocalizarFuncionarioStatus;
GO

CREATE PROCEDURE dbo.uspLocalizarFuncionarioStatus
AS 
BEGIN
	 
	SELECT COD_STAT, DESCR_STAT FROM S2_STATUS_FUNCIONARIO ORDER BY S2_STATUS_FUNCIONARIO.COD_STAT ASC

END
GO
-------------------------------------------------------------------------------------------

IF OBJECT_ID ('dbo.uspHospedeLocalizar', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspHospedeLocalizar ;
GO

CREATE PROCEDURE dbo.uspHospedeLocalizar

AS
BEGIN
	
	SELECT 
		S2_HOSPEDE.NOM_HOSPEDE,
		S2_HOSPEDE.CPF_HOSPEDE,
		S2_HOSPEDE.DATA_CHECKIN,
		S2_HOSPEDE.DATA_CHECKOUT,
		S2_QUARTO.NOM_QUART
	FROM 
		S2_HOSPEDE
		INNER JOIN S2_QUARTO ON S2_QUARTO.COD_QUART = S2_HOSPEDE.NUM_QUART

END
GO

-------------------------------------------------------------------------------------------------------

IF OBJECT_ID ('dbo.uspHospedeIncluir', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspHospedeIncluir ;
GO

CREATE PROCEDURE dbo.uspHospedeIncluir
	@NOM_HOSPEDE VARCHAR(50),
	@CPF_HOSPEDE VARCHAR(11),
	@DAT_CHECKIN DATETIME,
	@DAT_CHECKOUT DATETIME,
	@NUM_QUART  INT
AS 
BEGIN

	INSERT INTO S2_HOSPEDE(NOM_HOSPEDE, CPF_HOSPEDE, DATA_CHECKIN, DATA_CHECKOUT,NUM_QUART)
	VALUES(@NOM_HOSPEDE, @CPF_HOSPEDE, @DAT_CHECKIN,@DAT_CHECKOUT, @NUM_QUART)

	SELECT @@IDENTITY AS retorno
END
GO

------------------------------------------------------

IF OBJECT_ID ('dbo.uspLocalizarQuartos', 'P') IS NOT NULL
	DROP PROCEDURE dbo.uspLocalizarQuartos;
GO

CREATE PROCEDURE dbo.uspLocalizarQuartos
AS 
BEGIN
	 
	SELECT COD_QUART, NOM_QUART FROM S2_QUARTO ORDER BY S2_QUARTO.COD_QUART ASC

END
GO
--------------------------------------------------------
/*SCRIPTS DE INSERCAO DE DADOS NAS TABELAS*/

---------------------------------------------
--LOGINS

INSERT INTO S2_USUARIO(LOGIN_USUR, SENHA_USUR, COD_STAT)
VALUES 'caio.sena', '***', 1 

INSERT INTO S2_USUARIO(LOGIN_USUR, SENHA_USUR, COD_STAT)
VALUES 'alessandra', '***', 1

INSERT INTO S2_USUARIO(LOGIN_USUR, SENHA_USUR, COD_STAT)
VALUES 'marcos.oliveira', '***', 1

INSERT INTO S2_USUARIO(LOGIN_USUR, SENHA_USUR, COD_STAT)
VALUES 'eliezer', '**', 1
-----------------------------------------------------
-- COMBO BOX STATUS DA TELA DE FUNCIONARIO

INSERT INTO S2_STATUS_FUNCIONARIO(DESCR_STAT)
VALUES 'ATIVO'

INSERT INTO S2_STATUS_FUNCIONARIO(DESCR_STAT)
VALUES 'FERIAS'

INSERT INTO S2_STATUS_FUNCIONARIO(DESCR_STAT)
VALUES 'SUSPENSO'

INSERT INTO S2_STATUS_FUNCIONARIO(DESCR_STAT)
VALUES 'EM VIAGEM'

INSERT INTO S2_STATUS_FUNCIONARIO(DESCR_STAT)
VALUES 'DESLIGADO'
----------------------------------------------------------
-- COMBO BOX STATUS DA TELA DE USUARIO

INSERT INTO S2_STATUS_USUARIO(DESCR_STAT_USUR)
VALUES 'ATIVO'

INSERT INTO S2_STATUS_USUARIO(DESCR_STAT_USUR)
VALUES 'INATIVO'
----------------------------------------------
--COMBO BOX QUARTO DA TELA DE HOSPEDE

INSERT INTO S2_QUARTO (NOM_QUART)
VALUES 'Quarto 01'

INSERT INTO S2_QUARTO (NOM_QUART)
VALUES 'Quarto 02'

INSERT INTO S2_QUARTO (NOM_QUART)
VALUES 'Quarto 03'

INSERT INTO S2_QUARTO (NOM_QUART)
VALUES 'Quarto 04'

INSERT INTO S2_QUARTO (NOM_QUART)
VALUES 'Quarto 05'
