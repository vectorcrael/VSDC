using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPromotionItemListQTY")]
[Index("EtblPromotionItemListQtyChecksum", Name = "idx__etblPromotionItemListQTY__etblPromotionItemListQTY_Checksum")]
[Index("EtblPromotionItemListQtyDModifiedDate", Name = "idx__etblPromotionItemListQTY__etblPromotionItemListQTY_dModifiedDate")]
[Index("EtblPromotionItemListQtyIBranchId", Name = "idx__etblPromotionItemListQTY__etblPromotionItemListQTY_iBranchID")]
[Index("EtblPromotionItemListQtyIChangeSetId", Name = "idx__etblPromotionItemListQTY__etblPromotionItemListQTY_iChangeSetID")]
public partial class EtblPromotionItemListQty
{
    [Key]
    [Column("iPromotionItemListQTYID")]
    public int IPromotionItemListQtyid { get; set; }

    [Column("iPromotionItemListLinkID")]
    public int? IPromotionItemListLinkId { get; set; }

    [Column("fDiscountValue")]
    public double? FDiscountValue { get; set; }

    [Column("iValueType")]
    public int? IValueType { get; set; }

    [Column("fTriggerQTY")]
    public double? FTriggerQty { get; set; }

    [Column("fQualifyingQTY")]
    public double? FQualifyingQty { get; set; }

    [Column("_etblPromotionItemListQTY_iBranchID")]
    public int? EtblPromotionItemListQtyIBranchId { get; set; }

    [Column("_etblPromotionItemListQTY_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionItemListQtyDCreatedDate { get; set; }

    [Column("_etblPromotionItemListQTY_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionItemListQtyDModifiedDate { get; set; }

    [Column("_etblPromotionItemListQTY_iCreatedBranchID")]
    public int? EtblPromotionItemListQtyICreatedBranchId { get; set; }

    [Column("_etblPromotionItemListQTY_iModifiedBranchID")]
    public int? EtblPromotionItemListQtyIModifiedBranchId { get; set; }

    [Column("_etblPromotionItemListQTY_iCreatedAgentID")]
    public int? EtblPromotionItemListQtyICreatedAgentId { get; set; }

    [Column("_etblPromotionItemListQTY_iModifiedAgentID")]
    public int? EtblPromotionItemListQtyIModifiedAgentId { get; set; }

    [Column("_etblPromotionItemListQTY_iChangeSetID")]
    public int? EtblPromotionItemListQtyIChangeSetId { get; set; }

    [Column("_etblPromotionItemListQTY_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPromotionItemListQtyChecksum { get; set; }
}
