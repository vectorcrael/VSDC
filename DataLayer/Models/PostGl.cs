using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("PostGL")]
[Index("CAuditNumber", Name = "idxAuditNumber")]
[Index("PostGlDModifiedDate", Name = "idxPostGL_dModifiedDate")]
[Index("PostGlIBranchId", Name = "idxPostGL_iBranchID")]
[Index("ITxBranchId", Name = "idxPostGL_iTxBranchID")]
[Index("PostGlChecksum", Name = "idx_PostGL_PostGL_Checksum")]
[Index("PostGlIChangeSetId", Name = "idx_PostGL_iChangeSetID")]
public partial class PostGl
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

    public int? Period { get; set; }

    public int? DrCrAccount { get; set; }

    public int? JobCodeLink { get; set; }

    [Column("CRCCheck")]
    public double? Crccheck { get; set; }

    [Column("DTStamp", TypeName = "datetime")]
    public DateTime? Dtstamp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column("iTaxPeriodID")]
    public int? ITaxPeriodId { get; set; }

    [Column("cPayeeName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CPayeeName { get; set; }

    [Column("bPrintCheque")]
    public bool BPrintCheque { get; set; }

    [Column("cReference2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference2 { get; set; }

    [Column("RepID")]
    public int? RepId { get; set; }

    [Column("fJCRepCost")]
    public double? FJcrepCost { get; set; }

    [Column("iMFPID")]
    public int? IMfpid { get; set; }

    [Column("bIsJCDocLine")]
    public bool BIsJcdocLine { get; set; }

    [Column("bIsSTGLDocLine")]
    public bool BIsStgldocLine { get; set; }

    [Column("iInvLineID")]
    public long IInvLineId { get; set; }

    [Column("PostGL_iBranchID")]
    public int? PostGlIBranchId { get; set; }

    [Column("PostGL_dCreatedDate", TypeName = "datetime")]
    public DateTime? PostGlDCreatedDate { get; set; }

    [Column("PostGL_dModifiedDate", TypeName = "datetime")]
    public DateTime? PostGlDModifiedDate { get; set; }

    [Column("PostGL_iCreatedBranchID")]
    public int? PostGlICreatedBranchId { get; set; }

    [Column("PostGL_iModifiedBranchID")]
    public int? PostGlIModifiedBranchId { get; set; }

    [Column("PostGL_iCreatedAgentID")]
    public int? PostGlICreatedAgentId { get; set; }

    [Column("PostGL_iModifiedAgentID")]
    public int? PostGlIModifiedAgentId { get; set; }

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

    [Column("PostGL_iChangeSetID")]
    public int? PostGlIChangeSetId { get; set; }

    [Column("cBankRef")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CBankRef { get; set; }

    [Column("bPBTPaid")]
    public bool BPbtpaid { get; set; }

    [Column("iGLTaxAccountID")]
    public int? IGltaxAccountId { get; set; }

    [Column("bReconciled")]
    public bool BReconciled { get; set; }

    [Column("PostGL_Checksum")]
    [MaxLength(20)]
    public byte[]? PostGlChecksum { get; set; }

    [Column("iImportDeclarationID")]
    public int? IImportDeclarationId { get; set; }
}
