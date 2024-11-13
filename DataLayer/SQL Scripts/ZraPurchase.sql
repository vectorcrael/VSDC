
-----------------------------------------------------------
----ZraPurchase view to extract purchases
-----------------------------------------------------------
DROP VIEW [dbo].[ZraPurchase]
GO

CREATE VIEW [dbo].[ZraPurchase] 
AS
SELECT TOP 5
	COALESCE(AP.OrderNum, AP.InvNumber, null) AS Origin,
	CAST(Inv.AutoIndex AS VARCHAR(20)) AS Id,
	COALESCE(NULLIF(Inv.InvNumber, ''), Inv.GrvNumber) AS InvoiceNumber,
	COALESCE(NULLIF(Inv.InvNumber, ''), Inv.GrvNumber) AS SupplierInvoiceNumber,
	'0' AS OriginalInvoiceNumber,
	'000' AS BranchId,
    '01' AS PaymentTypeCode,
	(SELECT Ag.cAgentName FROM _rtblAgents Ag WHERE Inv.iINVNUMAgentID = Ag.idAgents) AS IssuerName,
	CAST(Inv.iINVNUMAgentID AS VARCHAR(20)) AS IssuerId,
	CASE -- Check the SAGE currency mapping and update this script accordingly. 
		WHEN Curr.CurrencyLink IS NULL THEN 'ZMW'
		WHEN Curr.CurrencyLink = 1 THEN 'USD'
		WHEN Curr.CurrencyLink = 2 THEN 'ZAR'
		WHEN Curr.CurrencyLink = 3 THEN 'EUR'
		ELSE 'ZMW'
	END AS CurrencyType,
	CAST(Inv.fExchangeRate AS DECIMAL(8,4)) AS "ConversionRate",
    Inv.cAccountName AS CustomerName,
    Inv.cAccountName AS "BuyerTaxAccountName",
    CASE -- Check the invoice type mapping and update accordingly
		WHEN Inv.DocType IN (2,5) THEN 'S'
		ELSE 'R'
	END AS ReceiptTypeCode,
    Inv.cTaxNumber AS CustomerTpin,
	Inv.InvDate AS SaleDate,
    CASE
		WHEN Inv.DocType = 1 THEN '06'
		ELSE NULL
	END AS RefundedReasonCode
FROM [InvNum] as Inv
WITH (NOLOCK) 
Left join _bvInvNumAPFull AS AP ON Inv.AutoIndex = AP.AutoIndex
left join Currency Curr on Curr.CurrencyLink = Inv.ForeignCurrencyID
LEFT JOIN PurchaseInfo Pur ON COALESCE(NULLIF(Inv.InvNumber, ''), Inv.GrvNumber) = Pur.InvoiceNumber
WHERE Inv.DocType in (2,5) AND Inv.OrigDocID != 0
AND Pur.InvoiceNumber IS NULL
AND Inv.InvDate > '2024-06-30 00:00:00'  --This acts a cutoff. you want to set this date to the date the smart invoice was setup so that only invoices issues from that day gets fiscalized. 
GO
