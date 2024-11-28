using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class ZRASTockAdjustment
{
    public string CustTpin { get; set; }
    public string CustNm { get; set; }
    public string RegTyCd { get; set; }
    public string SarTyCd { get; set; }
    public decimal? TotTaxblAmt { get; set; }
    public decimal? TotTaxAmt { get; set; }
    public decimal? TotAmt { get; set; }
    public string OcrnDt { get; set; }
    public int ItemSeq { get; set; }
    public string ItemCd { get; set; }
    public string ItemClsCd { get; set; }
    public string ItemNm { get; set; }
    public string PkgUnitCd { get; set; }
    public int Pkg { get; set; }
    public string QtyUnitCd { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Prc { get; set; }
    public decimal? SplyAmt { get; set; }
    public decimal? TotDcAmt { get; set; }
    public decimal? TaxblAmt { get; set; }
    public string VatCatCd { get; set; }
    public decimal? TaxAmt { get; set; }
}
