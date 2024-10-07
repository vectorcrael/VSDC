using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPromotionItemListLink")]
[Index("EtblPromotionItemListLinkChecksum", Name = "idx__etblPromotionItemListLink__etblPromotionItemListLink_Checksum")]
[Index("EtblPromotionItemListLinkDModifiedDate", Name = "idx__etblPromotionItemListLink__etblPromotionItemListLink_dModifiedDate")]
[Index("EtblPromotionItemListLinkIBranchId", Name = "idx__etblPromotionItemListLink__etblPromotionItemListLink_iBranchID")]
[Index("EtblPromotionItemListLinkIChangeSetId", Name = "idx__etblPromotionItemListLink__etblPromotionItemListLink_iChangeSetID")]
public partial class EtblPromotionItemListLink
{
    [Key]
    [Column("iPromotionItemListLinkID")]
    public int IPromotionItemListLinkId { get; set; }

    [Column("iPromotionID")]
    public int? IPromotionId { get; set; }

    [Column("iPromotionItemListID")]
    public int? IPromotionItemListId { get; set; }

    [Column("_etblPromotionItemListLink_iBranchID")]
    public int? EtblPromotionItemListLinkIBranchId { get; set; }

    [Column("_etblPromotionItemListLink_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionItemListLinkDCreatedDate { get; set; }

    [Column("_etblPromotionItemListLink_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPromotionItemListLinkDModifiedDate { get; set; }

    [Column("_etblPromotionItemListLink_iCreatedBranchID")]
    public int? EtblPromotionItemListLinkICreatedBranchId { get; set; }

    [Column("_etblPromotionItemListLink_iModifiedBranchID")]
    public int? EtblPromotionItemListLinkIModifiedBranchId { get; set; }

    [Column("_etblPromotionItemListLink_iCreatedAgentID")]
    public int? EtblPromotionItemListLinkICreatedAgentId { get; set; }

    [Column("_etblPromotionItemListLink_iModifiedAgentID")]
    public int? EtblPromotionItemListLinkIModifiedAgentId { get; set; }

    [Column("_etblPromotionItemListLink_iChangeSetID")]
    public int? EtblPromotionItemListLinkIChangeSetId { get; set; }

    [Column("bLimit")]
    public bool BLimit { get; set; }

    [Column("iLimitQTY")]
    public int? ILimitQty { get; set; }

    [Column("bMultiBuy")]
    public bool BMultiBuy { get; set; }

    [Column("_etblPromotionItemListLink_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPromotionItemListLinkChecksum { get; set; }
}
