using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("PrintGrp")]
[Index("PrintGrpDModifiedDate", Name = "idxPrintGrp_dModifiedDate")]
[Index("PrintGrpIBranchId", Name = "idxPrintGrp_iBranchID")]
[Index("PrintGrpChecksum", Name = "idx_PrintGrp_PrintGrp_Checksum")]
[Index("PrintGrpIChangeSetId", Name = "idx_PrintGrp_iChangeSetID")]
public partial class PrintGrp
{
    [Key]
    public int AutoIdx { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Descrip { get; set; }

    [Column(TypeName = "text")]
    public string? GrpList { get; set; }

    public int? DocType { get; set; }

    [Column("PrintGrp_iBranchID")]
    public int? PrintGrpIBranchId { get; set; }

    [Column("PrintGrp_dCreatedDate", TypeName = "datetime")]
    public DateTime? PrintGrpDCreatedDate { get; set; }

    [Column("PrintGrp_dModifiedDate", TypeName = "datetime")]
    public DateTime? PrintGrpDModifiedDate { get; set; }

    [Column("PrintGrp_iCreatedBranchID")]
    public int? PrintGrpICreatedBranchId { get; set; }

    [Column("PrintGrp_iModifiedBranchID")]
    public int? PrintGrpIModifiedBranchId { get; set; }

    [Column("PrintGrp_iCreatedAgentID")]
    public int? PrintGrpICreatedAgentId { get; set; }

    [Column("PrintGrp_iModifiedAgentID")]
    public int? PrintGrpIModifiedAgentId { get; set; }

    [Column("PrintGrp_iChangeSetID")]
    public int? PrintGrpIChangeSetId { get; set; }

    [Column("PrintGrp_Checksum")]
    [MaxLength(20)]
    public byte[]? PrintGrpChecksum { get; set; }
}
