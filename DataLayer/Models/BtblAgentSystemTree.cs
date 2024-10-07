using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblAgentSystemTree")]
[Index("BtblAgentSystemTreeChecksum", Name = "idx__btblAgentSystemTree__btblAgentSystemTree_Checksum")]
[Index("BtblAgentSystemTreeIChangeSetId", Name = "idx__btblAgentSystemTree_iChangeSetID")]
[Index("BtblAgentSystemTreeDModifiedDate", Name = "idx_btblAgentSystemTree_dModifiedDate")]
[Index("BtblAgentSystemTreeIBranchId", Name = "idx_btblAgentSystemTree_iBranchID")]
public partial class BtblAgentSystemTree
{
    [Key]
    [Column("idAgentSystemTree")]
    public int IdAgentSystemTree { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("cAgentType")]
    [StringLength(1)]
    [Unicode(false)]
    public string CAgentType { get; set; } = null!;

    [Column("iSystemTreeID")]
    public int ISystemTreeId { get; set; }

    [Column("iParentAgentSystemTreeID")]
    public int IParentAgentSystemTreeId { get; set; }

    [Column("iOrder")]
    public int IOrder { get; set; }

    [Column("cDescription")]
    [StringLength(64)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cToolbar")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CToolbar { get; set; }

    [Column("cMenu")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CMenu { get; set; }

    [Column("cMenuName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CMenuName { get; set; }

    [Column("bMenuSub")]
    public bool BMenuSub { get; set; }

    [Column("_btblAgentSystemTree_iBranchID")]
    public int? BtblAgentSystemTreeIBranchId { get; set; }

    [Column("_btblAgentSystemTree_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblAgentSystemTreeDCreatedDate { get; set; }

    [Column("_btblAgentSystemTree_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblAgentSystemTreeDModifiedDate { get; set; }

    [Column("_btblAgentSystemTree_iCreatedBranchID")]
    public int? BtblAgentSystemTreeICreatedBranchId { get; set; }

    [Column("_btblAgentSystemTree_iModifiedBranchID")]
    public int? BtblAgentSystemTreeIModifiedBranchId { get; set; }

    [Column("_btblAgentSystemTree_iCreatedAgentID")]
    public int? BtblAgentSystemTreeICreatedAgentId { get; set; }

    [Column("_btblAgentSystemTree_iModifiedAgentID")]
    public int? BtblAgentSystemTreeIModifiedAgentId { get; set; }

    [Column("_btblAgentSystemTree_iChangeSetID")]
    public int? BtblAgentSystemTreeIChangeSetId { get; set; }

    [Column("_btblAgentSystemTree_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblAgentSystemTreeChecksum { get; set; }
}
