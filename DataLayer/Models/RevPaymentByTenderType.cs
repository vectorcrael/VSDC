using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevPaymentByTenderType
{
    [Column("dTransactionDate", TypeName = "datetime")]
    public DateTime? DTransactionDate { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("idPOSTender")]
    public long IdPostender { get; set; }

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
    public string CEftbudgetPeriod { get; set; } = null!;

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
    public bool BChipCard { get; set; }

    [Column("cEFTReferenceNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEftreferenceNumber { get; set; }

    [Column("bManualEFT")]
    public bool BManualEft { get; set; }

    [Column("_retPOSTender_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPostenderChecksum { get; set; }

    [Column("idTenderType")]
    public int IdTenderType { get; set; }

    [Column("cTenderTypeCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CTenderTypeCode { get; set; }

    [Column("cTenderTypeDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CTenderTypeDesc { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("iDisplayOrder")]
    public int? IDisplayOrder { get; set; }

    [Column("bAllowOverTender")]
    public bool BAllowOverTender { get; set; }

    [Column("bOpenDrawer")]
    public bool BOpenDrawer { get; set; }

    [Column("fHouseLimit")]
    public double? FHouseLimit { get; set; }

    [Column("bRequireNarration")]
    public bool BRequireNarration { get; set; }

    [Column("iReceiptTrCodeID")]
    public int? IReceiptTrCodeId { get; set; }

    [Column("iRefundTrCodeID")]
    public int? IRefundTrCodeId { get; set; }

    [Column("_retTenderType_iBranchID")]
    public int? RetTenderTypeIBranchId { get; set; }

    [Column("_retTenderType_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetTenderTypeDCreatedDate { get; set; }

    [Column("_retTenderType_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetTenderTypeDModifiedDate { get; set; }

    [Column("_retTenderType_iCreatedBranchID")]
    public int? RetTenderTypeICreatedBranchId { get; set; }

    [Column("_retTenderType_iModifiedBranchID")]
    public int? RetTenderTypeIModifiedBranchId { get; set; }

    [Column("_retTenderType_iCreatedAgentID")]
    public int? RetTenderTypeICreatedAgentId { get; set; }

    [Column("_retTenderType_iModifiedAgentID")]
    public int? RetTenderTypeIModifiedAgentId { get; set; }

    [Column("_retTenderType_iChangeSetID")]
    public int? RetTenderTypeIChangeSetId { get; set; }

    [Column("iDepositTrCodeID")]
    public double? IDepositTrCodeId { get; set; }

    [Column("iTypeOfTender")]
    public int? ITypeOfTender { get; set; }

    [Column("iCardDisplayFirst")]
    public int? ICardDisplayFirst { get; set; }

    [Column("iCardDisplayLast")]
    public int? ICardDisplayLast { get; set; }

    [Column("bForceCardNumber")]
    public bool BForceCardNumber { get; set; }

    [Column("bForceCardHolder")]
    public bool BForceCardHolder { get; set; }

    [Column("cExpiryFormat")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CExpiryFormat { get; set; }

    [Column("bForceExpiry")]
    public bool BForceExpiry { get; set; }

    [Column("bUsePinPad")]
    public bool? BUsePinPad { get; set; }

    [Column("bApplyDocketRounding")]
    public bool? BApplyDocketRounding { get; set; }

    [Column("_retTenderType_Checksum")]
    [MaxLength(20)]
    public byte[]? RetTenderTypeChecksum { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? InvNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DeliveryNote { get; set; }

    [Column("DocRepID")]
    public int? DocRepId { get; set; }

    [Column("cRepName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CRepName { get; set; }

    public double? SaleAmount { get; set; }

    public double? ReturnAmount { get; set; }

    [Column("cTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocRef { get; set; }

    [Column("iTillID")]
    public int? ITillId { get; set; }
}
