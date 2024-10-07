using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPromotionItemList")]
[Index("EtblPromotionItemListChecksum", Name = "idx__etblPromotionItemList__etblPromotionItemList_Checksum")]
[Index("EtblPromotionItemListDModifiedDate", Name = "idx__etblPromotionItemList__etblPromotionItemList_dModifiedDate")]
[Index("EtblPromotionItemListIBranchId", Name = "idx__etblPromotionItemList__etblPromotionItemList_iBranchID")]
[Index("EtblPromotionItemListIChangeSetId", Name = "idx__etblPromotionItemList__etblPromotionItemList_iChangeSetID")]
public partial class EtblPromotionItemList
{
    [Key]
    [Column("iPromotionItemListID")]
    public int IPromotionItemListId { get; set; }

    [Column("iPromotionID")]
    public int? IPromotionId { get; set; }

    [Column("cListCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CListCode { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bTriggerItem")]
    public bool? BTriggerItem { get; set; }

    [Column("bQualifyingItem")]
    public bool? BQualifyingItem { get; set; }

    [Column("_etblPromotionItemList_iBranchID")]
    public int? EtblPromotionItemListIBranchId { get; set; }

    [Column("_etblPromotionItemList_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionItemListDCreatedDate { get; set; }

    [Column("_etblPromotionItemList_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionItemListDModifiedDate { get; set; }

    [Column("_etblPromotionItemList_iCreatedBranchID")]
    public int? EtblPromotionItemListICreatedBranchId { get; set; }

    [Column("_etblPromotionItemList_iModifiedBranchID")]
    public int? EtblPromotionItemListIModifiedBranchId { get; set; }

    [Column("_etblPromotionItemList_iCreatedAgentID")]
    public int? EtblPromotionItemListICreatedAgentId { get; set; }

    [Column("_etblPromotionItemList_iModifiedAgentID")]
    public int? EtblPromotionItemListIModifiedAgentId { get; set; }

    [Column("_etblPromotionItemList_iChangeSetID")]
    public int? EtblPromotionItemListIChangeSetId { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_etblPromotionItemList_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPromotionItemListChecksum { get; set; }
}
