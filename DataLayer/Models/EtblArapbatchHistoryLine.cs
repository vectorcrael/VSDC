using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARAPBatchHistoryLines")]
[Index("EtblArapbatchHistoryLinesChecksum", Name = "idx__etblARAPBatchHistoryLines__etblARAPBatchHistoryLines_Checksum")]
[Index("EtblArapbatchHistoryLinesIChangeSetId", Name = "idx__etblARAPBatchHistoryLines_iChangeSetID")]
[Index("EtblArapbatchHistoryLinesDModifiedDate", Name = "idx_etblARAPBatchHistoryLines_dModifiedDate")]
[Index("EtblArapbatchHistoryLinesIBranchId", Name = "idx_etblARAPBatchHistoryLines_iBranchID")]
public partial class EtblArapbatchHistoryLine
{
    [Key]
    [Column("idARAPBatchHistoryLines")]
    public int IdArapbatchHistoryLines { get; set; }

    [Column("iBatchHistoryID")]
    public int? IBatchHistoryId { get; set; }

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("idLinePermanent")]
    public int? IdLinePermanent { get; set; }

    [Column("dTxDate", TypeName = "datetime")]
    public DateTime? DTxDate { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("iAccountCurrencyID")]
    public int? IAccountCurrencyId { get; set; }

    [Column("iTrCodeID")]
    public int? ITrCodeId { get; set; }

    [Column("iGLContraID")]
    public int? IGlcontraId { get; set; }

    [Column("bPostDated")]
    public bool BPostDated { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cOrderNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? COrderNumber { get; set; }

    [Column("fAmountExcl")]
    public double? FAmountExcl { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("fAmountIncl")]
    public double? FAmountIncl { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fAmountExclForeign")]
    public double? FAmountExclForeign { get; set; }

    [Column("fAmountInclForeign")]
    public double? FAmountInclForeign { get; set; }

    [Column("fAccountExchangeRate")]
    public double? FAccountExchangeRate { get; set; }

    [Column("fAccountForeignAmountExcl")]
    public double? FAccountForeignAmountExcl { get; set; }

    [Column("fAccountForeignAmountIncl")]
    public double? FAccountForeignAmountIncl { get; set; }

    [Column("iDiscGLContraID")]
    public int? IDiscGlcontraId { get; set; }

    [Column("fDiscPercent")]
    public double? FDiscPercent { get; set; }

    [Column("fDiscAmountExcl")]
    public double? FDiscAmountExcl { get; set; }

    [Column("iDiscTaxTypeID")]
    public int? IDiscTaxTypeId { get; set; }

    [Column("fDiscAmountIncl")]
    public double? FDiscAmountIncl { get; set; }

    [Column("fDiscAmountExclForeign")]
    public double? FDiscAmountExclForeign { get; set; }

    [Column("fDiscAmountInclForeign")]
    public double? FDiscAmountInclForeign { get; set; }

    [Column("fAccountForeignDiscAmountExcl")]
    public double? FAccountForeignDiscAmountExcl { get; set; }

    [Column("fAccountForeignDiscAmountIncl")]
    public double? FAccountForeignDiscAmountIncl { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iSalesRepID")]
    public int? ISalesRepId { get; set; }

    [Column("iBatchSettlementTermsID")]
    public int IBatchSettlementTermsId { get; set; }

    [Column("_etblARAPBatchHistoryLines_iBranchID")]
    public int? EtblArapbatchHistoryLinesIBranchId { get; set; }

    [Column("_etblARAPBatchHistoryLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchHistoryLinesDCreatedDate { get; set; }

    [Column("_etblARAPBatchHistoryLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchHistoryLinesDModifiedDate { get; set; }

    [Column("_etblARAPBatchHistoryLines_iCreatedBranchID")]
    public int? EtblArapbatchHistoryLinesICreatedBranchId { get; set; }

    [Column("_etblARAPBatchHistoryLines_iModifiedBranchID")]
    public int? EtblArapbatchHistoryLinesIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchHistoryLines_iCreatedAgentID")]
    public int? EtblArapbatchHistoryLinesICreatedAgentId { get; set; }

    [Column("_etblARAPBatchHistoryLines_iModifiedAgentID")]
    public int? EtblArapbatchHistoryLinesIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchHistoryLines_iChangeSetID")]
    public int? EtblArapbatchHistoryLinesIChangeSetId { get; set; }

    [Column("iModule")]
    public int? IModule { get; set; }

    [Column("iTaxAccountID")]
    public int? ITaxAccountId { get; set; }

    [Column("bIsDebit")]
    public bool BIsDebit { get; set; }

    [Column("_etblARAPBatchHistoryLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchHistoryLinesChecksum { get; set; }

    [Column("cTaxCompanyName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CTaxCompanyName { get; set; }

    [Column("cTaxCompanyRegistration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxCompanyRegistration { get; set; }

    [Column("cTaxRegistration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxRegistration { get; set; }
}
