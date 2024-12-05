namespace VSDCAPI;

public class SaveStockItemRequest
{
    public string tpin { get; set; }
    public string bhfId { get; set; }
    public int sarNo { get; set; }
    public int orgSarNo { get; set; }
    public string regTyCd { get; set; }
    public string? custTpin { get; set; }
    public string custNm { get; set; }
    public string custBhfId { get; set; }
    public string sarTyCd { get; set; }
    public string ocrnDt { get; set; }
    public int totItemCnt { get; set; }
    public double totTaxblAmt { get; set; }
    public double totTaxAmt { get; set; }
    public double totAmt { get; set; }
    public string remark { get; set; }
    public string regrId { get; set; }
    public string regrNm { get; set; }
    public string modrNm { get; set; }
    public string modrId { get; set; }
    public List<ItemList> itemList { get; set; }
}

public class ItemList
{
    public int itemSeq { get; set; }
    public string itemCd { get; set; }
    public string itemClsCd { get; set; }
    public string itemTyCd { get; set; }
    public string itemNm { get; set; }
    public string pkgUnitCd { get; set; }
    public string qtyUnitCd { get; set; }
    public decimal qty { get; set; }
    public decimal pkg { get; set; }
    public double prc { get; set; }
    public double splyAmt { get; set; }
    public double taxblAmt { get; set; }
    public string vatCatCd { get; set; }
    public double taxAmt { get; set; }
    public double totAmt { get; set; }
    public double totDcAmt {get; set;}

}