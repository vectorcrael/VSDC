using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("PostAR")]
[Index("CAuditNumber", Name = "idxAuditNumber")]
[Index("PostArDModifiedDate", Name = "idxPostAR_dModifiedDate")]
[Index("PostArIBranchId", Name = "idxPostAR_iBranchID")]
[Index("ITxBranchId", Name = "idxPostAR_iTxBranchID")]
[Index("PostArChecksum", Name = "idx_PostAR_PostAR_Checksum")]
[Index("PostArIChangeSetId", Name = "idx_PostAR_iChangeSetID")]
public partial class PostAr
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

    [Column("RepID")]
    public int? RepId { get; set; }

    public int? LinkAccCode { get; set; }

    [Column("TillID")]
    public int? TillId { get; set; }

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

    [Column("fJCRepCost")]
    public double? FJcrepCost { get; set; }

    [Column("iAge")]
    public int? IAge { get; set; }

    [Column("dDateAged", TypeName = "datetime")]
    public DateTime? DDateAged { get; set; }

    [Column("iPostSettlementTermsID")]
    public int IPostSettlementTermsId { get; set; }

    [Column("PostAR_iBranchID")]
    public int? PostArIBranchId { get; set; }

    [Column("PostAR_dCreatedDate", TypeName = "datetime")]
    public DateTime? PostArDCreatedDate { get; set; }

    [Column("PostAR_dModifiedDate", TypeName = "datetime")]
    public DateTime? PostArDModifiedDate { get; set; }

    [Column("PostAR_iCreatedBranchID")]
    public int? PostArICreatedBranchId { get; set; }

    [Column("PostAR_iModifiedBranchID")]
    public int? PostArIModifiedBranchId { get; set; }

    [Column("PostAR_iCreatedAgentID")]
    public int? PostArICreatedAgentId { get; set; }

    [Column("PostAR_iModifiedAgentID")]
    public int? PostArIModifiedAgentId { get; set; }

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

    [Column("PostAR_iChangeSetID")]
    public int? PostArIChangeSetId { get; set; }

    [Column("iMBPropertyID")]
    public int IMbpropertyId { get; set; }

    [Column("iMBPortionID")]
    public int IMbportionId { get; set; }

    [Column("iMBServiceID")]
    public int IMbserviceId { get; set; }

    [Column("iMBMeterID")]
    public int IMbmeterId { get; set; }

    [Column("iMBPropertyPortionServiceID")]
    public int IMbpropertyPortionServiceId { get; set; }

    [Column("bPBTPaid")]
    public bool BPbtpaid { get; set; }

    [Column("iGLTaxAccountID")]
    public int? IGltaxAccountId { get; set; }

    [Column("iTransactionType")]
    public int ITransactionType { get; set; }

    [Column("PostAR_Checksum")]
    [MaxLength(20)]
    public byte[]? PostArChecksum { get; set; }

    [Unicode(false)]
    public string? SagePayExtra1 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra2 { get; set; }

    [Unicode(false)]
    public string? SagePayExtra3 { get; set; }

    [Column("iTaxBadDebtState")]
    public int ITaxBadDebtState { get; set; }
}
