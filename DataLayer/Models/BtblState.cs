using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblState")]
[Index("BtblStateChecksum", Name = "idx__btblState__btblState_Checksum")]
[Index("BtblStateIChangeSetId", Name = "idx__btblState_iChangeSetID")]
[Index("BtblStateDModifiedDate", Name = "idx_btblState_dModifiedDate")]
[Index("BtblStateIBranchId", Name = "idx_btblState_iBranchID")]
public partial class BtblState
{
    [Key]
    [Column("idState")]
    public int IdState { get; set; }

    [Column("cStateCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string CStateCode { get; set; } = null!;

    [Column("cStateDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CStateDescription { get; set; }

    [Column("_btblState_iBranchID")]
    public int? BtblStateIBranchId { get; set; }

    [Column("_btblState_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblStateDCreatedDate { get; set; }

    [Column("_btblState_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblStateDModifiedDate { get; set; }

    [Column("_btblState_iCreatedBranchID")]
    public int? BtblStateICreatedBranchId { get; set; }

    [Column("_btblState_iModifiedBranchID")]
    public int? BtblStateIModifiedBranchId { get; set; }

    [Column("_btblState_iCreatedAgentID")]
    public int? BtblStateICreatedAgentId { get; set; }

    [Column("_btblState_iModifiedAgentID")]
    public int? BtblStateIModifiedAgentId { get; set; }

    [Column("_btblState_iChangeSetID")]
    public int? BtblStateIChangeSetId { get; set; }

    [Column("_btblState_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblStateChecksum { get; set; }
}
