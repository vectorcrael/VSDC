using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCMWorkflow")]
[Index("BtblCmworkflowChecksum", Name = "idx__btblCMWorkflow__btblCMWorkflow_Checksum")]
[Index("BtblCmworkflowIChangeSetId", Name = "idx__btblCMWorkflow_iChangeSetID")]
[Index("BtblCmworkflowDModifiedDate", Name = "idx_btblCMWorkflow_dModifiedDate")]
[Index("BtblCmworkflowIBranchId", Name = "idx_btblCMWorkflow_iBranchID")]
public partial class BtblCmworkflow
{
    [Key]
    [Column("idWorkflow")]
    public int IdWorkflow { get; set; }

    [Column("cName")]
    [StringLength(30)]
    [Unicode(false)]
    public string CName { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bPOWorkflow")]
    public bool BPoworkflow { get; set; }

    [Column("_btblCMWorkflow_iBranchID")]
    public int? BtblCmworkflowIBranchId { get; set; }

    [Column("_btblCMWorkflow_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCmworkflowDCreatedDate { get; set; }

    [Column("_btblCMWorkflow_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCmworkflowDModifiedDate { get; set; }

    [Column("_btblCMWorkflow_iCreatedBranchID")]
    public int? BtblCmworkflowICreatedBranchId { get; set; }

    [Column("_btblCMWorkflow_iModifiedBranchID")]
    public int? BtblCmworkflowIModifiedBranchId { get; set; }

    [Column("_btblCMWorkflow_iCreatedAgentID")]
    public int? BtblCmworkflowICreatedAgentId { get; set; }

    [Column("_btblCMWorkflow_iModifiedAgentID")]
    public int? BtblCmworkflowIModifiedAgentId { get; set; }

    [Column("_btblCMWorkflow_iChangeSetID")]
    public int? BtblCmworkflowIChangeSetId { get; set; }

    [Column("_btblCMWorkflow_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCmworkflowChecksum { get; set; }
}
