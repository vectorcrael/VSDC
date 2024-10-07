using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLReportCategory")]
[Index("EtblGlreportCategoryChecksum", Name = "idx__etblGLReportCategory__etblGLReportCategory_Checksum")]
[Index("EtblGlreportCategoryIChangeSetId", Name = "idx__etblGLReportCategory_iChangeSetID")]
[Index("EtblGlreportCategoryDModifiedDate", Name = "idx_etblGLReportCategory_dModifiedDate")]
[Index("EtblGlreportCategoryIBranchId", Name = "idx_etblGLReportCategory_iBranchID")]
public partial class EtblGlreportCategory
{
    [Key]
    [Column("idReportCategory")]
    public int IdReportCategory { get; set; }

    [Column("cCode")]
    [StringLength(40)]
    [Unicode(false)]
    public string CCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblGLReportCategory_iBranchID")]
    public int? EtblGlreportCategoryIBranchId { get; set; }

    [Column("_etblGLReportCategory_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlreportCategoryDCreatedDate { get; set; }

    [Column("_etblGLReportCategory_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlreportCategoryDModifiedDate { get; set; }

    [Column("_etblGLReportCategory_iCreatedBranchID")]
    public int? EtblGlreportCategoryICreatedBranchId { get; set; }

    [Column("_etblGLReportCategory_iModifiedBranchID")]
    public int? EtblGlreportCategoryIModifiedBranchId { get; set; }

    [Column("_etblGLReportCategory_iCreatedAgentID")]
    public int? EtblGlreportCategoryICreatedAgentId { get; set; }

    [Column("_etblGLReportCategory_iModifiedAgentID")]
    public int? EtblGlreportCategoryIModifiedAgentId { get; set; }

    [Column("_etblGLReportCategory_iChangeSetID")]
    public int? EtblGlreportCategoryIChangeSetId { get; set; }

    [Column("_etblGLReportCategory_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlreportCategoryChecksum { get; set; }
}
