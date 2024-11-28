DROP VIEW [dbo].[ZraInvoice]
    GO

CREATE VIEW [dbo
].[ZraInvoice
]
AS

SELECT TOP 5 CAST(Inv.AutoIndex AS VARCHAR(20)) AS Id,
	Inv.InvNumber AS InvoiceNumber,
	CASE 
        WHEN Inv.DocType = 1 THEN COALESCE(OrigInv.cDSMExtOrderNum, '0')
        ELSE '0'
END
AS OriginalInvoiceNumber,
	COALESCE(NULLIF(RTRIM(OrigInv2.ulIDSOrdDestinationCountryCode), ''), NULLIF(RTRIM(OrigInv2.ulIDInvDestinationCountryCode), ''), null) AS DestinationCountryCode,
	COALESCE(NULLIF(RTRIM(OrigInv2.ucIDSOrdZRALOCALPURCHASEORDER), ''), NULLIF(RTRIM(OrigInv2.ucIDInvZRALOCALPURCHASEORDER), ''), null) AS LocalPurchaseOrder,
	'000' AS BranchId,
    '01' AS PaymentTypeCode,
	COALESCE((SELECT Ag.cAgentName FROM _rtblAgents Ag WHERE Inv.iINVNUMAgentID = Ag.idAgents), 'Admin') AS IssuerName,
	CAST(Inv.iINVNUMAgentID AS VARCHAR(20)) AS IssuerId,
	CASE -- Check the SAGE currency mapping and update this script accordingly. 
		WHEN Curr.CurrencyLink IS NULL THEN 'ZMW'
		WHEN Curr.CurrencyLink = 1 THEN 'USD'
		WHEN Curr.CurrencyLink = 2 THEN 'EUR'
		WHEN Curr.CurrencyLink = 3 THEN 'ZAR'
		ELSE 'ZMW'
END
AS CurrencyType,
	CAST(Inv.fExchangeRate AS DECIMAL(8,4)) AS "ConversionRate",
    Inv.cAccountName AS CustomerName,
    Inv.cAccountName AS "BuyerTaxAccountName",
    CASE -- Check the invoice type mapping and update accordingly
		WHEN Inv.DocType = 0 THEN 'S'
		WHEN Inv.DocType = 4 THEN 'S'
		WHEN inv.DocType = 1 THEN 'R'
END
AS ReceiptTypeCode,
    Inv.cTaxNumber AS CustomerTpin,
	Inv.InvDate AS SaleDate,
    CASE
		WHEN Inv.DocType = 1 THEN '06'
		ELSE NULL
END
AS RefundReasonCode,
	inv.*
FROM [InvNum] as Inv
WITH (NOLOCK)
left JOIN Currency Curr on Curr.CurrencyLink = Inv.ForeignCurrencyID
LEFT JOIN (
    SELECT 
		InvNumber,
        1 as cDSMExtOrderNum
    FROM _bvInvNumARFull 
	WITH (NOLOCK)
    WHERE DocType IN (0,4,1) 
      AND DocState = 4 
      AND InvNumber != '' 
      AND InvNumber IS NOT NULL 
      AND InvDate > '2024-06-30 00:00:00'
) AS OrigInv ON Inv.DeliveryNote = OrigInv.InvNumber
LEFT JOIN (
    SELECT 
		AutoIndex,
		1 as ulIDSOrdDestinationCountryCode,
		1 as ulIDInvDestinationCountryCode,
        1 as ucIDInvZRALOCALPURCHASEORDER, 
        1 as ucIDSOrdZRALOCALPURCHASEORDER 
    FROM _bvInvNumARFull 
	WITH (NOLOCK)
    WHERE DocType IN (0,4,1) 
      AND DocState = 4 
      AND InvNumber != '' 
      AND InvNumber IS NOT NULL 
      AND InvDate > '2024-06-30 00:00:00'
) AS OrigInv2 ON Inv.AutoIndex = OrigInv2.AutoIndex
LEFT JOIN FiscalInfo Fisc ON Inv.InvNumber = Fisc.InvoiceNumber
WHERE Inv.DocType in (0,4,1) AND Inv.DocState = 4
AND Inv.InvDate > '2024-06-30 00:00:00'
AND Inv.InvNumber != ''
AND Inv.InvNumber IS NOT NULL
AND Fisc.InvoiceNumber IS NULL
GO