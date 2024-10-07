using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCmworkflowMember
{
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

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cStatusCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CStatusCode { get; set; }

    [Column("cStatusDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CStatusDescription { get; set; }

    [Column("cEscGroupDescription")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CEscGroupDescription { get; set; }
}
