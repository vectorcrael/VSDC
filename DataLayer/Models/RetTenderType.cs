using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retTenderType")]
[Index("RetTenderTypeChecksum", Name = "idx__retTenderType__retTenderType_Checksum")]
[Index("RetTenderTypeIChangeSetId", Name = "idx__retTenderType_iChangeSetID")]
[Index("RetTenderTypeDModifiedDate", Name = "idx_retTenderType_dModifiedDate")]
[Index("RetTenderTypeIBranchId", Name = "idx_retTenderType_iBranchID")]
public partial class RetTenderType
{
    [Key]
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
}
