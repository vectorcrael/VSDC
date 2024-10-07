using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLReviseBudgetPrev")]
[Index("EtblGlreviseBudgetPrevChecksum", Name = "idx__etblGLReviseBudgetPrev__etblGLReviseBudgetPrev_Checksum")]
[Index("EtblGlreviseBudgetPrevDModifiedDate", Name = "idx__etblGLReviseBudgetPrev__etblGLReviseBudgetPrev_dModifiedDate")]
[Index("EtblGlreviseBudgetPrevIBranchId", Name = "idx__etblGLReviseBudgetPrev__etblGLReviseBudgetPrev_iBranchID")]
[Index("EtblGlreviseBudgetPrevIChangeSetId", Name = "idx__etblGLReviseBudgetPrev__etblGLReviseBudgetPrev_iChangeSetID")]
public partial class EtblGlreviseBudgetPrev
{
    [Key]
    [Column("idGLReviseBudgetPrev")]
    public int IdGlreviseBudgetPrev { get; set; }

    [Column("iGLAccountPrevID")]
    public int IGlaccountPrevId { get; set; }

    [Column("iProjectPrevID")]
    public int IProjectPrevId { get; set; }

    [Column("iPeriodPrevID")]
    public int IPeriodPrevId { get; set; }

    [Column("fNewBudgetPrev")]
    public double? FNewBudgetPrev { get; set; }

    [Column("fOldBudgetPrev")]
    public double? FOldBudgetPrev { get; set; }

    [Column("cReasonPrev")]
    [StringLength(50)]
    [Unicode(false)]
    public string CReasonPrev { get; set; } = null!;

    [Column("dDatePrev", TypeName = "datetime")]
    public DateTime? DDatePrev { get; set; }

    [Column("iAgentIDPrev")]
    public int? IAgentIdprev { get; set; }

    [Column("_etblGLReviseBudgetPrev_iBranchID")]
    public int? EtblGlreviseBudgetPrevIBranchId { get; set; }

    [Column("_etblGLReviseBudgetPrev_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlreviseBudgetPrevDCreatedDate { get; set; }

    [Column("_etblGLReviseBudgetPrev_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlreviseBudgetPrevDModifiedDate { get; set; }

    [Column("_etblGLReviseBudgetPrev_iCreatedBranchID")]
    public int? EtblGlreviseBudgetPrevICreatedBranchId { get; set; }

    [Column("_etblGLReviseBudgetPrev_iModifiedBranchID")]
    public int? EtblGlreviseBudgetPrevIModifiedBranchId { get; set; }

    [Column("_etblGLReviseBudgetPrev_iCreatedAgentID")]
    public int? EtblGlreviseBudgetPrevICreatedAgentId { get; set; }

    [Column("_etblGLReviseBudgetPrev_iModifiedAgentID")]
    public int? EtblGlreviseBudgetPrevIModifiedAgentId { get; set; }

    [Column("_etblGLReviseBudgetPrev_iChangeSetID")]
    public int? EtblGlreviseBudgetPrevIChangeSetId { get; set; }

    [Column("_etblGLReviseBudgetPrev_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlreviseBudgetPrevChecksum { get; set; }

    [Column("fNewBudgetPrevForeign")]
    public double FNewBudgetPrevForeign { get; set; }

    [Column("fOldBudgetPrevForeign")]
    public double FOldBudgetPrevForeign { get; set; }
}
