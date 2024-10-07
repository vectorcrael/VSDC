using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblBudgets")]
[Index("EtblBudgetsChecksum", Name = "idx__etblBudgets__etblBudgets_Checksum")]
[Index("EtblBudgetsDModifiedDate", Name = "idx__etblBudgets__etblBudgets_dModifiedDate")]
[Index("EtblBudgetsIBranchId", Name = "idx__etblBudgets__etblBudgets_iBranchID")]
[Index("EtblBudgetsIChangeSetId", Name = "idx__etblBudgets__etblBudgets_iChangeSetID")]
[Index("IBudgetAccountId", "IBudgetPeriodId", "IBudgetProjectId", "IBudgetTxBranchId", Name = "idx__etblBudgets_iBudgetAccountIDiBudgetPeriodIDiBudgetProjectIDiBudgetTxBranchID")]
public partial class EtblBudget
{
    [Key]
    [Column("idBudgets")]
    public int IdBudgets { get; set; }

    [Column("iBudgetAccountID")]
    public int IBudgetAccountId { get; set; }

    [Column("iBudgetProjectID")]
    public int IBudgetProjectId { get; set; }

    [Column("iBudgetPeriodID")]
    public int IBudgetPeriodId { get; set; }

    [Column("iBudgetTxBranchID")]
    public int IBudgetTxBranchId { get; set; }

    [Column("iBudgetAccountType")]
    public int IBudgetAccountType { get; set; }

    [Column("fBudget")]
    public double? FBudget { get; set; }

    [Column("fUnprocessedPOValue")]
    public double? FUnprocessedPovalue { get; set; }

    [Column("dBudgetDTStamp", TypeName = "datetime")]
    public DateTime? DBudgetDtstamp { get; set; }

    [Column("_etblBudgets_iBranchID")]
    public int? EtblBudgetsIBranchId { get; set; }

    [Column("_etblBudgets_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblBudgetsDCreatedDate { get; set; }

    [Column("_etblBudgets_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblBudgetsDModifiedDate { get; set; }

    [Column("_etblBudgets_iCreatedBranchID")]
    public int? EtblBudgetsICreatedBranchId { get; set; }

    [Column("_etblBudgets_iModifiedBranchID")]
    public int? EtblBudgetsIModifiedBranchId { get; set; }

    [Column("_etblBudgets_iCreatedAgentID")]
    public int? EtblBudgetsICreatedAgentId { get; set; }

    [Column("_etblBudgets_iModifiedAgentID")]
    public int? EtblBudgetsIModifiedAgentId { get; set; }

    [Column("_etblBudgets_iChangeSetID")]
    public int? EtblBudgetsIChangeSetId { get; set; }

    [Column("_etblBudgets_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblBudgetsChecksum { get; set; }

    [Column("fForecast")]
    public double FForecast { get; set; }

    [Column("fBudgetForeign")]
    public double FBudgetForeign { get; set; }

    [Column("fUnprocessedPOValueForeign")]
    public double FUnprocessedPovalueForeign { get; set; }

    [Column("fForecastForeign")]
    public double FForecastForeign { get; set; }
}
