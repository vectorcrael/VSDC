SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[ZraStockMaster] AS
SELECT 
	St.Code AS ITEMCODE,
	COALESCE(St.ItemGroupDescription, '10101504') AS ItemClassificationCode,
	COALESCE(st.UOMStockingUnitCode, 'NT') AS PackagingUnitCode,
	COALESCE(st.UOMStockingUnitCode, 'NO') AS QuantityUnitCode,
	CASE 
		WHEN St.ServiceItem = 1 THEN '3'
		ELSE '2'
	END AS ItemTypeCode,
	COALESCE(St.ItemGroup, 'CN') AS OriginNationCode,
	St.Description_1 AS Description,
	CASE 
		WHEN QtyInStock IS NULL THEN 0
		ELSE CAST(QtyInStock AS DECIMAL(18,4))
	END AS Quantity,
	Tr.cFiscalTaxLabel AS TaxLabel,
	'000' AS BranchId,
    St.AveUCst as Prc,
    St.AveUCst as SplyAmt,
    0.0 as TaxblAmt,
    'D' as VatCatCd,
    0.0 as TaxAmt,
    St.AveUCst as TotAmt

FROM _bvStockFull St
WITH (NOLOCK)
LEFT JOIN TaxRate Tr ON Tr.idTaxRate = St.TTI
GO
