using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("WhseStk")]
[Index("WhseStkDModifiedDate", Name = "idxWhseStk_dModifiedDate")]
[Index("WhseStkIBranchId", Name = "idxWhseStk_iBranchID")]
[Index("WhseStkChecksum", Name = "idx_WhseStk_WhseStk_Checksum")]
[Index("WhseStkIChangeSetId", Name = "idx_WhseStk_iChangeSetID")]
public partial class WhseStk
{
    [Key]
    public long IdWhseStk { get; set; }

    [Column("WHWhseID")]
    public int? WhwhseId { get; set; }

    [Column("WHStockLink")]
    public int WhstockLink { get; set; }

    [Column("WHStockGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string? WhstockGroup { get; set; }

    [Column("WHQtyOnHand")]
    public double WhqtyOnHand { get; set; }

    [Column("WHQtyOnSO")]
    public double WhqtyOnSo { get; set; }

    [Column("WHQtyOnPO")]
    public double WhqtyOnPo { get; set; }

    [Column("WHQtyReserved")]
    public double WhqtyReserved { get; set; }

    [Column("WHTTInv")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Whttinv { get; set; }

    [Column("WHTTCrn")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Whttcrn { get; set; }

    [Column("WHTTGrv")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Whttgrv { get; set; }

    [Column("WHTTRts")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Whttrts { get; set; }

    [Column("WHBarCode")]
    [StringLength(400)]
    [Unicode(false)]
    public string? WhbarCode { get; set; }

    [Column("WHRe_Ord_Lvl")]
    public double? WhreOrdLvl { get; set; }

    [Column("WHRe_Ord_Qty")]
    public double? WhreOrdQty { get; set; }

    [Column("WHMin_Lvl")]
    public double? WhminLvl { get; set; }

    [Column("WHMax_Lvl")]
    public double? WhmaxLvl { get; set; }

    [Column("WHUsePriceDefs")]
    public bool WhusePriceDefs { get; set; }

    [Column("WHUseInfoDefs")]
    public bool WhuseInfoDefs { get; set; }

    [Column("WHUseOrderDefs")]
    public bool WhuseOrderDefs { get; set; }

    [Column("WHUseDefaultDefs")]
    public bool WhuseDefaultDefs { get; set; }

    [Column("WHPackCode")]
    [StringLength(5)]
    [Unicode(false)]
    public string? WhpackCode { get; set; }

    [Column("WHJobQty")]
    public double WhjobQty { get; set; }

    [Column("iBinLocationID")]
    public int? IBinLocationId { get; set; }

    [Column("fLGRVCount")]
    public double? FLgrvcount { get; set; }

    [Column("WHMFPQty")]
    public double Whmfpqty { get; set; }

    [Column("WHUseSupplierDefs")]
    public bool WhuseSupplierDefs { get; set; }

    [Column("fAverageCost")]
    public double FAverageCost { get; set; }

    [Column("fLatestCost")]
    public double FLatestCost { get; set; }

    [Column("fLowestCost")]
    public double FLowestCost { get; set; }

    [Column("fHighestCost")]
    public double FHighestCost { get; set; }

    [Column("fManualCost")]
    public double FManualCost { get; set; }

    [Column("fWhseLastGRVCost")]
    public double FWhseLastGrvcost { get; set; }

    [Column("WhseStk_iBranchID")]
    public int? WhseStkIBranchId { get; set; }

    [Column("WhseStk_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhseStkDCreatedDate { get; set; }

    [Column("WhseStk_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhseStkDModifiedDate { get; set; }

    [Column("WhseStk_iCreatedBranchID")]
    public int? WhseStkICreatedBranchId { get; set; }

    [Column("WhseStk_iModifiedBranchID")]
    public int? WhseStkIModifiedBranchId { get; set; }

    [Column("WhseStk_iCreatedAgentID")]
    public int? WhseStkICreatedAgentId { get; set; }

    [Column("WhseStk_iModifiedAgentID")]
    public int? WhseStkIModifiedAgentId { get; set; }

    [Column("WhseStk_iChangeSetID")]
    public int? WhseStkIChangeSetId { get; set; }

    [Column("bWHAllowNegStock")]
    public bool BWhallowNegStock { get; set; }

    [Column("fWHQtyToDeliver")]
    public double? FWhqtyToDeliver { get; set; }

    [Column("WhseStk_fLeadDays")]
    public double? WhseStkFLeadDays { get; set; }

    [Column("WHBuyingAgentID")]
    public int? WhbuyingAgentId { get; set; }

    [Column("fIBTQtyToIssue")]
    public double FIbtqtyToIssue { get; set; }

    [Column("fIBTQtyToReceive")]
    public double FIbtqtyToReceive { get; set; }

    [Column("WhseStk_Checksum")]
    [MaxLength(20)]
    public byte[]? WhseStkChecksum { get; set; }
}
