using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblIncidentCat")]
[Index("RtblIncidentCatChecksum", Name = "idx__rtblIncidentCat__rtblIncidentCat_Checksum")]
[Index("RtblIncidentCatIChangeSetId", Name = "idx__rtblIncidentCat_iChangeSetID")]
[Index("RtblIncidentCatDModifiedDate", Name = "idx_rtblIncidentCat_dModifiedDate")]
[Index("RtblIncidentCatIBranchId", Name = "idx_rtblIncidentCat_iBranchID")]
public partial class RtblIncidentCat
{
    [Key]
    [Column("idIncidentCat")]
    public int IdIncidentCat { get; set; }

    [Column("cDescription")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_rtblIncidentCat_iBranchID")]
    public int? RtblIncidentCatIBranchId { get; set; }

    [Column("_rtblIncidentCat_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentCatDCreatedDate { get; set; }

    [Column("_rtblIncidentCat_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblIncidentCatDModifiedDate { get; set; }

    [Column("_rtblIncidentCat_iCreatedBranchID")]
    public int? RtblIncidentCatICreatedBranchId { get; set; }

    [Column("_rtblIncidentCat_iModifiedBranchID")]
    public int? RtblIncidentCatIModifiedBranchId { get; set; }

    [Column("_rtblIncidentCat_iCreatedAgentID")]
    public int? RtblIncidentCatICreatedAgentId { get; set; }

    [Column("_rtblIncidentCat_iModifiedAgentID")]
    public int? RtblIncidentCatIModifiedAgentId { get; set; }

    [Column("_rtblIncidentCat_iChangeSetID")]
    public int? RtblIncidentCatIChangeSetId { get; set; }

    [Column("_rtblIncidentCat_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblIncidentCatChecksum { get; set; }
}
