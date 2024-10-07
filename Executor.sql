DECLARE @RC int
DECLARE @RefId varchar(50)

-- TODO: Set parameter values here.

EXECUTE @RC = [dbo].[GetZraInvoiceItem] 
   @RefId
GO

EXECUTE [dbo].[GetZraPurchaseItem] 
   @RefId
GO