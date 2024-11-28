namespace ServicesLayer.DTOs;

public class GetImports
{
    public List<Item> itemList { get; set; }
}

public class Item
{
    public string taskCd { get; set; }
    public string dclDe { get; set; }
    public decimal? itemSeq { get; set; }
    public string dclNo { get; set; }
    public string hsCd { get; set; }
    public string itemNm { get; set; }
    public string imptItemsttsCd { get; set; }
    public string orgnNatCd { get; set; }
    public string exptNatCd { get; set; }
    public decimal? pkg { get; set; }
    public string pkgUnitCd { get; set; }
    public decimal? qty { get; set; }
    public string qtyUnitCd { get; set; }
    public decimal? totWt { get; set; }
    public decimal? netWt { get; set; }
    public string spplrNm { get; set; }
    public string agntNm { get; set; }
    public decimal? invcFcurAmt { get; set; }
    public string invcFcurCd { get; set; }
    public decimal? invcFcurExcrt { get; set; }
    public string dclRefNum { get; set; }
}