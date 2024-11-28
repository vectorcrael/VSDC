-----------------------------------------------------------
--ZraStockMaster view to extract inventory items
-----------------------------------------------------------
DROP VIEW [dbo].[ZraStockMaster]
    GO

CREATE VIEW [dbo
].[ZraStockMaster
] AS
SELECT St.Code                                       AS ITEMCODE,
       COALESCE(St.ItemGroupDescription, '10101504') AS ItemClassificationCode,
       COALESCE(st.UOMStockingUnitCode, 'NT')        AS PackagingUnitCode,
       COALESCE(st.UOMStockingUnitCode, 'NO')        AS QuantityUnitCode,
       CASE
           WHEN St.ServiceItem = 1 THEN '3'
           ELSE '2'
           END                                       AS ItemTypeCode,
       COALESCE(St.ItemGroup, 'CN')                  AS OriginNationCode,
       St.Description_1                              AS Description,
       CASE
           WHEN QtyInStock IS NULL THEN 0
           ELSE CAST(QtyInStock AS DECIMAL(18, 4))
           END                                       AS Quantity,
       Tr.cFiscalTaxLabel                            AS TaxLabel,
       '000'                                         AS BranchId
FROM _bvStockFull St WITH (NOLOCK)
LEFT JOIN TaxRate Tr
ON Tr.idTaxRate = St.TTI
    GO

/*
14:35:24Started executing query at Line 1
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 24
Invalid column name 'TTInvID'.
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 7
Invalid column name 'ucIIUNSPSC'.
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 7
Invalid column name 'ucIIUNSPSC'.
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 8
Invalid column name 'uliiPackagingUnitCode'.
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 8
Invalid column name 'uliiPackagingUnitCode'.
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 9
Invalid column name 'ulIIQuantityUnitCode'.
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 9
Invalid column name 'ulIIQuantityUnitCode'.
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 14
Invalid column name 'ulIIOriginCountryCode'.
Msg 207, Level 16, State 1, Procedure ZraStockMaster, Line 14
Invalid column name 'ulIIOriginCountryCode'.
*/