using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFiscalInspurDatum
{
    [Column("idInvoiceTaxes")]
    public long IdInvoiceTaxes { get; set; }

    [Column("iInvoiceID")]
    public int IInvoiceId { get; set; }

    [Column("iTaxTypeA")]
    public int? ITaxTypeA { get; set; }

    [Column("FTaxTypeAAm")]
    public double? FtaxTypeAam { get; set; }

    [Column("fTaxTypeATax")]
    public double? FTaxTypeAtax { get; set; }

    [Column("TaxATotal")]
    public double? TaxAtotal { get; set; }

    [Column("TaxADescription")]
    [StringLength(59)]
    [Unicode(false)]
    public string? TaxAdescription { get; set; }

    [Column("iTaxTypeB")]
    public int? ITaxTypeB { get; set; }

    [Column("fTaxTypeBAm")]
    public double? FTaxTypeBam { get; set; }

    [Column("fTaxTypeBTax")]
    public double? FTaxTypeBtax { get; set; }

    [Column("TaxBTotal")]
    public double? TaxBtotal { get; set; }

    [Column("TaxBDescription")]
    [StringLength(59)]
    [Unicode(false)]
    public string? TaxBdescription { get; set; }

    [Column("iTaxTypeC")]
    public int? ITaxTypeC { get; set; }

    [Column("fTaxTypeCAm")]
    public double? FTaxTypeCam { get; set; }

    [Column("fTaxTypeCTax")]
    public double? FTaxTypeCtax { get; set; }

    [Column("TaxCTotal")]
    public double? TaxCtotal { get; set; }

    [Column("TaxCDescription")]
    [StringLength(59)]
    [Unicode(false)]
    public string? TaxCdescription { get; set; }

    [Column("iTaxTypeD")]
    public int? ITaxTypeD { get; set; }

    [Column("fTaxTypeDAm")]
    public double? FTaxTypeDam { get; set; }

    [Column("fTaxTypeDTax")]
    public double? FTaxTypeDtax { get; set; }

    [Column("TaxDTotal")]
    public double? TaxDtotal { get; set; }

    [Column("TaxDDescription")]
    [StringLength(59)]
    [Unicode(false)]
    public string? TaxDdescription { get; set; }

    [Column("iTaxTypeE")]
    public int? ITaxTypeE { get; set; }

    [Column("fTaxTypeEAm")]
    public double? FTaxTypeEam { get; set; }

    [Column("fTaxTypeETax")]
    public double? FTaxTypeEtax { get; set; }

    [Column("TaxETotal")]
    public double? TaxEtotal { get; set; }

    [Column("TaxEDescription")]
    [StringLength(59)]
    [Unicode(false)]
    public string? TaxEdescription { get; set; }

    [Column("iTaxTypeF")]
    public int? ITaxTypeF { get; set; }

    [Column("fTaxTypeFAm")]
    public double? FTaxTypeFam { get; set; }

    [Column("fTaxTypeFTax")]
    public double? FTaxTypeFtax { get; set; }

    [Column("TaxFTotal")]
    public double? TaxFtotal { get; set; }

    [Column("TaxFDescription")]
    [StringLength(59)]
    [Unicode(false)]
    public string? TaxFdescription { get; set; }

    [Column("iTaxTypeG")]
    public int? ITaxTypeG { get; set; }

    [Column("fTaxTypeGAm")]
    public double? FTaxTypeGam { get; set; }

    [Column("fTaxTypeGTax")]
    public double? FTaxTypeGtax { get; set; }

    [Column("TaxGTotal")]
    public double? TaxGtotal { get; set; }

    [Column("TaxGDescription")]
    [StringLength(59)]
    [Unicode(false)]
    public string? TaxGdescription { get; set; }

    [Column("iTaxTypeH")]
    public int? ITaxTypeH { get; set; }

    [Column("fTaxTypeHAm")]
    public double? FTaxTypeHam { get; set; }

    [Column("fTaxTypeHTax")]
    public double? FTaxTypeHtax { get; set; }

    [Column("TaxHTotal")]
    public double? TaxHtotal { get; set; }

    [Column("TaxHDescription")]
    [StringLength(59)]
    [Unicode(false)]
    public string? TaxHdescription { get; set; }

    [Column("TaxTypeALabel")]
    [StringLength(2)]
    public string? TaxTypeAlabel { get; set; }

    [Column("TaxTypeBLabel")]
    [StringLength(2)]
    public string? TaxTypeBlabel { get; set; }

    [Column("TaxTypeCLabel")]
    [StringLength(2)]
    public string? TaxTypeClabel { get; set; }

    [Column("TaxTypeDLabel")]
    [StringLength(2)]
    public string? TaxTypeDlabel { get; set; }

    [Column("TaxTypeELabel")]
    [StringLength(2)]
    public string? TaxTypeElabel { get; set; }

    [Column("TaxTypeFLabel")]
    [StringLength(2)]
    public string? TaxTypeFlabel { get; set; }

    [Column("TaxTypeGLabel")]
    [StringLength(2)]
    public string? TaxTypeGlabel { get; set; }

    [Column("TaxTypeHLabel")]
    [StringLength(2)]
    public string? TaxTypeHlabel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeviceDate { get; set; }

    [Column("bDocType")]
    public bool BDocType { get; set; }

    [Column("cInvoiceCode")]
    [StringLength(20)]
    public string? CInvoiceCode { get; set; }

    [Column("cInvoiceNumber")]
    [StringLength(20)]
    public string? CInvoiceNumber { get; set; }

    [Column("cTerminalID")]
    [StringLength(20)]
    public string? CTerminalId { get; set; }

    [Column("cFiscalCode")]
    [StringLength(20)]
    public string? CFiscalCode { get; set; }

    [Column("fFiscalTotal")]
    public double? FFiscalTotal { get; set; }

    [Column("cQRCode")]
    public string? CQrcode { get; set; }

    [Column("cVerificationUrl")]
    public string? CVerificationUrl { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvNumber { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? InvDate { get; set; }

    [Column("AccountID")]
    public int? AccountId { get; set; }

    [Column("cAccountName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CAccountName { get; set; }

    [Column("cTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxNumber { get; set; }

    [Column("invdiscAmnt")]
    public double? InvdiscAmnt { get; set; }

    [Column("invtotexcl")]
    public double? Invtotexcl { get; set; }

    public double? InvTotIncl { get; set; }

    public double? InvTotTax { get; set; }

    [Column("ITemsSold")]
    public int? ItemsSold { get; set; }

    [Column("TillID")]
    public int? TillId { get; set; }

    [Column("POSAmntTendered")]
    public double? PosamntTendered { get; set; }

    [Column("POSChange")]
    public double? Poschange { get; set; }

    [Column("AgentID")]
    public int? AgentId { get; set; }

    [Column("cTillCode")]
    [StringLength(11)]
    [Unicode(false)]
    public string CTillCode { get; set; } = null!;

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    public double? TotalTendered { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? FiscalDocType { get; set; }

    public double? SystemTotalA { get; set; }

    public double? SystemTaxA { get; set; }

    public double? SystemTotalB { get; set; }

    public double? SystemTaxB { get; set; }

    public double? SystemTotalC { get; set; }

    public double? SystemTaxC { get; set; }

    public double? SystemTotalD { get; set; }

    public double? SystemTaxD { get; set; }

    public double? SystemTotalE { get; set; }

    public double? SystemTaxE { get; set; }

    public double? SystemTotalF { get; set; }

    public double? SystemTaxF { get; set; }

    public double? SystemTotalG { get; set; }

    public double? SystemTaxG { get; set; }

    public double? SystemTotalH { get; set; }

    public double? SystemTaxH { get; set; }
}
