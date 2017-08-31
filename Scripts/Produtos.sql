
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_InsProd]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_InsProd]
GO

CREATE PROCEDURE [dbo].[GKSSP_InsProd]
	@Quantidade int,
	@Produto nvarchar(max),
	@ValorUnitario decimal
	AS

	/*
	Documentação
	Arquivo Fonte.....: Produtos.sql
	Objetivo..........: Inserir Produtos
	Autor.............: SMN - João Guilherme
 	Data..............: 30/08/2017
	Ex................: EXEC [dbo].[GKSSP_InsProd] '1','TesteProc','100'

	*/

	BEGIN
	
		INSERT INTO	[dbo].[Produtos](Quantidade,Produto,ValorUnitario)
			VALUES	(@ValorUnitario,@Produto,@Quantidade)
	END
GO


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[GKSSP_DelProduto]') AND objectproperty(id, N'IsPROCEDURE')=1)
	DROP PROCEDURE [dbo].[GKSSP_DelProduto]
GO

CREATE PROCEDURE [dbo].[GKSSP_DelProduto]
	@Num_ChaveIdProd int
	AS

	/*
	Documentação
	Arquivo Fonte.....: Produtos.sql
	Objetivo..........: Deletar produtos cadastrados
	Autor.............: SMN - João Guilherme
 	Data..............: 31/08/2017
	Ex................: EXEC [dbo].[GKSSP_DelProduto] 

	*/

	BEGIN
		DELETE  [dbo].[Produtos]
		WHERE Num_ChaveIdProd = @Num_ChaveIdProd
	END
GO
				


