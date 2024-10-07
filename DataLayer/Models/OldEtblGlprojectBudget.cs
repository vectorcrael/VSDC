using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("IGlaccountId", "IProjectId", "ITxBranchProjectBudgetId")]
[Table("_old_etblGLProjectBudgets")]
[Index("OldEtblGlprojectBudgetsChecksum", Name = "idx__etblGLProjectBudgets__etblGLProjectBudgets_Checksum")]
[Index("OldEtblGlprojectBudgetsIChangeSetId", Name = "idx__etblGLProjectBudgets_iChangeSetID")]
[Index("OldEtblGlprojectBudgetsDModifiedDate", Name = "idx_etblGLProjectBudgets_dModifiedDate")]
[Index("OldEtblGlprojectBudgetsIBranchId", Name = "idx_etblGLProjectBudgets_iBranchID")]
public partial class OldEtblGlprojectBudget
{
    [Key]
    [Column("iGLAccountID")]
    public int IGlaccountId { get; set; }

    [Key]
    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("cAccountType")]
    [StringLength(50)]
    [Unicode(false)]
    public string CAccountType { get; set; } = null!;

    [Column("fBudget01")]
    public double? FBudget01 { get; set; }

    [Column("fBudget02")]
    public double? FBudget02 { get; set; }

    [Column("fBudget03")]
    public double? FBudget03 { get; set; }

    [Column("fBudget04")]
    public double? FBudget04 { get; set; }

    [Column("fBudget05")]
    public double? FBudget05 { get; set; }

    [Column("fBudget06")]
    public double? FBudget06 { get; set; }

    [Column("fBudget07")]
    public double? FBudget07 { get; set; }

    [Column("fBudget08")]
    public double? FBudget08 { get; set; }

    [Column("fBudget09")]
    public double? FBudget09 { get; set; }

    [Column("fBudget10")]
    public double? FBudget10 { get; set; }

    [Column("fBudget11")]
    public double? FBudget11 { get; set; }

    [Column("fBudget12")]
    public double? FBudget12 { get; set; }

    [Column("fBudget13")]
    public double? FBudget13 { get; set; }

    [Column("fBudget14")]
    public double? FBudget14 { get; set; }

    [Column("fBudget15")]
    public double? FBudget15 { get; set; }

    [Column("fBudget16")]
    public double? FBudget16 { get; set; }

    [Column("fBudget17")]
    public double? FBudget17 { get; set; }

    [Column("fBudget18")]
    public double? FBudget18 { get; set; }

    [Column("fBudget19")]
    public double? FBudget19 { get; set; }

    [Column("fBudget20")]
    public double? FBudget20 { get; set; }

    [Column("fBudget21")]
    public double? FBudget21 { get; set; }

    [Column("fBudget22")]
    public double? FBudget22 { get; set; }

    [Column("fBudget23")]
    public double? FBudget23 { get; set; }

    [Column("fBudget24")]
    public double? FBudget24 { get; set; }

    [Column("fBudget25")]
    public double? FBudget25 { get; set; }

    [Column("fBudget26")]
    public double? FBudget26 { get; set; }

    [Column("fBudget27")]
    public double? FBudget27 { get; set; }

    [Column("fBudget28")]
    public double? FBudget28 { get; set; }

    [Column("fBudget29")]
    public double? FBudget29 { get; set; }

    [Column("fBudget30")]
    public double? FBudget30 { get; set; }

    [Column("fBudget31")]
    public double? FBudget31 { get; set; }

    [Column("fBudget32")]
    public double? FBudget32 { get; set; }

    [Column("fBudget33")]
    public double? FBudget33 { get; set; }

    [Column("fBudget34")]
    public double? FBudget34 { get; set; }

    [Column("fBudget35")]
    public double? FBudget35 { get; set; }

    [Column("fBudget36")]
    public double? FBudget36 { get; set; }

    [Column("fBudget37")]
    public double? FBudget37 { get; set; }

    [Column("fBudget38")]
    public double? FBudget38 { get; set; }

    [Column("fBudget39")]
    public double? FBudget39 { get; set; }

    [Column("fBudget40")]
    public double? FBudget40 { get; set; }

    [Column("fBudget41")]
    public double? FBudget41 { get; set; }

    [Column("fBudget42")]
    public double? FBudget42 { get; set; }

    [Column("fBudget43")]
    public double? FBudget43 { get; set; }

    [Column("fBudget44")]
    public double? FBudget44 { get; set; }

    [Column("fBudget45")]
    public double? FBudget45 { get; set; }

    [Column("fBudget46")]
    public double? FBudget46 { get; set; }

    [Column("fBudget47")]
    public double? FBudget47 { get; set; }

    [Column("fBudget48")]
    public double? FBudget48 { get; set; }

    [Column("fBudget49")]
    public double? FBudget49 { get; set; }

    [Column("fBudget50")]
    public double? FBudget50 { get; set; }

    [Column("fBudget51")]
    public double? FBudget51 { get; set; }

    [Column("fBudget52")]
    public double? FBudget52 { get; set; }

    [Column("fBudget53")]
    public double? FBudget53 { get; set; }

    [Column("fBudget54")]
    public double? FBudget54 { get; set; }

    [Column("fBudget55")]
    public double? FBudget55 { get; set; }

    [Column("fBudget56")]
    public double? FBudget56 { get; set; }

    [Column("fBudget57")]
    public double? FBudget57 { get; set; }

    [Column("fBudget58")]
    public double? FBudget58 { get; set; }

    [Column("fBudget59")]
    public double? FBudget59 { get; set; }

    [Column("fBudget60")]
    public double? FBudget60 { get; set; }

    [Column("_old_etblGLProjectBudgets_iBranchID")]
    public int? OldEtblGlprojectBudgetsIBranchId { get; set; }

    [Column("_old_etblGLProjectBudgets_dCreatedDate", TypeName = "datetime")]
    public DateTime? OldEtblGlprojectBudgetsDCreatedDate { get; set; }

    [Column("_old_etblGLProjectBudgets_dModifiedDate", TypeName = "datetime")]
    public DateTime? OldEtblGlprojectBudgetsDModifiedDate { get; set; }

    [Column("_old_etblGLProjectBudgets_iCreatedBranchID")]
    public int? OldEtblGlprojectBudgetsICreatedBranchId { get; set; }

    [Column("_old_etblGLProjectBudgets_iModifiedBranchID")]
    public int? OldEtblGlprojectBudgetsIModifiedBranchId { get; set; }

    [Column("_old_etblGLProjectBudgets_iCreatedAgentID")]
    public int? OldEtblGlprojectBudgetsICreatedAgentId { get; set; }

    [Column("_old_etblGLProjectBudgets_iModifiedAgentID")]
    public int? OldEtblGlprojectBudgetsIModifiedAgentId { get; set; }

    [Column("_old_etblGLProjectBudgets_iChangeSetID")]
    public int? OldEtblGlprojectBudgetsIChangeSetId { get; set; }

    [Column("fUnprocessedPOValue")]
    public double? FUnprocessedPovalue { get; set; }

    [Key]
    [Column("iTxBranchProjectBudgetID")]
    public int ITxBranchProjectBudgetId { get; set; }

    [Column("_old_etblGLProjectBudgets_Checksum")]
    [MaxLength(20)]
    public byte[]? OldEtblGlprojectBudgetsChecksum { get; set; }
}
