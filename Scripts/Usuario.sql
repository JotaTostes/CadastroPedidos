IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_InsUsuario]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_InsUsuario]
GO

CREATE PROCEDURE [dbo].[GKSSP_InsUsuario]
	@Email varchar(50),
	@Senha varchar(15),
	@Nome varchar(30)
	
	AS

	/*
	Documentação
	Arquivo Fonte.....: Usuario.sql
	Objetivo..........: Inserir usuarios
	Autor.............: SMN - João Guilherme
 	Data..............: 22/08/2017
	Ex................: EXEC [dbo].[GKSSP_InsUsuario] 'joao_tostes17@hotmail.com','123321','João Guilherme'

	*/

	BEGIN
		INSERT INTO [dbo].[Usuario] (Email,Senha,Nome,Email_Valido)
			VALUES (@Email,@Senha,@Nome,'N')
	END
GO



IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_SelUsuario]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_SelUsuario]
GO

CREATE PROCEDURE [dbo].[GKSSP_SelUsuario] 
	@Email varchar(50)

	AS

	/*
	Documentação
	Arquivo Fonte.....: Usuario.sql
	Objetivo..........: Listar usuarios verifica se usuario esta disponivel
	Autor.............: SMN - João Guilherme
 	Data..............: 22/08/2017
	Ex................: EXEC [dbo].[GKSSP_SelUsuario] 'joao_tostes17@hotmail.com'

	*/

	BEGIN
		SELECT TOP 1 1
			FROM [dbo].[Usuario]
			WHERE Email = @Email

	END
GO



IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_SelUsuaSenha]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_SelUsuaSenha]
GO

CREATE PROCEDURE [dbo].[GKSSP_SelUsuaSenha]
	@Email varchar(50),
	@Senha varchar(15)
	AS

	/*
	Documentação
	Arquivo Fonte.....: Usuario.sql
	Objetivo..........: Listar Email e senha para verificar se ja existe
	Autor.............: SMN - João Guilherme
 	Data..............: 22/08/2017
	Ex................: EXEC [dbo].[GKSSP_SelUsuaSenha] 'joao_tostes17@hotmail.com','123321'
	*/

	BEGIN
		SELECT TOP 1 1
		FROM [dbo].[Usuario]
		WHERE Email = @Email and Senha = @Senha
	END
GO



IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_UpdEmailValido]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_UpdEmailValido]
GO

CREATE PROCEDURE [dbo].[GKSSP_UpdEmailValido]
	@Num_ChaveUsua int
	AS

	/*
	Documentação
	Arquivo Fonte.....: Usuario.sql
	Objetivo..........: Mudar o status do email para ativo
	Autor.............: SMN - João Guilherme
 	Data..............: 23/08/2017
	Ex................: EXEC [dbo].[GKSSP_UpdEmailValido] 2

	*/

	BEGIN
	
		UPDATE [dbo].[Usuario] 
		SET Email_valido = 'S'
		WHERE Num_ChaveUsua = @Num_ChaveUsua

	END
GO


								
