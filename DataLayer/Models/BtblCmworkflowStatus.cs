using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCMWorkflowStatus")]
[Index("BtblCmworkflowStatusChecksum", Name = "idx__btblCMWorkflowStatus__btblCMWorkflowStatus_Checksum")]
[Index("BtblCmworkflowStatusIChangeSetId", Name = "idx__btblCMWorkflowStatus_iChangeSetID")]
[Index("BtblCmworkflowStatusDModifiedDate", Name = "idx_btblCMWorkflowStatus_dModifiedDate")]
[Index("BtblCmworkflowStatusIBranchId", Name = "idx_btblCMWorkflowStatus_iBranchID")]
public partial class BtblCmworkflowStatus
{
    [Key]
    [Column("idWorkflowStatus")]
    public int IdWorkflowStatus { get; set; }

    [Column("cStatusCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string CStatusCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_btblCMWorkflowStatus_iBranchID")]
    public int? BtblCmworkflowStatusIBranchId { get; set; }

    [Column("_btblCMWorkflowStatus_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCmworkflowStatusDCreatedDate { get; set; }

    [Column("_btblCMWorkflowStatus_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCmworkflowStatusDModifiedDate { get; set; }

    [Column("_btblCMWorkflowStatus_iCreatedBranchID")]
    public int? BtblCmworkflowStatusICreatedBranchId { get; set; }

    [Column("_btblCMWorkflowStatus_iModifiedBranchID")]
    public int? BtblCmworkflowStatusIModifiedBranchId { get; set; }

    [Column("_btblCMWorkflowStatus_iCreatedAgentID")]
    public int? BtblCmworkflowStatusICreatedAgentId { get; set; }

    [Column("_btblCMWorkflowStatus_iModifiedAgentID")]
    public int? BtblCmworkflowStatusIModifiedAgentId { get; set; }

    [Column("_btblCMWorkflowStatus_iChangeSetID")]
    public int? BtblCmworkflowStatusIChangeSetId { get; set; }

    [Column("_btblCMWorkflowStatus_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCmworkflowStatusChecksum { get; set; }
}
