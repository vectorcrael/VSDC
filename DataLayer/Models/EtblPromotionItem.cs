using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPromotionItem")]
[Index("EtblPromotionItemChecksum", Name = "idx__etblPromotionItem__etblPromotionItem_Checksum")]
[Index("EtblPromotionItemDModifiedDate", Name = "idx__etblPromotionItem__etblPromotionItem_dModifiedDate")]
[Index("EtblPromotionItemIBranchId", Name = "idx__etblPromotionItem__etblPromotionItem_iBranchID")]
[Index("EtblPromotionItemIChangeSetId", Name = "idx__etblPromotionItem__etblPromotionItem_iChangeSetID")]
public partial class EtblPromotionItem
{
    [Key]
    [Column("iPromotionItemID")]
    public int IPromotionItemId { get; set; }

    [Column("iPromotionItemListID")]
    public int? IPromotionItemListId { get; set; }

    public int? StockLink { get; set; }

    [Column("cItemGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CItemGroup { get; set; }

    [Column("_etblPromotionItem_iBranchID")]
    public int? EtblPromotionItemIBranchId { get; set; }

    [Column("_etblPromotionItem_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionItemDCreatedDate { get; set; }

    [Column("_etblPromotionItem_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionItemDModifiedDate { get; set; }

    [Column("_etblPromotionItem_iCreatedBranchID")]
    public int? EtblPromotionItemICreatedBranchId { get; set; }

    [Column("_etblPromotionItem_iModifiedBranchID")]
    public int? EtblPromotionItemIModifiedBranchId { get; set; }

    [Column("_etblPromotionItem_iCreatedAgentID")]
    public int? EtblPromotionItemICreatedAgentId { get; set; }

    [Column("_etblPromotionItem_iModifiedAgentID")]
    public int? EtblPromotionItemIModifiedAgentId { get; set; }

    [Column("_etblPromotionItem_iChangeSetID")]
    public int? EtblPromotionItemIChangeSetId { get; set; }

    [Column("iTriggerQTY")]
    public int? ITriggerQty { get; set; }

    [Column("iQualifyingQTY")]
    public int? IQualifyingQty { get; set; }

    [Column("iUOMID")]
    public int? IUomid { get; set; }

    [Column("iPriority")]
    public int? IPriority { get; set; }

    [Column("_etblPromotionItem_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPromotionItemChecksum { get; set; }
}
