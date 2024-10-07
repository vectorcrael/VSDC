using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("IAgentId", "CAgentType", "ISystemFunctionId")]
[Table("_btblAgentSystemFunctions")]
[Index("BtblAgentSystemFunctionsChecksum", Name = "idx__btblAgentSystemFunctions__btblAgentSystemFunctions_Checksum")]
[Index("BtblAgentSystemFunctionsIChangeSetId", Name = "idx__btblAgentSystemFunctions_iChangeSetID")]
[Index("BtblAgentSystemFunctionsDModifiedDate", Name = "idx_btblAgentSystemFunctions_dModifiedDate")]
[Index("BtblAgentSystemFunctionsIBranchId", Name = "idx_btblAgentSystemFunctions_iBranchID")]
public partial class BtblAgentSystemFunction
{
    [Key]
    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Key]
    [Column("cAgentType")]
    [StringLength(1)]
    [Unicode(false)]
    public string CAgentType { get; set; } = null!;

    [Key]
    [Column("iSystemFunctionID")]
    public int ISystemFunctionId { get; set; }

    [Column("iReadAccess")]
    public int? IReadAccess { get; set; }

    [Column("iEditAccess")]
    public int? IEditAccess { get; set; }

    [Column("iAddAccess")]
    public int? IAddAccess { get; set; }

    [Column("iDeleteAccess")]
    public int? IDeleteAccess { get; set; }

    [Column("iRuleAccess")]
    public int? IRuleAccess { get; set; }

    [Column("_btblAgentSystemFunctions_iBranchID")]
    public int? BtblAgentSystemFunctionsIBranchId { get; set; }

    [Column("_btblAgentSystemFunctions_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblAgentSystemFunctionsDCreatedDate { get; set; }

    [Column("_btblAgentSystemFunctions_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblAgentSystemFunctionsDModifiedDate { get; set; }

    [Column("_btblAgentSystemFunctions_iCreatedBranchID")]
    public int? BtblAgentSystemFunctionsICreatedBranchId { get; set; }

    [Column("_btblAgentSystemFunctions_iModifiedBranchID")]
    public int? BtblAgentSystemFunctionsIModifiedBranchId { get; set; }

    [Column("_btblAgentSystemFunctions_iCreatedAgentID")]
    public int? BtblAgentSystemFunctionsICreatedAgentId { get; set; }

    [Column("_btblAgentSystemFunctions_iModifiedAgentID")]
    public int? BtblAgentSystemFunctionsIModifiedAgentId { get; set; }

    [Column("_btblAgentSystemFunctions_iChangeSetID")]
    public int? BtblAgentSystemFunctionsIChangeSetId { get; set; }

    [Column("_btblAgentSystemFunctions_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblAgentSystemFunctionsChecksum { get; set; }
}
