using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_oldPeriod")]
[Index("OldPeriodDModifiedDate", Name = "idxPeriod_dModifiedDate")]
[Index("OldPeriodIBranchId", Name = "idxPeriod_iBranchID")]
[Index("OldPeriodIChangeSetId", Name = "idx_Period_iChangeSetID")]
public partial class OldPeriod
{
    [Key]
    public short Per { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PerDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Blocked { get; set; }

    [Column("_oldPeriod_iBranchID")]
    public int? OldPeriodIBranchId { get; set; }

    [Column("_oldPeriod_dCreatedDate", TypeName = "datetime")]
    public DateTime? OldPeriodDCreatedDate { get; set; }

    [Column("_oldPeriod_dModifiedDate", TypeName = "datetime")]
    public DateTime? OldPeriodDModifiedDate { get; set; }

    [Column("_oldPeriod_iCreatedBranchID")]
    public int? OldPeriodICreatedBranchId { get; set; }

    [Column("_oldPeriod_iModifiedBranchID")]
    public int? OldPeriodIModifiedBranchId { get; set; }

    [Column("_oldPeriod_iCreatedAgentID")]
    public int? OldPeriodICreatedAgentId { get; set; }

    [Column("_oldPeriod_iModifiedAgentID")]
    public int? OldPeriodIModifiedAgentId { get; set; }

    [Column("_oldPeriod_iChangeSetID")]
    public int? OldPeriodIChangeSetId { get; set; }

    [Column("bPBT")]
    public bool BPbt { get; set; }
}
