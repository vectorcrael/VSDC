using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Keyless]
    public class SmartPurchase
    {
        public string SpplrTpin { get; set; }
        public string SpplrNm { get; set; }
        public string SpplrBhfId { get; set; }
        public decimal? SpplrInvcNo { get; set; }
        public string RcptTyCd { get; set; }
        public string PmtTyCd { get; set; }
        public string CfmDt { get; set; }
        public string SalesDt { get; set; }
        public string StockRlsDt { get; set; }
        public int? TotItemCnt { get; set; }
        public decimal? TotTaxblAmt { get; set; }
        public decimal? TotTaxAmt { get; set; }
        public decimal? TotAmt { get; set; }
        public string Remark { get; set; }
        public int? ItemSeq { get; set; }
        public string ItemCd { get; set; }
        public string ItemClsCd { get; set; }
        public string ItemNm { get; set; }
        public string Bcd { get; set; }
        public string PkgUnitCd { get; set; }
        public decimal? Pkg { get; set; }
        public string QtyUnitCd { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Prc { get; set; }
        public decimal? SplyAmt { get; set; }
        public decimal? DcRt { get; set; }
        public decimal? DcAm { get; set; }
        public string VatCatCd { get; set; }
        public string IplCatCd { get; set; }
        public string TlCatCd { get; set; }
        public string ExciseTxCatC { get; set; }
        public decimal? VatTaxblAmt { get; set; }
        public decimal? ExciseTaxblAmt { get; set; }
        public decimal? IplTaxblAmt { get; set; }
        public decimal? TlTaxblAmt { get; set; }
        public decimal? TaxblAmt { get; set; }
        public decimal? VatAmt { get; set; }
        public decimal? IplAmt { get; set; }
        public decimal? TlAmt { get; set; }
        public decimal? ExciseTxAmt { get; set; }
        public decimal? TtotAmt { get; set; }
    }
}