
public class SmartPurchases
{
    public List<Sale> saleList { get; set; }
}

public class Sale
{
    public string spplrTpin { get; set; }
    public string spplrNm { get; set; }
    public string spplrBhfId { get; set; }
    public int spplrInvcNo { get; set; }
    public string rcptTyCd { get; set; }
    public string pmtTyCd { get; set; }
    public string cfmDt { get; set; }
    public string salesDt { get; set; }
    public string stockRlsDt { get; set; }
    public int? totItemCnt { get; set; }
    public decimal? totTaxblAmt { get; set; }
    public decimal? totTaxAmt { get; set; }
    public decimal? totAmt { get; set; }
    public string remark { get; set; }
    public List<Item> itemList { get; set; }
}

public class Item
{
    public int itemSeq { get; set; }
    public string itemCd { get; set; }
    public string itemClsCd { get; set; }
    public string itemNm { get; set; }
    public string bcd { get; set; }
    public string pkgUnitCd { get; set; }
    public decimal pkg { get; set; }
    public string qtyUnitCd { get; set; }
    public decimal qty { get; set; }
    public decimal prc { get; set; }
    public decimal splyAmt { get; set; }
    public decimal dcRt { get; set; }
    public decimal dcAmt { get; set; }
    public string vatCatCd { get; set; }
    public string iplCatCd { get; set; }
    public string tlCatCd { get; set; }
    public string exciseTxCatCd { get; set; }
    public decimal vatTaxblAmt { get; set; }
    public decimal exciseTaxblAmt { get; set; }
    public decimal iplTaxblAmt { get; set; }
    public decimal tlTaxblAmt { get; set; }
    public decimal taxblAmt { get; set; }
    public decimal vatAmt { get; set; }
    public decimal iplAmt { get; set; }
    public decimal tlAmt { get; set; }
    public decimal exciseTxAmt { get; set; }
    public decimal totAmt { get; set; }
}