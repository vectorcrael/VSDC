using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("WHT_State")]
[Index("WhtStateChecksum", Name = "idx_WHT_State_WHT_State_Checksum")]
[Index("WhtStateDModifiedDate", Name = "idx_WHT_State_WHT_State_dModifiedDate")]
[Index("WhtStateIBranchId", Name = "idx_WHT_State_WHT_State_iBranchID")]
[Index("WhtStateIChangeSetId", Name = "idx_WHT_State_WHT_State_iChangeSetID")]
public partial class WhtState
{
    [StringLength(2)]
    public string? State { get; set; }

    [StringLength(30)]
    public string? Description { get; set; }

    [Column("WHT_State_iBranchID")]
    public int? WhtStateIBranchId { get; set; }

    [Column("WHT_State_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhtStateDCreatedDate { get; set; }

    [Column("WHT_State_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhtStateDModifiedDate { get; set; }

    [Column("WHT_State_iCreatedBranchID")]
    public int? WhtStateICreatedBranchId { get; set; }

    [Column("WHT_State_iModifiedBranchID")]
    public int? WhtStateIModifiedBranchId { get; set; }

    [Column("WHT_State_iCreatedAgentID")]
    public int? WhtStateICreatedAgentId { get; set; }

    [Column("WHT_State_iModifiedAgentID")]
    public int? WhtStateIModifiedAgentId { get; set; }

    [Column("WHT_State_iChangeSetID")]
    public int? WhtStateIChangeSetId { get; set; }

    [Column("WHT_State_Checksum")]
    [MaxLength(20)]
    public byte[]? WhtStateChecksum { get; set; }
}
