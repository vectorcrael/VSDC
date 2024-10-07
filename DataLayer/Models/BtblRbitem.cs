using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("IFolderId", "IItemType", "CItemName", "DModified")]
[Table("_btblRBItem")]
[Index("BtblRbitemChecksum", Name = "idx__btblRBItem__btblRBItem_Checksum")]
[Index("BtblRbitemIChangeSetId", Name = "idx__btblRBItem_iChangeSetID")]
[Index("BtblRbitemDModifiedDate", Name = "idx_btblRBItem_dModifiedDate")]
[Index("BtblRbitemIBranchId", Name = "idx_btblRBItem_iBranchID")]
public partial class BtblRbitem
{
    public int IdItem { get; set; }

    [Key]
    [Column("iFolderId")]
    public int IFolderId { get; set; }

    [Key]
    [Column("cItemName")]
    [StringLength(60)]
    [Unicode(false)]
    public string CItemName { get; set; } = null!;

    [Column("iItemSize")]
    public int? IItemSize { get; set; }

    [Key]
    [Column("iItemType")]
    public int IItemType { get; set; }

    [Key]
    [Column("dModified", TypeName = "datetime")]
    public DateTime DModified { get; set; }

    [Column("dDeleted", TypeName = "datetime")]
    public DateTime? DDeleted { get; set; }

    [Column("imgTemplate", TypeName = "image")]
    public byte[]? ImgTemplate { get; set; }

    [Column("_btblRBItem_iBranchID")]
    public int? BtblRbitemIBranchId { get; set; }

    [Column("_btblRBItem_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblRbitemDCreatedDate { get; set; }

    [Column("_btblRBItem_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblRbitemDModifiedDate { get; set; }

    [Column("_btblRBItem_iCreatedBranchID")]
    public int? BtblRbitemICreatedBranchId { get; set; }

    [Column("_btblRBItem_iModifiedBranchID")]
    public int? BtblRbitemIModifiedBranchId { get; set; }

    [Column("_btblRBItem_iCreatedAgentID")]
    public int? BtblRbitemICreatedAgentId { get; set; }

    [Column("_btblRBItem_iModifiedAgentID")]
    public int? BtblRbitemIModifiedAgentId { get; set; }

    [Column("_btblRBItem_iChangeSetID")]
    public int? BtblRbitemIChangeSetId { get; set; }

    [Column("_btblRBItem_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblRbitemChecksum { get; set; }
}
