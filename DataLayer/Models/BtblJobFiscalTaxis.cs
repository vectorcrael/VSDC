using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblJobFiscalTaxes")]
[Index("BtblJobFiscalTaxesChecksum", Name = "idx__btblJobFiscalTaxes__btblJobFiscalTaxes_Checksum")]
[Index("BtblJobFiscalTaxesDModifiedDate", Name = "idx__btblJobFiscalTaxes__btblJobFiscalTaxes_dModifiedDate")]
[Index("BtblJobFiscalTaxesIBranchId", Name = "idx__btblJobFiscalTaxes__btblJobFiscalTaxes_iBranchID")]
[Index("BtblJobFiscalTaxesIChangeSetId", Name = "idx__btblJobFiscalTaxes__btblJobFiscalTaxes_iChangeSetID")]
public partial class BtblJobFiscalTaxis
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

    [Column("_btblJobFiscalTaxes_iBranchID")]
    public int? BtblJobFiscalTaxesIBranchId { get; set; }

    [Column("_btblJobFiscalTaxes_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblJobFiscalTaxesDCreatedDate { get; set; }

    [Column("_btblJobFiscalTaxes_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblJobFiscalTaxesDModifiedDate { get; set; }

    [Column("_btblJobFiscalTaxes_iCreatedBranchID")]
    public int? BtblJobFiscalTaxesICreatedBranchId { get; set; }

    [Column("_btblJobFiscalTaxes_iModifiedBranchID")]
    public int? BtblJobFiscalTaxesIModifiedBranchId { get; set; }

    [Column("_btblJobFiscalTaxes_iCreatedAgentID")]
    public int? BtblJobFiscalTaxesICreatedAgentId { get; set; }

    [Column("_btblJobFiscalTaxes_iModifiedAgentID")]
    public int? BtblJobFiscalTaxesIModifiedAgentId { get; set; }

    [Column("_btblJobFiscalTaxes_iChangeSetID")]
    public int? BtblJobFiscalTaxesIChangeSetId { get; set; }

    [Column("_btblJobFiscalTaxes_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblJobFiscalTaxesChecksum { get; set; }

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
