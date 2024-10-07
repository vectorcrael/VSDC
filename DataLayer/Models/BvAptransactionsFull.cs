using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvAptransactionsFull
{
    public long AutoIdx { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TxDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    public int? AccountLink { get; set; }

    [Column("TrCodeID")]
    public int? TrCodeId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fForeignDebit")]
    public double? FForeignDebit { get; set; }

    [Column("fForeignCredit")]
    public double? FForeignCredit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("TaxTypeID")]
    public int? TaxTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [Column("Order_No")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExtOrderNum { get; set; }

    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    [Column("Tax_Amount")]
    public double? TaxAmount { get; set; }

    [Column("fForeignTax")]
    public double? FForeignTax { get; set; }

    public int? Project { get; set; }

    public double? Outstanding { get; set; }

    [Column("fForeignOutstanding")]
    public double? FForeignOutstanding { get; set; }

    [Column("cAllocs", TypeName = "text")]
    public string? CAllocs { get; set; }

    public int? InvNumKey { get; set; }

    [Column("CRCCheck")]
    public double? Crccheck { get; set; }

    [Column("DTStamp", TypeName = "datetime")]
    public DateTime? Dtstamp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column("iTaxPeriodID")]
    public int? ITaxPeriodId { get; set; }

    [Column("cReference2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference2 { get; set; }

    [Column("iAge")]
    public int? IAge { get; set; }

    [Column("dDateAged", TypeName = "datetime")]
    public DateTime? DDateAged { get; set; }

    [Column("iPostSettlementTermsID")]
    public int IPostSettlementTermsId { get; set; }

    [Column("PostAP_iBranchID")]
    public int? PostApIBranchId { get; set; }

    [Column("PostAP_dCreatedDate", TypeName = "datetime")]
    public DateTime? PostApDCreatedDate { get; set; }

    [Column("PostAP_dModifiedDate", TypeName = "datetime")]
    public DateTime? PostApDModifiedDate { get; set; }

    [Column("PostAP_iCreatedBranchID")]
    public int? PostApICreatedBranchId { get; set; }

    [Column("PostAP_iModifiedBranchID")]
    public int? PostApIModifiedBranchId { get; set; }

    [Column("PostAP_iCreatedAgentID")]
    public int? PostApICreatedAgentId { get; set; }

    [Column("PostAP_iModifiedAgentID")]
    public int? PostApIModifiedAgentId { get; set; }

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

    [Column("PostAP_iChangeSetID")]
    public int? PostApIChangeSetId { get; set; }

    [Column("bPBTPaid")]
    public bool BPbtpaid { get; set; }

    [Column("iGLTaxAccountID")]
    public int? IGltaxAccountId { get; set; }

    [Column("bTxOnHold")]
    public bool BTxOnHold { get; set; }

    [Column("PostAP_Checksum")]
    [MaxLength(20)]
    public byte[]? PostApChecksum { get; set; }

    [Unicode(false)]
    public string? SagePayExtra1 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra2 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra3 { get; set; }

    [Column("iTaxBadDebtState")]
    public int ITaxBadDebtState { get; set; }

    [Column("bReverseChargeApplied")]
    public bool BReverseChargeApplied { get; set; }

    [Column("bReverseChargeCustoms")]
    public bool BReverseChargeCustoms { get; set; }

    [Column("cReverseChargeAuditNr")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReverseChargeAuditNr { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    public bool? ActiveProject { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TrCode { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDescription { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencySymbol { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SettlementTerm { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SettlementTermDescription { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string SettlementTermPayMethod { get; set; } = null!;

    public int? SettlementTermDays { get; set; }

    public double? SettlementTermDisc { get; set; }

    [Column("GLTaxAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? GltaxAccount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TxBranchCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TxBranchDescription { get; set; }

    [Column("iStateID")]
    public int? IStateId { get; set; }
}
