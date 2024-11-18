using System;

namespace ServicesLayer.DTOs;

public class SaveInvoiceData
{
    public int rcptNo { get; set; }
    public string intrlData { get; set; }
    public string rcptSign { get; set; }
    public string vsdcRcptPbctDate { get; set; }
    public string sdcId { get; set; }
    public string mrcNo { get; set; }
    public string qrCodeUrl { get; set; }

}
