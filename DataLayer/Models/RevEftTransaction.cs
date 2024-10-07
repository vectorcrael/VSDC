using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevEftTransaction
{
    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    [Column("idPOSTransaction")]
    public long IdPostransaction { get; set; }

    [Column("idPOSTender")]
    public long? IdPostender { get; set; }

    [Column("iPOSTransactionID")]
    public long? IPostransactionId { get; set; }

    [Column("iTenderTypeID")]
    public int? ITenderTypeId { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("cNarrative")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CNarrative { get; set; }

    [Column("_retPOSTender_iBranchID")]
    public int? RetPostenderIBranchId { get; set; }

    [Column("_retPOSTender_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPostenderDCreatedDate { get; set; }

    [Column("_retPOSTender_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPostenderDModifiedDate { get; set; }

    [Column("_retPOSTender_iCreatedBranchID")]
    public int? RetPostenderICreatedBranchId { get; set; }

    [Column("_retPOSTender_iModifiedBranchID")]
    public int? RetPostenderIModifiedBranchId { get; set; }

    [Column("_retPOSTender_iCreatedAgentID")]
    public int? RetPostenderICreatedAgentId { get; set; }

    [Column("_retPOSTender_iModifiedAgentID")]
    public int? RetPostenderIModifiedAgentId { get; set; }

    [Column("_retPOSTender_iChangeSetID")]
    public int? RetPostenderIChangeSetId { get; set; }

    [Column("cCardNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CCardNumber { get; set; }

    [Column("cCardHolder")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CCardHolder { get; set; }

    [Column("dExpiryDate", TypeName = "datetime")]
    public DateTime? DExpiryDate { get; set; }

    [Column("cEMVApplicationID")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CEmvapplicationId { get; set; }

    [Column("cEMVVerification")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CEmvverification { get; set; }

    [Column("cEMVTrCertificate")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEmvtrCertificate { get; set; }

    [Column("cEMVApplLabel")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEmvapplLabel { get; set; }

    [Column("cCardType")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CCardType { get; set; }

    [Column("cAuthCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CAuthCode { get; set; }

    [Column("dEFTDateTime", TypeName = "datetime")]
    public DateTime? DEftdateTime { get; set; }

    [Column("cEMVTSI")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CEmvtsi { get; set; }

    [Column("idInvoiceDeposits")]
    public int? IdInvoiceDeposits { get; set; }

    [Column("cEFTBudgetPeriod")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CEftbudgetPeriod { get; set; }

    [Column("cAuthorisationID")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CAuthorisationId { get; set; }

    [Column("cInstitutionID")]
    [StringLength(11)]
    [Unicode(false)]
    public string? CInstitutionId { get; set; }

    [Column("cTransactionType")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CTransactionType { get; set; }

    [Column("cAccountType")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CAccountType { get; set; }

    [Column("cE0210RespCode")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CE0210respCode { get; set; }

    [Column("cE0202RespCode")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CE0202respCode { get; set; }

    [Column("bChipCard")]
    public bool? BChipCard { get; set; }

    [Column("cEFTReferenceNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEftreferenceNumber { get; set; }

    [Column("bManualEFT")]
    public bool? BManualEft { get; set; }

    [Column("_retPOSTender_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPostenderChecksum { get; set; }

    [Column("cTenderTypeDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CTenderTypeDesc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("DCBalance")]
    public double? Dcbalance { get; set; }

    [Column("cTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCode { get; set; }

    [Column("idAgents")]
    public int IdAgents { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }
}
