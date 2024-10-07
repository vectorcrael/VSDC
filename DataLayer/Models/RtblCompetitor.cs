using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblCompetitor")]
[Index("RtblCompetitorChecksum", Name = "idx__rtblCompetitor__rtblCompetitor_Checksum")]
[Index("RtblCompetitorIChangeSetId", Name = "idx__rtblCompetitor_iChangeSetID")]
[Index("RtblCompetitorDModifiedDate", Name = "idx_rtblCompetitor_dModifiedDate")]
[Index("RtblCompetitorIBranchId", Name = "idx_rtblCompetitor_iBranchID")]
public partial class RtblCompetitor
{
    [Key]
    [Column("idCompetitor")]
    public int IdCompetitor { get; set; }

    [Column("cCompanyName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCompanyName { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_rtblCompetitor_iBranchID")]
    public int? RtblCompetitorIBranchId { get; set; }

    [Column("_rtblCompetitor_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblCompetitorDCreatedDate { get; set; }

    [Column("_rtblCompetitor_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblCompetitorDModifiedDate { get; set; }

    [Column("_rtblCompetitor_iCreatedBranchID")]
    public int? RtblCompetitorICreatedBranchId { get; set; }

    [Column("_rtblCompetitor_iModifiedBranchID")]
    public int? RtblCompetitorIModifiedBranchId { get; set; }

    [Column("_rtblCompetitor_iCreatedAgentID")]
    public int? RtblCompetitorICreatedAgentId { get; set; }

    [Column("_rtblCompetitor_iModifiedAgentID")]
    public int? RtblCompetitorIModifiedAgentId { get; set; }

    [Column("_rtblCompetitor_iChangeSetID")]
    public int? RtblCompetitorIChangeSetId { get; set; }

    [Column("_rtblCompetitor_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblCompetitorChecksum { get; set; }
}
