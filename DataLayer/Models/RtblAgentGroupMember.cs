using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("IGroupId", "IAgentId")]
[Table("_rtblAgentGroupMembers")]
[Index("RtblAgentGroupMembersChecksum", Name = "idx__rtblAgentGroupMembers__rtblAgentGroupMembers_Checksum")]
[Index("RtblAgentGroupMembersIChangeSetId", Name = "idx__rtblAgentGroupMembers_iChangeSetID")]
[Index("RtblAgentGroupMembersDModifiedDate", Name = "idx_rtblAgentGroupMembers_dModifiedDate")]
[Index("RtblAgentGroupMembersIBranchId", Name = "idx_rtblAgentGroupMembers_iBranchID")]
public partial class RtblAgentGroupMember
{
    [Key]
    [Column("iGroupID")]
    public int IGroupId { get; set; }

    [Key]
    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("bSysGroupMember")]
    public bool BSysGroupMember { get; set; }

    [Column("_rtblAgentGroupMembers_iBranchID")]
    public int? RtblAgentGroupMembersIBranchId { get; set; }

    [Column("_rtblAgentGroupMembers_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblAgentGroupMembersDCreatedDate { get; set; }

    [Column("_rtblAgentGroupMembers_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblAgentGroupMembersDModifiedDate { get; set; }

    [Column("_rtblAgentGroupMembers_iCreatedBranchID")]
    public int? RtblAgentGroupMembersICreatedBranchId { get; set; }

    [Column("_rtblAgentGroupMembers_iModifiedBranchID")]
    public int? RtblAgentGroupMembersIModifiedBranchId { get; set; }

    [Column("_rtblAgentGroupMembers_iCreatedAgentID")]
    public int? RtblAgentGroupMembersICreatedAgentId { get; set; }

    [Column("_rtblAgentGroupMembers_iModifiedAgentID")]
    public int? RtblAgentGroupMembersIModifiedAgentId { get; set; }

    [Column("_rtblAgentGroupMembers_iChangeSetID")]
    public int? RtblAgentGroupMembersIChangeSetId { get; set; }

    [Column("_rtblAgentGroupMembers_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblAgentGroupMembersChecksum { get; set; }
}
