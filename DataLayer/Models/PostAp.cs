using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("PostAP")]
[Index("CAuditNumber", Name = "idxAuditNumber")]
[Index("PostApDModifiedDate", Name = "idxPostAP_dModifiedDate")]
[Index("PostApIBranchId", Name = "idxPostAP_iBranchID")]
[Index("ITxBranchId", Name = "idxPostAP_iTxBranchID")]
[Index("PostApChecksum", Name = "idx_PostAP_PostAP_Checksum")]
[Index("PostApIChangeSetId", Name = "idx_PostAP_iChangeSetID")]
public partial class PostAp
{
    [Key]
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
}
