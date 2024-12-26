DECLARE @RC int
DECLARE @RefId varchar(50)

@RefId = 0

EXECUTE @RC = [dbo].[GetZraInvoiceItem] 
   @RefId
GO

EXECUTE [dbo].[GetZraPurchaseItem] 
   @RefId
GO