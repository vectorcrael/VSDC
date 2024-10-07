using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLReviseBudget")]
[Index("EtblGlreviseBudgetChecksum", Name = "idx__etblGLReviseBudget__etblGLReviseBudget_Checksum")]
[Index("EtblGlreviseBudgetIChangeSetId", Name = "idx__etblGLReviseBudget_iChangeSetID")]
[Index("EtblGlreviseBudgetDModifiedDate", Name = "idx_etblGLReviseBudget_dModifiedDate")]
[Index("EtblGlreviseBudgetIBranchId", Name = "idx_etblGLReviseBudget_iBranchID")]
public partial class EtblGlreviseBudget
{
    [Key]
    [Column("idGLReviseBudget")]
    public int IdGlreviseBudget { get; set; }

    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("iPeriod")]
    public int IPeriod { get; set; }

    [Column("fNewBudget")]
    public double FNewBudget { get; set; }

    [Column("fOldBudget")]
    public double FOldBudget { get; set; }

    [Column("cReason")]
    [StringLength(50)]
    [Unicode(false)]
    public string CReason { get; set; } = null!;

    [Column("dDate", TypeName = "datetime")]
    public DateTime DDate { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("_etblGLReviseBudget_iBranchID")]
    public int? EtblGlreviseBudgetIBranchId { get; set; }

    [Column("_etblGLReviseBudget_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlreviseBudgetDCreatedDate { get; set; }

    [Column("_etblGLReviseBudget_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlreviseBudgetDModifiedDate { get; set; }

    [Column("_etblGLReviseBudget_iCreatedBranchID")]
    public int? EtblGlreviseBudgetICreatedBranchId { get; set; }

    [Column("_etblGLReviseBudget_iModifiedBranchID")]
    public int? EtblGlreviseBudgetIModifiedBranchId { get; set; }

    [Column("_etblGLReviseBudget_iCreatedAgentID")]
    public int? EtblGlreviseBudgetICreatedAgentId { get; set; }

    [Column("_etblGLReviseBudget_iModifiedAgentID")]
    public int? EtblGlreviseBudgetIModifiedAgentId { get; set; }

    [Column("_etblGLReviseBudget_iChangeSetID")]
    public int? EtblGlreviseBudgetIChangeSetId { get; set; }

    [Column("iTxBranchRevisedBudgetID")]
    public int ITxBranchRevisedBudgetId { get; set; }

    [Column("_etblGLReviseBudget_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlreviseBudgetChecksum { get; set; }

    [Column("fNewBudgetForeign")]
    public double FNewBudgetForeign { get; set; }

    [Column("fOldBudgetForeign")]
    public double FOldBudgetForeign { get; set; }
}
