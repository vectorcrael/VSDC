using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblOpportunityStatus")]
[Index("RtblOpportunityStatusChecksum", Name = "idx__rtblOpportunityStatus__rtblOpportunityStatus_Checksum")]
[Index("RtblOpportunityStatusIChangeSetId", Name = "idx__rtblOpportunityStatus_iChangeSetID")]
[Index("RtblOpportunityStatusDModifiedDate", Name = "idx_rtblOpportunityStatus_dModifiedDate")]
[Index("RtblOpportunityStatusIBranchId", Name = "idx_rtblOpportunityStatus_iBranchID")]
public partial class RtblOpportunityStatus
{
    [Key]
    [Column("IDOpportunityStatus")]
    public int IdopportunityStatus { get; set; }

    [Column("cStatusName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CStatusName { get; set; }

    [Column("bFinal")]
    public bool BFinal { get; set; }

    [Column("_rtblOpportunityStatus_iBranchID")]
    public int? RtblOpportunityStatusIBranchId { get; set; }

    [Column("_rtblOpportunityStatus_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityStatusDCreatedDate { get; set; }

    [Column("_rtblOpportunityStatus_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunityStatusDModifiedDate { get; set; }

    [Column("_rtblOpportunityStatus_iCreatedBranchID")]
    public int? RtblOpportunityStatusICreatedBranchId { get; set; }

    [Column("_rtblOpportunityStatus_iModifiedBranchID")]
    public int? RtblOpportunityStatusIModifiedBranchId { get; set; }

    [Column("_rtblOpportunityStatus_iCreatedAgentID")]
    public int? RtblOpportunityStatusICreatedAgentId { get; set; }

    [Column("_rtblOpportunityStatus_iModifiedAgentID")]
    public int? RtblOpportunityStatusIModifiedAgentId { get; set; }

    [Column("_rtblOpportunityStatus_iChangeSetID")]
    public int? RtblOpportunityStatusIChangeSetId { get; set; }

    [Column("_rtblOpportunityStatus_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblOpportunityStatusChecksum { get; set; }
}
