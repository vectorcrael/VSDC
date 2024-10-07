using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_wtblMapIPadUserToInvCount")]
[Index("WtblMapIpadUserToInvCountChecksum", Name = "idx__wtblMapIPadUserToInvCount__wtblMapIPadUserToInvCount_Checksum")]
[Index("WtblMapIpadUserToInvCountDModifiedDate", Name = "idx__wtblMapIPadUserToInvCount__wtblMapIPadUserToInvCount_dModifiedDate")]
[Index("WtblMapIpadUserToInvCountIBranchId", Name = "idx__wtblMapIPadUserToInvCount__wtblMapIPadUserToInvCount_iBranchID")]
[Index("WtblMapIpadUserToInvCountIChangeSetId", Name = "idx__wtblMapIPadUserToInvCount__wtblMapIPadUserToInvCount_iChangeSetID")]
public partial class WtblMapIpadUserToInvCount
{
    [Key]
    [Column("idIPadInvCount")]
    public int IdIpadInvCount { get; set; }

    [Column("iIPadUserId")]
    public long IIpadUserId { get; set; }

    [Column("iInvCountID")]
    public int IInvCountId { get; set; }

    [Column("iStatusId")]
    public int? IStatusId { get; set; }

    [Column("_wtblMapIPadUserToInvCount_iBranchID")]
    public int? WtblMapIpadUserToInvCountIBranchId { get; set; }

    [Column("_wtblMapIPadUserToInvCount_dCreatedDate", TypeName = "datetime")]
    public DateTime? WtblMapIpadUserToInvCountDCreatedDate { get; set; }

    [Column("_wtblMapIPadUserToInvCount_dModifiedDate", TypeName = "datetime")]
    public DateTime? WtblMapIpadUserToInvCountDModifiedDate { get; set; }

    [Column("_wtblMapIPadUserToInvCount_iCreatedBranchID")]
    public int? WtblMapIpadUserToInvCountICreatedBranchId { get; set; }

    [Column("_wtblMapIPadUserToInvCount_iModifiedBranchID")]
    public int? WtblMapIpadUserToInvCountIModifiedBranchId { get; set; }

    [Column("_wtblMapIPadUserToInvCount_iCreatedAgentID")]
    public int? WtblMapIpadUserToInvCountICreatedAgentId { get; set; }

    [Column("_wtblMapIPadUserToInvCount_iModifiedAgentID")]
    public int? WtblMapIpadUserToInvCountIModifiedAgentId { get; set; }

    [Column("_wtblMapIPadUserToInvCount_iChangeSetID")]
    public int? WtblMapIpadUserToInvCountIChangeSetId { get; set; }

    [Column("_wtblMapIPadUserToInvCount_Checksum")]
    [MaxLength(20)]
    public byte[]? WtblMapIpadUserToInvCountChecksum { get; set; }
}
