using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("GLBranch")]
[Index("GlbranchDModifiedDate", Name = "idxGLBranch_dModifiedDate")]
[Index("GlbranchIBranchId", Name = "idxGLBranch_iBranchID")]
[Index("GlbranchChecksum", Name = "idx_GLBranch_GLBranch_Checksum")]
[Index("GlbranchIChangeSetId", Name = "idx_GLBranch_iChangeSetID")]
public partial class Glbranch
{
    [Key]
    [Column("idGLBranch")]
    public int IdGlbranch { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Info { get; set; }

    [Column("dBrDeptTimeStamp", TypeName = "datetime")]
    public DateTime? DBrDeptTimeStamp { get; set; }

    [Column("GLBranch_iBranchID")]
    public int? GlbranchIBranchId { get; set; }

    [Column("GLBranch_dCreatedDate", TypeName = "datetime")]
    public DateTime? GlbranchDCreatedDate { get; set; }

    [Column("GLBranch_dModifiedDate", TypeName = "datetime")]
    public DateTime? GlbranchDModifiedDate { get; set; }

    [Column("GLBranch_iCreatedBranchID")]
    public int? GlbranchICreatedBranchId { get; set; }

    [Column("GLBranch_iModifiedBranchID")]
    public int? GlbranchIModifiedBranchId { get; set; }

    [Column("GLBranch_iCreatedAgentID")]
    public int? GlbranchICreatedAgentId { get; set; }

    [Column("GLBranch_iModifiedAgentID")]
    public int? GlbranchIModifiedAgentId { get; set; }

    [Column("GLBranch_iChangeSetID")]
    public int? GlbranchIChangeSetId { get; set; }

    [Column("GLBranch_Checksum")]
    [MaxLength(20)]
    public byte[]? GlbranchChecksum { get; set; }
}
