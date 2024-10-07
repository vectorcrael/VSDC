using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblSystemFunction")]
[Index("BtblSystemFunctionChecksum", Name = "idx__btblSystemFunction__btblSystemFunction_Checksum")]
[Index("BtblSystemFunctionIChangeSetId", Name = "idx__btblSystemFunction_iChangeSetID")]
[Index("BtblSystemFunctionDModifiedDate", Name = "idx_btblSystemFunction_dModifiedDate")]
[Index("BtblSystemFunctionIBranchId", Name = "idx_btblSystemFunction_iBranchID")]
public partial class BtblSystemFunction
{
    [Key]
    [Column("idSystemFunction")]
    public int IdSystemFunction { get; set; }

    [Column("cFunctionDesc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CFunctionDesc { get; set; }

    [Column("iParentSystemFunctionID")]
    public int? IParentSystemFunctionId { get; set; }

    [Column("iModulesHi")]
    public int? IModulesHi { get; set; }

    [Column("iModulesLo")]
    public int? IModulesLo { get; set; }

    [Column("bIsBusinessRule")]
    public bool BIsBusinessRule { get; set; }

    [Column("bCanDelete")]
    public bool BCanDelete { get; set; }

    [Column("bIsSystemRule")]
    public bool BIsSystemRule { get; set; }

    [Column("_btblSystemFunction_iBranchID")]
    public int? BtblSystemFunctionIBranchId { get; set; }

    [Column("_btblSystemFunction_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblSystemFunctionDCreatedDate { get; set; }

    [Column("_btblSystemFunction_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblSystemFunctionDModifiedDate { get; set; }

    [Column("_btblSystemFunction_iCreatedBranchID")]
    public int? BtblSystemFunctionICreatedBranchId { get; set; }

    [Column("_btblSystemFunction_iModifiedBranchID")]
    public int? BtblSystemFunctionIModifiedBranchId { get; set; }

    [Column("_btblSystemFunction_iCreatedAgentID")]
    public int? BtblSystemFunctionICreatedAgentId { get; set; }

    [Column("_btblSystemFunction_iModifiedAgentID")]
    public int? BtblSystemFunctionIModifiedAgentId { get; set; }

    [Column("_btblSystemFunction_iChangeSetID")]
    public int? BtblSystemFunctionIChangeSetId { get; set; }

    [Column("iAppID")]
    public int? IAppId { get; set; }

    [Column("gIdentifier")]
    public Guid? GIdentifier { get; set; }

    [Column("_btblSystemFunction_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblSystemFunctionChecksum { get; set; }
}
