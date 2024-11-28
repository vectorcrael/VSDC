-----------------------------------------------------------
--UpdateFiscalDetails Stored Proc to insert fiscal details
-- CONVERSION DONE OF SIGNATURE TO BINARY
-----------------------------------------------------------
DROP
PROCEDURE
[dbo].[UpdateFiscalDetails]
GO

CREATE PROCEDURE [dbo].[UpdateFiscalDetails]
    @Signature VARBINARY(MAX),
    @InternalData NVARCHAR(255),
	@InvNumber NVARCHAR(255),
	@InvoiceType NVARCHAR(255),
	@InvoiceSequence NVARCHAR(255),
	@QrCode NVARCHAR(255),
	@VsdcDate NVARCHAR(255)
AS
BEGIN
UPDATE InvNum
SET imgOrderSignature = @Signature,
    cGIVNumber        = @InternalData,
    cPermitNumber     = @InvoiceSequence
WHERE InvNumber = @InvNumber;
END;


/*
    UPDATE InvNum
    SET cDPOrdServiceTaskNo = @Signature, cDSOrdServiceTaskNo = @InternalData, cDSMExtOrderNum = @InvoiceSequence
    WHERE InvNumber = @InvNumber;
*/
