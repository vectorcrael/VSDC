using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblEscalateGrp")]
[Index("RtblEscalateGrpChecksum", Name = "idx__rtblEscalateGrp__rtblEscalateGrp_Checksum")]
[Index("RtblEscalateGrpIChangeSetId", Name = "idx__rtblEscalateGrp_iChangeSetID")]
[Index("RtblEscalateGrpDModifiedDate", Name = "idx_rtblEscalateGrp_dModifiedDate")]
[Index("RtblEscalateGrpIBranchId", Name = "idx_rtblEscalateGrp_iBranchID")]
public partial class RtblEscalateGrp
{
    [Key]
    [Column("idEscalateGrp")]
    public int IdEscalateGrp { get; set; }

    [Column("cDescription")]
    [StringLength(30)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("_rtblEscalateGrp_iBranchID")]
    public int? RtblEscalateGrpIBranchId { get; set; }

    [Column("_rtblEscalateGrp_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblEscalateGrpDCreatedDate { get; set; }

    [Column("_rtblEscalateGrp_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblEscalateGrpDModifiedDate { get; set; }

    [Column("_rtblEscalateGrp_iCreatedBranchID")]
    public int? RtblEscalateGrpICreatedBranchId { get; set; }

    [Column("_rtblEscalateGrp_iModifiedBranchID")]
    public int? RtblEscalateGrpIModifiedBranchId { get; set; }

    [Column("_rtblEscalateGrp_iCreatedAgentID")]
    public int? RtblEscalateGrpICreatedAgentId { get; set; }

    [Column("_rtblEscalateGrp_iModifiedAgentID")]
    public int? RtblEscalateGrpIModifiedAgentId { get; set; }

    [Column("_rtblEscalateGrp_iChangeSetID")]
    public int? RtblEscalateGrpIChangeSetId { get; set; }

    [Column("_rtblEscalateGrp_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblEscalateGrpChecksum { get; set; }
}
