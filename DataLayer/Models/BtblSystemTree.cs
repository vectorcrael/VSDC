using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblSystemTree")]
[Index("BtblSystemTreeChecksum", Name = "idx__btblSystemTree__btblSystemTree_Checksum")]
[Index("BtblSystemTreeIChangeSetId", Name = "idx__btblSystemTree_iChangeSetID")]
[Index("BtblSystemTreeDModifiedDate", Name = "idx_btblSystemTree_dModifiedDate")]
[Index("BtblSystemTreeIBranchId", Name = "idx_btblSystemTree_iBranchID")]
public partial class BtblSystemTree
{
    [Key]
    [Column("idSystemTree")]
    public int IdSystemTree { get; set; }

    [Column("iModuleLo")]
    public int? IModuleLo { get; set; }

    [Column("iModuleHi")]
    public int? IModuleHi { get; set; }

    [Column("iForceModulesLo")]
    public int? IForceModulesLo { get; set; }

    [Column("iForceModulesHi")]
    public int? IForceModulesHi { get; set; }

    [Column("mDisableForModulesLo")]
    public int? MDisableForModulesLo { get; set; }

    [Column("mDisableForModulesHi")]
    public int? MDisableForModulesHi { get; set; }

    [Column("iOrder")]
    public int IOrder { get; set; }

    [Column("cPackage")]
    [StringLength(32)]
    [Unicode(false)]
    public string CPackage { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(64)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iType")]
    public int IType { get; set; }

    [Column("cObject")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CObject { get; set; }

    [Column("cCommand")]
    [StringLength(256)]
    [Unicode(false)]
    public string? CCommand { get; set; }

    [Column("bAlwaysLoad")]
    public bool BAlwaysLoad { get; set; }

    [Column("cToolbar")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CToolbar { get; set; }

    [Column("cMenu")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CMenu { get; set; }

    [Column("cMenuName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CMenuName { get; set; }

    [Column("bMenuSub")]
    public bool BMenuSub { get; set; }

    [Column("bHideNoChild")]
    public bool BHideNoChild { get; set; }

    [Column("bAllowDesign")]
    public bool BAllowDesign { get; set; }

    [Column("bAdminOnly")]
    public bool BAdminOnly { get; set; }

    [Column("bSysNode")]
    public bool BSysNode { get; set; }

    [Column("bExcludeBranches")]
    public bool BExcludeBranches { get; set; }

    [Column("_btblSystemTree_iBranchID")]
    public int? BtblSystemTreeIBranchId { get; set; }

    [Column("_btblSystemTree_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblSystemTreeDCreatedDate { get; set; }

    [Column("_btblSystemTree_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblSystemTreeDModifiedDate { get; set; }

    [Column("_btblSystemTree_iCreatedBranchID")]
    public int? BtblSystemTreeICreatedBranchId { get; set; }

    [Column("_btblSystemTree_iModifiedBranchID")]
    public int? BtblSystemTreeIModifiedBranchId { get; set; }

    [Column("_btblSystemTree_iCreatedAgentID")]
    public int? BtblSystemTreeICreatedAgentId { get; set; }

    [Column("_btblSystemTree_iModifiedAgentID")]
    public int? BtblSystemTreeIModifiedAgentId { get; set; }

    [Column("_btblSystemTree_iChangeSetID")]
    public int? BtblSystemTreeIChangeSetId { get; set; }

    [Column("iAppID")]
    public int? IAppId { get; set; }

    [Column("gIdentifier")]
    public Guid? GIdentifier { get; set; }

    [Column("_btblSystemTree_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblSystemTreeChecksum { get; set; }

    [Column("bEvolutionHandled")]
    public int? BEvolutionHandled { get; set; }
}
