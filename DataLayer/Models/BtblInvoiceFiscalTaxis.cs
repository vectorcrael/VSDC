using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvoiceFiscalTaxes")]
[Index("BtblInvoiceFiscalTaxesChecksum", Name = "idx__btblInvoiceFiscalTaxes__btblInvoiceFiscalTaxes_Checksum")]
[Index("BtblInvoiceFiscalTaxesDModifiedDate", Name = "idx__btblInvoiceFiscalTaxes__btblInvoiceFiscalTaxes_dModifiedDate")]
[Index("BtblInvoiceFiscalTaxesIBranchId", Name = "idx__btblInvoiceFiscalTaxes__btblInvoiceFiscalTaxes_iBranchID")]
[Index("BtblInvoiceFiscalTaxesIChangeSetId", Name = "idx__btblInvoiceFiscalTaxes__btblInvoiceFiscalTaxes_iChangeSetID")]
public partial class BtblInvoiceFiscalTaxis
{
    [Key]
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

    [Column("iTaxTypeB")]
    public int? ITaxTypeB { get; set; }

    [Column("fTaxTypeBAm")]
    public double? FTaxTypeBam { get; set; }

    [Column("fTaxTypeBTax")]
    public double? FTaxTypeBtax { get; set; }

    [Column("iTaxTypeC")]
    public int? ITaxTypeC { get; set; }

    [Column("fTaxTypeCAm")]
    public double? FTaxTypeCam { get; set; }

    [Column("fTaxTypeCTax")]
    public double? FTaxTypeCtax { get; set; }

    [Column("iTaxTypeD")]
    public int? ITaxTypeD { get; set; }

    [Column("fTaxTypeDAm")]
    public double? FTaxTypeDam { get; set; }

    [Column("fTaxTypeDTax")]
    public double? FTaxTypeDtax { get; set; }

    [Column("iTaxTypeE")]
    public int? ITaxTypeE { get; set; }

    [Column("fTaxTypeEAm")]
    public double? FTaxTypeEam { get; set; }

    [Column("fTaxTypeETax")]
    public double? FTaxTypeEtax { get; set; }

    [Column("iTaxTypeF")]
    public int? ITaxTypeF { get; set; }

    [Column("fTaxTypeFAm")]
    public double? FTaxTypeFam { get; set; }

    [Column("fTaxTypeFTax")]
    public double? FTaxTypeFtax { get; set; }

    [Column("cSignatureNormal")]
    [StringLength(1000)]
    public string? CSignatureNormal { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DeviceDateNormalDoc { get; set; }

    [Column("cSignatureCopy")]
    [StringLength(1000)]
    public string? CSignatureCopy { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DeviceDateCopyDoc { get; set; }

    [Column("_btblInvoiceFiscalTaxes_iBranchID")]
    public int? BtblInvoiceFiscalTaxesIBranchId { get; set; }

    [Column("_btblInvoiceFiscalTaxes_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceFiscalTaxesDCreatedDate { get; set; }

    [Column("_btblInvoiceFiscalTaxes_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceFiscalTaxesDModifiedDate { get; set; }

    [Column("_btblInvoiceFiscalTaxes_iCreatedBranchID")]
    public int? BtblInvoiceFiscalTaxesICreatedBranchId { get; set; }

    [Column("_btblInvoiceFiscalTaxes_iModifiedBranchID")]
    public int? BtblInvoiceFiscalTaxesIModifiedBranchId { get; set; }

    [Column("_btblInvoiceFiscalTaxes_iCreatedAgentID")]
    public int? BtblInvoiceFiscalTaxesICreatedAgentId { get; set; }

    [Column("_btblInvoiceFiscalTaxes_iModifiedAgentID")]
    public int? BtblInvoiceFiscalTaxesIModifiedAgentId { get; set; }

    [Column("_btblInvoiceFiscalTaxes_iChangeSetID")]
    public int? BtblInvoiceFiscalTaxesIChangeSetId { get; set; }

    [Column("_btblInvoiceFiscalTaxes_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvoiceFiscalTaxesChecksum { get; set; }

    [Column("bDocType")]
    public bool BDocType { get; set; }

    [Column("cMRCNormalDoc")]
    [StringLength(50)]
    public string? CMrcnormalDoc { get; set; }

    [Column("cMRCCopyDoc")]
    [StringLength(50)]
    public string? CMrccopyDoc { get; set; }

    [Column("iTaxTypeG")]
    public int? ITaxTypeG { get; set; }

    [Column("FTaxTypeGAm")]
    public double? FtaxTypeGam { get; set; }

    [Column("fTaxTypeGTax")]
    public double? FTaxTypeGtax { get; set; }

    [Column("iTaxTypeH")]
    public int? ITaxTypeH { get; set; }

    [Column("FTaxTypeHAm")]
    public double? FtaxTypeHam { get; set; }

    [Column("fTaxTypeHTax")]
    public double? FTaxTypeHtax { get; set; }

    [Column("dTrTime", TypeName = "datetime")]
    public DateTime? DTrTime { get; set; }

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

    [Column("bCreditedInv")]
    public bool? BCreditedInv { get; set; }

    [Column("cTPIN")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTpin { get; set; }

    [Column("cTaxpayerName")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CTaxpayerName { get; set; }

    [Column("cTaxpayerAddress")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CTaxpayerAddress { get; set; }

    [Column("cTelecomOperator")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CTelecomOperator { get; set; }

    [Column("cLPONumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CLponumber { get; set; }

    [Column("iLinkedDocID")]
    public int? ILinkedDocId { get; set; }
}
