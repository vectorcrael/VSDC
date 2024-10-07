using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPromotion")]
[Index("EtblPromotionChecksum", Name = "idx__etblPromotion__etblPromotion_Checksum")]
[Index("EtblPromotionDModifiedDate", Name = "idx__etblPromotion__etblPromotion_dModifiedDate")]
[Index("EtblPromotionIBranchId", Name = "idx__etblPromotion__etblPromotion_iBranchID")]
[Index("EtblPromotionIChangeSetId", Name = "idx__etblPromotion__etblPromotion_iChangeSetID")]
public partial class EtblPromotion
{
    [Key]
    [Column("iPromotionID")]
    public int IPromotionId { get; set; }

    [Column("cPromotionCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string CPromotionCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iTriggerQTY")]
    public int? ITriggerQty { get; set; }

    [Column("iQualifyingQTY")]
    public int? IQualifyingQty { get; set; }

    [Column("fDiscount")]
    public double? FDiscount { get; set; }

    [Column("fFixedPrice")]
    public double? FFixedPrice { get; set; }

    [Column("dStartDate", TypeName = "datetime")]
    public DateTime? DStartDate { get; set; }

    [Column("dEndDate", TypeName = "datetime")]
    public DateTime? DEndDate { get; set; }

    [Column("bProportion")]
    public bool? BProportion { get; set; }

    [Column("_etblPromotion_iBranchID")]
    public int? EtblPromotionIBranchId { get; set; }

    [Column("_etblPromotion_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionDCreatedDate { get; set; }

    [Column("_etblPromotion_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionDModifiedDate { get; set; }

    [Column("_etblPromotion_iCreatedBranchID")]
    public int? EtblPromotionICreatedBranchId { get; set; }

    [Column("_etblPromotion_iModifiedBranchID")]
    public int? EtblPromotionIModifiedBranchId { get; set; }

    [Column("_etblPromotion_iCreatedAgentID")]
    public int? EtblPromotionICreatedAgentId { get; set; }

    [Column("_etblPromotion_iModifiedAgentID")]
    public int? EtblPromotionIModifiedAgentId { get; set; }

    [Column("_etblPromotion_iChangeSetID")]
    public int? EtblPromotionIChangeSetId { get; set; }

    [Column("bLimit")]
    public bool BLimit { get; set; }

    [Column("iLimitQTY")]
    public int? ILimitQty { get; set; }

    [Column("iPromotionType")]
    public int IPromotionType { get; set; }

    [Column("fTriggerValue")]
    public double? FTriggerValue { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("iTriggerUOM")]
    public int? ITriggerUom { get; set; }

    [Column("iQualifyingUOM")]
    public int? IQualifyingUom { get; set; }

    [Column("iCustomerType")]
    public int? ICustomerType { get; set; }

    [Column("bInclusive")]
    public bool BInclusive { get; set; }

    [Column("_etblPromotion_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPromotionChecksum { get; set; }
}
