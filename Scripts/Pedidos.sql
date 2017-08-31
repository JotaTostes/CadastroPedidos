IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_InsPedido]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_InsPedido]
GO

CREATE PROCEDURE [dbo].[GKSSP_InsPedido]
	@DataPed datetime,
	@Cliente varchar(40),
	@Valor decimal(18,2)

	AS

	/*
	Documentação
	Arquivo Fonte.....: Pedidos.sql
	Objetivo..........: Inserir Pedidos no BD
	Autor.............: SMN - João Guilherme
 	Data..............: 25/08/2017
	Ex................: EXEC [dbo].[GKSSP_InsPedido]

	*/

	BEGIN
	
	INSERT INTO [dbo].[Pedidoes] (DataPed,Cliente,Valor)	
		VALUES (@DataPed,@Cliente,@Valor)
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_UpdPedido]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_UpdPedido]
GO

CREATE PROCEDURE [dbo].[GKSSP_UpdPedido]
	@Num_ChaveIdPed int,
	@DataPed datetime,
	@Cliente varchar(40),
	@Valor decimal(18,2)
	AS

	/*
	Documentação
	Arquivo Fonte.....: Pedidos.sql
	Objetivo..........: Editar Pedidos
	Autor.............: SMN - João Guilherme
 	Data..............: 25/08/2017
	Ex................: EXEC [dbo].[GKSSP_UpdPedido]

	*/

	BEGIN
		UPDATE [dbo].[Pedidoes]
			SET	DataPed = @DataPed,
				Cliente = @Cliente,
				Valor = @Valor
			WHERE  Num_ChaveIdPed = @Num_ChaveIdPed
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_DelPedido]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_DelPedido]
GO

CREATE PROCEDURE [dbo].[GKSSP_DelPedido]
	@Num_ChaveIdPed int
	AS

	/*
	Documentação
	Arquivo Fonte.....: Pedidos.sql
	Objetivo..........: Deletar pedidos
	Autor.............: SMN - João Guilherme
 	Data..............: 28/08/2018
	Ex................: EXEC [dbo].[GKSSP_DelPedido] 1014

	*/

	BEGIN
		DELETE [dbo].[Pedidoes]
		WHERE Num_ChaveIdPed = @Num_ChaveIdPed	
	END
GO
