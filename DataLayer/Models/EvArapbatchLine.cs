using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvArapbatchLine
{
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

    [StringLength(2)]
    [Unicode(false)]
    public string? Module { get; set; }

    [Column("fDebitExcl")]
    public double? FDebitExcl { get; set; }

    [Column("fCreditExcl")]
    public double? FCreditExcl { get; set; }

    [Column("fTaxAmount")]
    public double? FTaxAmount { get; set; }

    [Column("fDebitIncl")]
    public double? FDebitIncl { get; set; }

    [Column("fCreditIncl")]
    public double? FCreditIncl { get; set; }

    [Column("fDebitExclForeign")]
    public double? FDebitExclForeign { get; set; }

    [Column("fCreditExclForeign")]
    public double? FCreditExclForeign { get; set; }

    [Column("fTaxAmountForeign")]
    public double? FTaxAmountForeign { get; set; }

    [Column("fDebitInclForeign")]
    public double? FDebitInclForeign { get; set; }

    [Column("fCreditInclForeign")]
    public double? FCreditInclForeign { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TrCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TrCodeDescription { get; set; }

    public bool? TrCodeIsDebit { get; set; }

    [Column("ContraGLMasterSubAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? ContraGlmasterSubAccount { get; set; }

    [Column("ContraGLAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? ContraGlaccount { get; set; }

    [Column("ContraGLDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? ContraGldescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TaxTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxTypeDescription { get; set; }

    [Column("DiscContraGLMasterSubAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? DiscContraGlmasterSubAccount { get; set; }

    [Column("DiscContraGLAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? DiscContraGlaccount { get; set; }

    [Column("DiscContraGLDescription")]
    [StringLength(255)]
    [Unicode(false)]
    public string? DiscContraGldescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DiscTaxTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DiscTaxTypeDescription { get; set; }

    public int? ProjectLink { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    public bool? ActiveProject { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(41)]
    [Unicode(false)]
    public string? MasterSubProject { get; set; }

    public int? ProjectLevel { get; set; }

    public int? SubProjectOfLink { get; set; }

    [Column("Project_iBranchID")]
    public int? ProjectIBranchId { get; set; }

    [Column("Project_dCreatedDate", TypeName = "datetime")]
    public DateTime? ProjectDCreatedDate { get; set; }

    [Column("Project_dModifiedDate", TypeName = "datetime")]
    public DateTime? ProjectDModifiedDate { get; set; }

    [Column("Project_iCreatedBranchID")]
    public int? ProjectICreatedBranchId { get; set; }

    [Column("Project_iModifiedBranchID")]
    public int? ProjectIModifiedBranchId { get; set; }

    [Column("Project_iCreatedAgentID")]
    public int? ProjectICreatedAgentId { get; set; }

    [Column("Project_iModifiedAgentID")]
    public int? ProjectIModifiedAgentId { get; set; }

    [Column("Project_iChangeSetID")]
    public int? ProjectIChangeSetId { get; set; }

    [Column("Project_Checksum")]
    [MaxLength(20)]
    public byte[]? ProjectChecksum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RepName { get; set; }

    [Column("GLTaxAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? GltaxAccount { get; set; }
}
