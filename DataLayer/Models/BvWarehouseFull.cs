using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvWarehouseFull
{
    public int WhseLink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? KnownAs { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PostCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Tel { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Manager { get; set; }

    public int? BankLink { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccNum { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccType { get; set; }

    [Column("EMail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ModemTel { get; set; }

    public bool DefaultWhse { get; set; }

    public bool AddNewStock { get; set; }

    [Column("dWarehouseTimeStamp", TypeName = "datetime")]
    public DateTime? DWarehouseTimeStamp { get; set; }

    [Column("iWhseTypeID")]
    public int IWhseTypeId { get; set; }

    [Column("bAllowToBuyInto")]
    public bool BAllowToBuyInto { get; set; }

    [Column("bAllowToSellFrom")]
    public bool BAllowToSellFrom { get; set; }

    [Column("WhseMst_iBranchID")]
    public int? WhseMstIBranchId { get; set; }

    [Column("WhseMst_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhseMstDCreatedDate { get; set; }

    [Column("WhseMst_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhseMstDModifiedDate { get; set; }

    [Column("WhseMst_iCreatedBranchID")]
    public int? WhseMstICreatedBranchId { get; set; }

    [Column("WhseMst_iModifiedBranchID")]
    public int? WhseMstIModifiedBranchId { get; set; }

    [Column("WhseMst_iCreatedAgentID")]
    public int? WhseMstICreatedAgentId { get; set; }

    [Column("WhseMst_iModifiedAgentID")]
    public int? WhseMstIModifiedAgentId { get; set; }

    [Column("WhseMst_iChangeSetID")]
    public int? WhseMstIChangeSetId { get; set; }

    [Column("bAllowNegStock")]
    public bool BAllowNegStock { get; set; }

    [Column("cDefaultItemGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CDefaultItemGroup { get; set; }

    [Column("WhseMst_Checksum")]
    [MaxLength(20)]
    public byte[]? WhseMstChecksum { get; set; }

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
