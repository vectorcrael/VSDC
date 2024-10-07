using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Index("AreasDModifiedDate", Name = "idxAreas_dModifiedDate")]
[Index("AreasIBranchId", Name = "idxAreas_iBranchID")]
[Index("AreasChecksum", Name = "idx_Areas_Areas_Checksum")]
[Index("AreasIChangeSetId", Name = "idx_Areas_iChangeSetID")]
public partial class Area
{
    [Key]
    [Column("idAreas")]
    public int IdAreas { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Areas_iBranchID")]
    public int? AreasIBranchId { get; set; }

    [Column("Areas_dCreatedDate", TypeName = "datetime")]
    public DateTime? AreasDCreatedDate { get; set; }

    [Column("Areas_dModifiedDate", TypeName = "datetime")]
    public DateTime? AreasDModifiedDate { get; set; }

    [Column("Areas_iCreatedBranchID")]
    public int? AreasICreatedBranchId { get; set; }

    [Column("Areas_iModifiedBranchID")]
    public int? AreasIModifiedBranchId { get; set; }

    [Column("Areas_iCreatedAgentID")]
    public int? AreasICreatedAgentId { get; set; }

    [Column("Areas_iModifiedAgentID")]
    public int? AreasIModifiedAgentId { get; set; }

    [Column("Areas_iChangeSetID")]
    public int? AreasIChangeSetId { get; set; }

    [Column("Areas_Checksum")]
    [MaxLength(20)]
    public byte[]? AreasChecksum { get; set; }
}
