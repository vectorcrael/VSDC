using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class ZRASTockAdjustment
{
    public string? CustTpin { get; set; }
    public string? CustNm { get; set; }
    public string? RegTyCd { get; set; }
    public string SarTyCd { get; set; }
    public decimal? TotTaxblAmt { get; set; }
    public double? TotTaxAmt { get; set; }
    public double? TotAmt { get; set; }
    public string? OcrnDt { get; set; }
    public int ItemSeq { get; set; }
    public string? ItemCd { get; set; }
    public string? ItemClsCd { get; set; }
    public string? ItemNm { get; set; }
    public string? PkgUnitCd { get; set; }
    public int Pkg { get; set; }
    public string QtyUnitCd { get; set; }
    public double? Qty { get; set; }
    public double? Prc { get; set; }
    public double? SplyAmt { get; set; }
    public int? TotDcAmt { get; set; }
    public double? TaxblAmt { get; set; }
    public string VatCatCd { get; set; }
    public double? TaxAmt { get; set; }
}
