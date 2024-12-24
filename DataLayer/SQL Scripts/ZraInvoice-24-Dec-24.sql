USE [ZRA-Test]
GO

/****** Object:  View [dbo].[ZraInvoice]    Script Date: 24/12/2024 3:43:51 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER VIEW [dbo].[ZraInvoice] 
AS

SELECT TOP 1
	/*inv.AutoIndex as id,--*/CAST(Inv.AutoIndex AS VARCHAR(20)) AS Id,
	Inv.InvNumber AS InvoiceNumber,
	cast((CASE 
        WHEN Inv.DocType = 1 THEN (select cPermitNumber from invnum ii where ii.autoindex= inv.iLinkedDocID  )
        ELSE '0'
    END) as int) AS OriginalInvoiceNumber,
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
END AS CurrencyType,
	CAST(Inv.fExchangeRate AS DECIMAL(8,4)) AS "ConversionRate",
    Inv.cAccountName AS CustomerName,
    Inv.cAccountName AS "BuyerTaxAccountName",
    CASE -- Check the invoice type mapping and update accordingly
		WHEN Inv.DocType = 0 THEN 'S'
		WHEN Inv.DocType = 4 THEN 'S'
		WHEN inv.DocType = 1 THEN 'R'
END AS ReceiptTypeCode,
    Inv.cTaxNumber AS CustomerTpin,
	Inv.InvDate AS SaleDate,
    CASE
		WHEN Inv.DocType = 1 THEN '06'
		ELSE NULL
END AS RefundReasonCode,
	(select count(a.idInvoiceLines) from _btblInvoiceLines a where a.iInvoiceID=inv.AutoIndex /*and iTaxTypeID in(1,2,3)*/ ) as totItemCnt,
	case when isnull(inv.ulIDInvDestinationCountryCode,'')='' then (select sum(fQuantityLineTotExcl) from _btblInvoiceLines a where a.iInvoiceID=inv.AutoIndex and iTaxTypeID in(1,2,3) ) else 0 end as taxblAmtA,
	case when isnull(inv.ulIDInvDestinationCountryCode,'')='' then (select sum(fQuantityLineTotExcl) from _btblInvoiceLines a where a.iInvoiceID=inv.AutoIndex and iTaxTypeID in(7) ) else 0 end  as taxblAmtD,
	case when isnull(inv.ulIDInvDestinationCountryCode,'')<>'' then (select sum(fQuantityLineTotExcl) from _btblInvoiceLines a where a.iInvoiceID=inv.AutoIndex and iTaxTypeID in(7) ) else '' end  as taxblAmtC1,
	'M' as 'regtycd',
	case when inv.DocType=1 then '03' else '11' end as 'sartycd',
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
		ulIDSOrdDestinationCountryCode,
		ulIDInvDestinationCountryCode,
        ucIDInvZRALOCALPURCHASEORDER, 
        ucIDSOrdZRALOCALPURCHASEORDER 
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
and  inv.InvDate>'2024-10-28 00:00:00'
and inv.zrasignature is null
GO