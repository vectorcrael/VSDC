namespace VSDCAPI;

public class UpdateItemRequest
{
    public string tpin { get; set; }
    public string bhfId { get; set; }
    public string itemCd { get; set; }
    public int itemClsCd { get; set; }
    public string itemTyCd { get; set; }
    public string itemNm { get; set; }
    public string itemStdNm { get; set; }
    public string orgnNatCd { get; set; }
    public string pkgUnitCd { get; set; }
    public string qtyUnitCd { get; set; }
    public string vatCatCd { get; set; }
    public string? iplCatCd { get; set; }
    public string? tlCatCd { get; set; }
    public string? exciseTxCatCd { get; set; }

    public string? btchNo { get; set; }

    //  public string? bcd { get; set; }
    public double dftPrc { get; set; }
    public string? addInfo { get; set; }
    public decimal sftyQty { get; set; }
    public string isrcAplcbYn { get; set; }
    public string useYn { get; set; }
    public string regrNm { get; set; }
    public string regrId { get; set; } = "1";
    public string modrNm { get; set; }
    public string modrId { get; set; }
}