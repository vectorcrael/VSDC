using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevPaymentByTenderTypeReport
{
    [Column("dTransactionDate", TypeName = "datetime")]
    public DateTime? DTransactionDate { get; set; }

    [Column("idPOSTender")]
    public long? IdPostender { get; set; }

    [Column("iPOSTransactionID")]
    public long IPostransactionId { get; set; }

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

    [Column("idTenderType")]
    public int? IdTenderType { get; set; }

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

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }

    [Column("iTenderTypeID")]
    public int? ITenderTypeId { get; set; }

    public double? PaymentIn { get; set; }

    public double? PaymentOut { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocRef { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("cTenderTypeCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CTenderTypeCode { get; set; }

    [Column("cTenderTypeDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CTenderTypeDesc { get; set; }

    [Column("bActive")]
    public bool? BActive { get; set; }

    [Column("iDisplayOrder")]
    public int? IDisplayOrder { get; set; }

    [Column("bAllowOverTender")]
    public bool? BAllowOverTender { get; set; }

    [Column("bOpenDrawer")]
    public bool? BOpenDrawer { get; set; }

    [Column("fHouseLimit")]
    public double? FHouseLimit { get; set; }

    [Column("bRequireNarration")]
    public bool? BRequireNarration { get; set; }

    [Column("iReceiptTrCodeID")]
    public int? IReceiptTrCodeId { get; set; }

    [Column("iRefundTrCodeID")]
    public int? IRefundTrCodeId { get; set; }

    [Column("iTypeOfTender")]
    public int? ITypeOfTender { get; set; }

    [Column("iDepositTrCodeID")]
    public double? IDepositTrCodeId { get; set; }

    [Column("_retPOSTransaction_iBranchID")]
    public int? RetPostransactionIBranchId { get; set; }

    [Column("cTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCode { get; set; }

    [Column("cRepName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CRepName { get; set; }

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
}
