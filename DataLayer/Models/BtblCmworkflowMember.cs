using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCMWorkflowMembers")]
[Index("BtblCmworkflowMembersChecksum", Name = "idx__btblCMWorkflowMembers__btblCMWorkflowMembers_Checksum")]
[Index("BtblCmworkflowMembersIChangeSetId", Name = "idx__btblCMWorkflowMembers_iChangeSetID")]
[Index("BtblCmworkflowMembersDModifiedDate", Name = "idx_btblCMWorkflowMembers_dModifiedDate")]
[Index("BtblCmworkflowMembersIBranchId", Name = "idx_btblCMWorkflowMembers_iBranchID")]
public partial class BtblCmworkflowMember
{
    [Key]
    [Column("idWorkflowMembers")]
    public int IdWorkflowMembers { get; set; }

    [Column("iWorkflowID")]
    public int IWorkflowId { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("cAgentType")]
    [StringLength(1)]
    [Unicode(false)]
    public string CAgentType { get; set; } = null!;

    [Column("iWorkflowStatusID")]
    public int IWorkflowStatusId { get; set; }

    [Column("iSequenceNo")]
    public int ISequenceNo { get; set; }

    [Column("bAllowReject")]
    public bool BAllowReject { get; set; }

    [Column("bAllowCloseAfterReject")]
    public bool BAllowCloseAfterReject { get; set; }

    [Column("iEscGroupID")]
    public int? IEscGroupId { get; set; }

    [Column("bOverrideAutoAssign")]
    public bool BOverrideAutoAssign { get; set; }

    [Column("bPOApprove")]
    public bool BPoapprove { get; set; }

    [Column("bPOCancelonReject")]
    public bool BPocancelonReject { get; set; }

    [Column("iPOCancelReasonID")]
    public int? IPocancelReasonId { get; set; }

    [Column("_btblCMWorkflowMembers_iBranchID")]
    public int? BtblCmworkflowMembersIBranchId { get; set; }

    [Column("_btblCMWorkflowMembers_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCmworkflowMembersDCreatedDate { get; set; }

    [Column("_btblCMWorkflowMembers_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCmworkflowMembersDModifiedDate { get; set; }

    [Column("_btblCMWorkflowMembers_iCreatedBranchID")]
    public int? BtblCmworkflowMembersICreatedBranchId { get; set; }

    [Column("_btblCMWorkflowMembers_iModifiedBranchID")]
    public int? BtblCmworkflowMembersIModifiedBranchId { get; set; }

    [Column("_btblCMWorkflowMembers_iCreatedAgentID")]
    public int? BtblCmworkflowMembersICreatedAgentId { get; set; }

    [Column("_btblCMWorkflowMembers_iModifiedAgentID")]
    public int? BtblCmworkflowMembersIModifiedAgentId { get; set; }

    [Column("_btblCMWorkflowMembers_iChangeSetID")]
    public int? BtblCmworkflowMembersIChangeSetId { get; set; }

    [Column("_btblCMWorkflowMembers_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCmworkflowMembersChecksum { get; set; }

    [InverseProperty("IWorkflowMember")]
    public virtual ICollection<RfqWorkflowLink> RfqWorkflowLinks { get; set; } = new List<RfqWorkflowLink>();
}
