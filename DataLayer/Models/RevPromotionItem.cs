using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevPromotionItem
{
    [Column("iPromotionItemID")]
    public int IPromotionItemId { get; set; }

    [Column("iPromotionItemListID")]
    public int? IPromotionItemListId { get; set; }

    [Column("iPromotionID")]
    public int? IPromotionId { get; set; }

    public int? StockLink { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("Description_1")]
    [StringLength(400)]
    [Unicode(false)]
    public string? Description1 { get; set; }

    [Column("Description_2")]
    [StringLength(400)]
    [Unicode(false)]
    public string? Description2 { get; set; }

    [Column("Description_3")]
    [StringLength(400)]
    [Unicode(false)]
    public string? Description3 { get; set; }

    [Column("Bar_Code")]
    [StringLength(400)]
    [Unicode(false)]
    public string? BarCode { get; set; }

    [Column("bTriggerItem")]
    public int? BTriggerItem { get; set; }

    [Column("bQualifyingItem")]
    public bool? BQualifyingItem { get; set; }

    public bool? GroupDescription { get; set; }

    [Column("cItemGroup")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CItemGroup { get; set; }

    [Column("iTriggerQTY")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ITriggerQty { get; set; }

    [Column("iQualifyingQTY")]
    public int? IQualifyingQty { get; set; }

    [Column("iUOMID")]
    public int? IUomid { get; set; }

    [Column("iPriority")]
    public int? IPriority { get; set; }

    [Column("iStockingUnit")]
    public int? IStockingUnit { get; set; }

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
}
