using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvAutoLevelUpdateItem
{
    [Column("idAutolevelUpdateItem")]
    public int IdAutolevelUpdateItem { get; set; }

    [Column("iItemID")]
    public int IItemId { get; set; }

    [Column("cItemType")]
    [StringLength(1)]
    [Unicode(false)]
    public string CItemType { get; set; } = null!;

    [Column("iNoOfDays")]
    public int? INoOfDays { get; set; }

    [Column("bUseAveragePerDay")]
    public bool BUseAveragePerDay { get; set; }

    [Column("iCat1From")]
    public int? ICat1From { get; set; }

    [Column("iCat1To")]
    public int? ICat1To { get; set; }

    [Column("fCat1NewReOrderQty")]
    public double? FCat1NewReOrderQty { get; set; }

    [Column("fCat1NewReOrderLvl")]
    public double? FCat1NewReOrderLvl { get; set; }

    [Column("iCat2From")]
    public int? ICat2From { get; set; }

    [Column("iCat2To")]
    public int? ICat2To { get; set; }

    [Column("fCat2NewReOrderQty")]
    public double? FCat2NewReOrderQty { get; set; }

    [Column("fCat2NewReOrderLvl")]
    public double? FCat2NewReOrderLvl { get; set; }

    [Column("iCat3From")]
    public int? ICat3From { get; set; }

    [Column("iCat3To")]
    public int? ICat3To { get; set; }

    [Column("fCat3NewReOrderQty")]
    public double? FCat3NewReOrderQty { get; set; }

    [Column("fCat3NewReOrderLvl")]
    public double? FCat3NewReOrderLvl { get; set; }

    [Column("fCat1NewMinReOrderLvl")]
    public double? FCat1NewMinReOrderLvl { get; set; }

    [Column("fCat2NewMinReOrderLvl")]
    public double? FCat2NewMinReOrderLvl { get; set; }

    [Column("fCat3NewMinReOrderLvl")]
    public double? FCat3NewMinReOrderLvl { get; set; }

    [Column("_etblAutoLevelUpdateItem_iBranchID")]
    public int? EtblAutoLevelUpdateItemIBranchId { get; set; }

    [Column("_etblAutoLevelUpdateItem_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAutoLevelUpdateItemDCreatedDate { get; set; }

    [Column("_etblAutoLevelUpdateItem_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAutoLevelUpdateItemDModifiedDate { get; set; }

    [Column("_etblAutoLevelUpdateItem_iCreatedBranchID")]
    public int? EtblAutoLevelUpdateItemICreatedBranchId { get; set; }

    [Column("_etblAutoLevelUpdateItem_iModifiedBranchID")]
    public int? EtblAutoLevelUpdateItemIModifiedBranchId { get; set; }

    [Column("_etblAutoLevelUpdateItem_iCreatedAgentID")]
    public int? EtblAutoLevelUpdateItemICreatedAgentId { get; set; }

    [Column("_etblAutoLevelUpdateItem_iModifiedAgentID")]
    public int? EtblAutoLevelUpdateItemIModifiedAgentId { get; set; }

    [Column("_etblAutoLevelUpdateItem_iChangeSetID")]
    public int? EtblAutoLevelUpdateItemIChangeSetId { get; set; }

    [Column("_etblAutoLevelUpdateItem_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAutoLevelUpdateItemChecksum { get; set; }

    [Column("cItemCode")]
    [StringLength(400)]
    [Unicode(false)]
    public string? CItemCode { get; set; }

    [Column("cItemDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CItemDescription { get; set; }

    [Column("cFullItemType")]
    [StringLength(5)]
    [Unicode(false)]
    public string CFullItemType { get; set; } = null!;
}
