using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblOpportunitySource")]
[Index("RtblOpportunitySourceChecksum", Name = "idx__rtblOpportunitySource__rtblOpportunitySource_Checksum")]
[Index("RtblOpportunitySourceIChangeSetId", Name = "idx__rtblOpportunitySource_iChangeSetID")]
[Index("RtblOpportunitySourceDModifiedDate", Name = "idx_rtblOpportunitySource_dModifiedDate")]
[Index("RtblOpportunitySourceIBranchId", Name = "idx_rtblOpportunitySource_iBranchID")]
public partial class RtblOpportunitySource
{
    [Key]
    [Column("IDOpportunitySource")]
    public int IdopportunitySource { get; set; }

    [Column("cSourceDesc")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSourceDesc { get; set; }

    [Column("_rtblOpportunitySource_iBranchID")]
    public int? RtblOpportunitySourceIBranchId { get; set; }

    [Column("_rtblOpportunitySource_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunitySourceDCreatedDate { get; set; }

    [Column("_rtblOpportunitySource_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblOpportunitySourceDModifiedDate { get; set; }

    [Column("_rtblOpportunitySource_iCreatedBranchID")]
    public int? RtblOpportunitySourceICreatedBranchId { get; set; }

    [Column("_rtblOpportunitySource_iModifiedBranchID")]
    public int? RtblOpportunitySourceIModifiedBranchId { get; set; }

    [Column("_rtblOpportunitySource_iCreatedAgentID")]
    public int? RtblOpportunitySourceICreatedAgentId { get; set; }

    [Column("_rtblOpportunitySource_iModifiedAgentID")]
    public int? RtblOpportunitySourceIModifiedAgentId { get; set; }

    [Column("_rtblOpportunitySource_iChangeSetID")]
    public int? RtblOpportunitySourceIChangeSetId { get; set; }

    [Column("_rtblOpportunitySource_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblOpportunitySourceChecksum { get; set; }
}
