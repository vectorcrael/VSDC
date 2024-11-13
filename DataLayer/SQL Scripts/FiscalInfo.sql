----------------------------------------------------
--FiscalInfo table to track fiscalised invoices
----------------------------------------------------
CREATE TABLE FiscalInfo(
       Id INT IDENTITY (1, 1) NOT NULL,
       InvoiceNumber nvarchar(50),
       Message nvarchar(max),
	   [CreateDate] DATETIME2 NULL DEFAULT (getdate()),
       PRIMARY KEY (Id)
);
CREATE INDEX idx_FiscalInfo_InvoiceNumber ON FiscalInfo (InvoiceNumber);

