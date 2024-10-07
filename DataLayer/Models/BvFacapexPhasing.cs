﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFacapexPhasing
{
    [Column("idCapexPhasingNo")]
    public int IdCapexPhasingNo { get; set; }

    [Column("iCapexBudgetNo")]
    public int ICapexBudgetNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime BudgetDate { get; set; }

    [Column("fPhaseAmount")]
    public double FPhaseAmount { get; set; }

    [Column("_btblFACapexPhasing_iBranchID")]
    public int? BtblFacapexPhasingIBranchId { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? CapexDesc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NewInd { get; set; }

    [Column("iAssetTypeNo")]
    public int? IAssetTypeNo { get; set; }

    [Column("iCostCenterNo")]
    public int? ICostCenterNo { get; set; }

    [Column("fBudgetAmount")]
    public double? FBudgetAmount { get; set; }

    public double? Balance1 { get; set; }

    [Column("fAmountSpent")]
    public double? FAmountSpent { get; set; }

    [Column("fAmountCommited")]
    public double? FAmountCommited { get; set; }

    public double? Balance2 { get; set; }

    [Column("dCapitalisationDate", TypeName = "smalldatetime")]
    public DateTime? DCapitalisationDate { get; set; }

    [Column("_btblFACapexBudget_iBranchID")]
    public int? BtblFacapexBudgetIBranchId { get; set; }

    [Column("_btblFACapexBudget_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFacapexBudgetDCreatedDate { get; set; }

    [Column("_btblFACapexBudget_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFacapexBudgetDModifiedDate { get; set; }

    [Column("_btblFACapexBudget_iCreatedBranchID")]
    public int? BtblFacapexBudgetICreatedBranchId { get; set; }

    [Column("_btblFACapexBudget_iModifiedBranchID")]
    public int? BtblFacapexBudgetIModifiedBranchId { get; set; }

    [Column("_btblFACapexBudget_iCreatedAgentID")]
    public int? BtblFacapexBudgetICreatedAgentId { get; set; }

    [Column("_btblFACapexBudget_iModifiedAgentID")]
    public int? BtblFacapexBudgetIModifiedAgentId { get; set; }

    [Column("cAssetTypeCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetTypeCode { get; set; }

    [Column("cAssetTypeDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CAssetTypeDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CostCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CostName { get; set; }

    public int? DeptNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DeptCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DeptDesc { get; set; }
}
