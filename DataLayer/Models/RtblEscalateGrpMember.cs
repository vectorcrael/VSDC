using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblEscalateGrpMembers")]
[Index("IdEscalateGrpMembers", Name = "IX__rtblEscalateGrpMembers", IsUnique = true)]
[Index("RtblEscalateGrpMembersChecksum", Name = "idx__rtblEscalateGrpMembers__rtblEscalateGrpMembers_Checksum")]
[Index("RtblEscalateGrpMembersIChangeSetId", Name = "idx__rtblEscalateGrpMembers_iChangeSetID")]
[Index("RtblEscalateGrpMembersDModifiedDate", Name = "idx_rtblEscalateGrpMembers_dModifiedDate")]
[Index("RtblEscalateGrpMembersIBranchId", Name = "idx_rtblEscalateGrpMembers_iBranchID")]
public partial class RtblEscalateGrpMember
{
    [Key]
    [Column("idEscalateGrpMembers")]
    public int IdEscalateGrpMembers { get; set; }

    [Column("iEscalateGrpID")]
    public int IEscalateGrpId { get; set; }

    [Column("iAgentGroupID")]
    public int IAgentGroupId { get; set; }

    [Column("iSequence")]
    public int ISequence { get; set; }

    [Column("iEscalateMins")]
    public int IEscalateMins { get; set; }

    [Column("_rtblEscalateGrpMembers_iBranchID")]
    public int? RtblEscalateGrpMembersIBranchId { get; set; }

    [Column("_rtblEscalateGrpMembers_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblEscalateGrpMembersDCreatedDate { get; set; }

    [Column("_rtblEscalateGrpMembers_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblEscalateGrpMembersDModifiedDate { get; set; }

    [Column("_rtblEscalateGrpMembers_iCreatedBranchID")]
    public int? RtblEscalateGrpMembersICreatedBranchId { get; set; }

    [Column("_rtblEscalateGrpMembers_iModifiedBranchID")]
    public int? RtblEscalateGrpMembersIModifiedBranchId { get; set; }

    [Column("_rtblEscalateGrpMembers_iCreatedAgentID")]
    public int? RtblEscalateGrpMembersICreatedAgentId { get; set; }

    [Column("_rtblEscalateGrpMembers_iModifiedAgentID")]
    public int? RtblEscalateGrpMembersIModifiedAgentId { get; set; }

    [Column("_rtblEscalateGrpMembers_iChangeSetID")]
    public int? RtblEscalateGrpMembersIChangeSetId { get; set; }

    [Column("_rtblEscalateGrpMembers_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblEscalateGrpMembersChecksum { get; set; }
}
