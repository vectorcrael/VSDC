using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblARAPBatchLines")]
[Index("EtblArapbatchLinesChecksum", Name = "idx__etblARAPBatchLines__etblARAPBatchLines_Checksum")]
[Index("EtblArapbatchLinesIChangeSetId", Name = "idx__etblARAPBatchLines_iChangeSetID")]
[Index("EtblArapbatchLinesDModifiedDate", Name = "idx_etblARAPBatchLines_dModifiedDate")]
[Index("EtblArapbatchLinesIBranchId", Name = "idx_etblARAPBatchLines_iBranchID")]
public partial class EtblArapbatchLine
{
    [Key]
    [Column("idARAPBatchLines")]
    public int IdArapbatchLines { get; set; }

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
    [StringLength(100)]
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

    [Column("_etblARAPBatchLines_iBranchID")]
    public int? EtblArapbatchLinesIBranchId { get; set; }

    [Column("_etblARAPBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchLinesDCreatedDate { get; set; }

    [Column("_etblARAPBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblArapbatchLinesDModifiedDate { get; set; }

    [Column("_etblARAPBatchLines_iCreatedBranchID")]
    public int? EtblArapbatchLinesICreatedBranchId { get; set; }

    [Column("_etblARAPBatchLines_iModifiedBranchID")]
    public int? EtblArapbatchLinesIModifiedBranchId { get; set; }

    [Column("_etblARAPBatchLines_iCreatedAgentID")]
    public int? EtblArapbatchLinesICreatedAgentId { get; set; }

    [Column("_etblARAPBatchLines_iModifiedAgentID")]
    public int? EtblArapbatchLinesIModifiedAgentId { get; set; }

    [Column("_etblARAPBatchLines_iChangeSetID")]
    public int? EtblArapbatchLinesIChangeSetId { get; set; }

    [Column("iModule")]
    public int? IModule { get; set; }

    [Column("iTaxAccountID")]
    public int? ITaxAccountId { get; set; }

    [Column("bIsDebit")]
    public bool BIsDebit { get; set; }

    [Column("iMBPropertyID")]
    public int? IMbpropertyId { get; set; }

    [Column("iMBPortionID")]
    public int? IMbportionId { get; set; }

    [Column("iMBServiceID")]
    public int? IMbserviceId { get; set; }

    [Column("iMBPropertyPortionServiceID")]
    public int? IMbpropertyPortionServiceId { get; set; }

    [Column("_etblARAPBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblArapbatchLinesChecksum { get; set; }

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
