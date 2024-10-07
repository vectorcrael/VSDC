using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPostGLHist")]
[Index("EtblPostGlhistChecksum", Name = "idx__etblPostGLHist__etblPostGLHist_Checksum")]
[Index("EtblPostGlhistDModifiedDate", Name = "idx__etblPostGLHist__etblPostGLHist_dModifiedDate")]
[Index("EtblPostGlhistIBranchId", Name = "idx__etblPostGLHist__etblPostGLHist_iBranchID")]
[Index("EtblPostGlhistIChangeSetId", Name = "idx__etblPostGLHist__etblPostGLHist_iChangeSetID")]
public partial class EtblPostGlhist
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

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

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

    [Column("_etblPostGLHist_iBranchID")]
    public int? EtblPostGlhistIBranchId { get; set; }

    [Column("_etblPostGLHist_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPostGlhistDCreatedDate { get; set; }

    [Column("_etblPostGLHist_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPostGlhistDModifiedDate { get; set; }

    [Column("_etblPostGLHist_iCreatedBranchID")]
    public int? EtblPostGlhistICreatedBranchId { get; set; }

    [Column("_etblPostGLHist_iModifiedBranchID")]
    public int? EtblPostGlhistIModifiedBranchId { get; set; }

    [Column("_etblPostGLHist_iCreatedAgentID")]
    public int? EtblPostGlhistICreatedAgentId { get; set; }

    [Column("_etblPostGLHist_iModifiedAgentID")]
    public int? EtblPostGlhistIModifiedAgentId { get; set; }

    [Column("_etblPostGLHist_iChangeSetID")]
    public int? EtblPostGlhistIChangeSetId { get; set; }

    [Column("_etblPostGLHist_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPostGlhistChecksum { get; set; }

    [Column("iImportDeclarationID")]
    public int? IImportDeclarationId { get; set; }
}
