using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFACapexBudget")]
[Index("BtblFacapexBudgetChecksum", Name = "idx__btblFACapexBudget__btblFACapexBudget_Checksum")]
[Index("BtblFacapexBudgetIChangeSetId", Name = "idx__btblFACapexBudget_iChangeSetID")]
[Index("BtblFacapexBudgetDModifiedDate", Name = "idx_btblFACapexBudget_dModifiedDate")]
[Index("BtblFacapexBudgetIBranchId", Name = "idx_btblFACapexBudget_iBranchID")]
public partial class BtblFacapexBudget
{
    [Key]
    [Column("idCapexBudgetNo")]
    public int IdCapexBudgetNo { get; set; }

    [Column("cCapexDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string CCapexDesc { get; set; } = null!;

    [Column("cReplacementNewInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string CReplacementNewInd { get; set; } = null!;

    [Column("iAssetTypeNo")]
    public int IAssetTypeNo { get; set; }

    [Column("iCostCenterNo")]
    public int? ICostCenterNo { get; set; }

    [Column("fBudgetAmount")]
    public double FBudgetAmount { get; set; }

    [Column("fAmountSpent")]
    public double? FAmountSpent { get; set; }

    [Column("fAmountCommited")]
    public double? FAmountCommited { get; set; }

    [Column("dCapitalisationDate", TypeName = "smalldatetime")]
    public DateTime DCapitalisationDate { get; set; }

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

    [Column("_btblFACapexBudget_iChangeSetID")]
    public int? BtblFacapexBudgetIChangeSetId { get; set; }

    [Column("_btblFACapexBudget_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFacapexBudgetChecksum { get; set; }
}
