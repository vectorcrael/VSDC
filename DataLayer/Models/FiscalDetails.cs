namespace DataLayer.Models;

public class FiscalDetails
{
    public byte[] qrCodeBinary { get; set; } 
    public string internalData { get; set; }
    public string invoiceNumber { get; set; }
    public string invoiceType { get; set; }
    public string invoiceSequence { get; set; }
    public string signature { get; set; }
    public string vsdcDate { get; set; }
}