----------------------------------------------------------
--GetZraPurchaseItem view to extract purchase line items
-----------------------------------------------------------
DROP
PROCEDURE
[dbo].[GetZraPurchaseItem]
GO

CREATE PROCEDURE GetZraPurchaseItem(@RefId VARCHAR(50))
    AS
BEGIN
SET
NOCOUNT ON
SELECT CAST(iInvoiceID AS VARCHAR(50))                 AS RefId,
       iLineID                                         AS ItemSequenceNumber,
       cDescription                                    AS ItemDesc,
       COALESCE(st.ItemGroupDescription, '10101504')   AS ItemClassificationCode,
       CASE
           WHEN (SELECT st.Code FROM _bvStockFull AS st WHERE st.StockLink = It.iStockCodeID) IS NULL THEN 'URI'
           ELSE (SELECT st.Code FROM _bvStockFull AS st WHERE st.StockLink = It.iStockCodeID)
           END                                         AS ItemCode,
       CAST(fQtyProcessed AS DECIMAL(20, 4))           AS Quantity,
       Tr.cFiscalTaxLabel                              AS TaxLabel,
       COALESCE(st.UOMStockingUnitCode, 'NT')          AS PackagingUnitCode,
       COALESCE(st.UOMStockingUnitCode, 'NO')          AS QuantityUnitCode,
       0.0                                             AS DiscountAmount,
       CASE
           WHEN fQuantity IS NULL OR fQtyProcessed = 0 THEN 0
           ELSE CAST(
                   CASE
                       WHEN fQtyProcessedLineTotInclForeign IS NULL OR fQtyProcessedLineTotInclForeign = 0
                           THEN fQtyprocessedLineTotIncl
                       ELSE fQtyProcessedLineTotInclForeign
                       END / fQtyProcessed AS DECIMAL(20, 4)
                )
           END                                         AS "UnitPrice",
       CASE
           WHEN fQtyProcessedLineTotInclForeign != 0 THEN CAST(fQtyProcessedLineTotInclForeign AS DECIMAL(20, 4))
           ELSE CAST(fQtyprocessedLineTotIncl AS DECIMAL(20, 4))
           END                                         as "TotalAmount",
       1                                               as isTaxInclusive,
       CAST(fRecommendedRetailPrice AS DECIMAL(20, 4)) AS RRP
from [_btblInvoiceLines] It
WITH (NOLOCK)
    LEFT JOIN _bvStockFull st
ON st.StockLink = It.iStockCodeID
    LEFT JOIN TaxRate Tr ON Tr.idTaxRate = It.iTaxTypeID
WHERE iInvoiceID = @RefId AND It.iGrvLineID != 0
END
GO
