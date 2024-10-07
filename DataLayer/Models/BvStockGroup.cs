using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvStockGroup
{
    [Column("idGrpTbl")]
    public int IdGrpTbl { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string StGroup { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? SalesAccLink { get; set; }

    [Column("COSAccLink")]
    public int? CosaccLink { get; set; }

    public int? StockAccLink { get; set; }

    public int? PurchasesAccLink { get; set; }

    [Column("SMtrxCol")]
    public int? SmtrxCol { get; set; }

    [Column("PMtrxCol")]
    public int? PmtrxCol { get; set; }

    [Column("dGrpTblTimeStamp", TypeName = "datetime")]
    public DateTime? DGrpTblTimeStamp { get; set; }

    [Column("bPromptSales")]
    public bool BPromptSales { get; set; }

    [Column("bPromptCOS")]
    public bool BPromptCos { get; set; }

    [Column("bPromptStock")]
    public bool BPromptStock { get; set; }

    [Column("bPromptPurchases")]
    public bool BPromptPurchases { get; set; }

    public int? CostVarianceAccLink { get; set; }

    [Column("bPromptCostVariance")]
    public bool BPromptCostVariance { get; set; }

    public int? StockAdjustAccLink { get; set; }

    [Column("bPromptStockAdjust")]
    public bool BPromptStockAdjust { get; set; }

    [Column("iStockCostVarianceAccID")]
    public int IStockCostVarianceAccId { get; set; }

    [Column("bPromptStockCostVariance")]
    public bool BPromptStockCostVariance { get; set; }

    [Column("iWIPAccID")]
    public int IWipaccId { get; set; }

    [Column("bPromptWIP")]
    public bool BPromptWip { get; set; }

    [Column("GrpTbl_iBranchID")]
    public int? GrpTblIBranchId { get; set; }

    [Column("GrpTbl_dCreatedDate", TypeName = "datetime")]
    public DateTime? GrpTblDCreatedDate { get; set; }

    [Column("GrpTbl_dModifiedDate", TypeName = "datetime")]
    public DateTime? GrpTblDModifiedDate { get; set; }

    [Column("GrpTbl_iCreatedBranchID")]
    public int? GrpTblICreatedBranchId { get; set; }

    [Column("GrpTbl_iModifiedBranchID")]
    public int? GrpTblIModifiedBranchId { get; set; }

    [Column("GrpTbl_iCreatedAgentID")]
    public int? GrpTblICreatedAgentId { get; set; }

    [Column("GrpTbl_iModifiedAgentID")]
    public int? GrpTblIModifiedAgentId { get; set; }

    [Column("fGroupGPPercent")]
    public float? FGroupGppercent { get; set; }

    [Column("GrpTbl_iChangeSetID")]
    public int? GrpTblIChangeSetId { get; set; }

    [Column("GrpTbl_Checksum")]
    [MaxLength(20)]
    public byte[]? GrpTblChecksum { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? SalesAccount { get; set; }

    [Column("COSAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? Cosaccount { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? StockAccount { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? PurchasesAccount { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? CostVarianceAccount { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? StockAdjustAccount { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? StockCostVarianceAccount { get; set; }

    [Column("WIPAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? Wipaccount { get; set; }
}
