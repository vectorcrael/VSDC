using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[PrimaryKey("Gllink", "ITxBranchBudgetId")]
[Table("_oldBudgets")]
[Index("OldBudgetsDModifiedDate", Name = "idxBudgets_dModifiedDate")]
[Index("OldBudgetsIBranchId", Name = "idxBudgets_iBranchID")]
[Index("OldBudgetsChecksum", Name = "idx_Budgets_Budgets_Checksum")]
[Index("OldBudgetsIChangeSetId", Name = "idx_Budgets_iChangeSetID")]
public partial class OldBudget
{
    [Key]
    [Column("GLLink")]
    public int Gllink { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccType { get; set; }

    public double? Budget01 { get; set; }

    public double? Budget02 { get; set; }

    public double? Budget03 { get; set; }

    public double? Budget04 { get; set; }

    public double? Budget05 { get; set; }

    public double? Budget06 { get; set; }

    public double? Budget07 { get; set; }

    public double? Budget08 { get; set; }

    public double? Budget09 { get; set; }

    public double? Budget10 { get; set; }

    public double? Budget11 { get; set; }

    public double? Budget12 { get; set; }

    public double? Budget13 { get; set; }

    public double? Budget14 { get; set; }

    public double? Budget15 { get; set; }

    public double? Budget16 { get; set; }

    public double? Budget17 { get; set; }

    public double? Budget18 { get; set; }

    public double? Budget19 { get; set; }

    public double? Budget20 { get; set; }

    public double? Budget21 { get; set; }

    public double? Budget22 { get; set; }

    public double? Budget23 { get; set; }

    public double? Budget24 { get; set; }

    public double? Budget25 { get; set; }

    public double? Budget26 { get; set; }

    public double? Budget27 { get; set; }

    public double? Budget28 { get; set; }

    public double? Budget29 { get; set; }

    public double? Budget30 { get; set; }

    public double? Budget31 { get; set; }

    public double? Budget32 { get; set; }

    public double? Budget33 { get; set; }

    public double? Budget34 { get; set; }

    public double? Budget35 { get; set; }

    public double? Budget36 { get; set; }

    [Column("dBudgetTimeStamp", TypeName = "datetime")]
    public DateTime? DBudgetTimeStamp { get; set; }

    public double? Budget37 { get; set; }

    public double? Budget38 { get; set; }

    public double? Budget39 { get; set; }

    public double? Budget40 { get; set; }

    public double? Budget41 { get; set; }

    public double? Budget42 { get; set; }

    public double? Budget43 { get; set; }

    public double? Budget44 { get; set; }

    public double? Budget45 { get; set; }

    public double? Budget46 { get; set; }

    public double? Budget47 { get; set; }

    public double? Budget48 { get; set; }

    public double? Budget49 { get; set; }

    public double? Budget50 { get; set; }

    public double? Budget51 { get; set; }

    public double? Budget52 { get; set; }

    public double? Budget53 { get; set; }

    public double? Budget54 { get; set; }

    public double? Budget55 { get; set; }

    public double? Budget56 { get; set; }

    public double? Budget57 { get; set; }

    public double? Budget58 { get; set; }

    public double? Budget59 { get; set; }

    public double? Budget60 { get; set; }

    [Column("_oldBudgets_iBranchID")]
    public int? OldBudgetsIBranchId { get; set; }

    [Column("_oldBudgets_dCreatedDate", TypeName = "datetime")]
    public DateTime? OldBudgetsDCreatedDate { get; set; }

    [Column("_oldBudgets_dModifiedDate", TypeName = "datetime")]
    public DateTime? OldBudgetsDModifiedDate { get; set; }

    [Column("_oldBudgets_iCreatedBranchID")]
    public int? OldBudgetsICreatedBranchId { get; set; }

    [Column("_oldBudgets_iModifiedBranchID")]
    public int? OldBudgetsIModifiedBranchId { get; set; }

    [Column("_oldBudgets_iCreatedAgentID")]
    public int? OldBudgetsICreatedAgentId { get; set; }

    [Column("_oldBudgets_iModifiedAgentID")]
    public int? OldBudgetsIModifiedAgentId { get; set; }

    [Column("_oldBudgets_iChangeSetID")]
    public int? OldBudgetsIChangeSetId { get; set; }

    [Column("fUnprocessedPOValue")]
    public double? FUnprocessedPovalue { get; set; }

    [Key]
    [Column("iTxBranchBudgetID")]
    public int ITxBranchBudgetId { get; set; }

    [Column("_oldBudgets_Checksum")]
    [MaxLength(20)]
    public byte[]? OldBudgetsChecksum { get; set; }
}
