-----------------------------------------------------------
----PurchaseInfo table to track fiscalised invoices
-----------------------------------------------------------
CREATE TABLE [dbo].[PurchaseInfo]
(
    [
    Id] [
    int]
    IDENTITY
(
    1,
    1
) NOT NULL,
    [InvoiceNumber] [nvarchar]
(
    50
) NULL,
    [Message] [varchar]
(
    max
) NULL,
    [CreateDate] DATETIME2 NULL DEFAULT
(
    getdate
(
)),
    PRIMARY KEY
(
    Id
)
    );
CREATE INDEX idx_PurchaseInfo_InvoiceNumber ON PurchaseInfo (InvoiceNumber);


