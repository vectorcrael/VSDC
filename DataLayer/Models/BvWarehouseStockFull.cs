using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvWarehouseStockFull
{
    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    public bool ServiceItem { get; set; }

    [Column("Description_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description1 { get; set; }

    [Column("Description_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description2 { get; set; }

    [Column("Description_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description3 { get; set; }

    public long IdWhseStk { get; set; }

    [Column("WHStockLink")]
    public int WhstockLink { get; set; }

    public int? WhseLink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WhCode { get; set; }

    [Column("WHQtyOnHand")]
    public double WhqtyOnHand { get; set; }

    [Column("WHQtyOnSO")]
    public double WhqtyOnSo { get; set; }

    [Column("WHQtyOnPO")]
    public double WhqtyOnPo { get; set; }

    [Column("WHQtyReserved")]
    public double WhqtyReserved { get; set; }

    [Column("WHJobQty")]
    public double WhjobQty { get; set; }

    [Column("WHMFPQty")]
    public double Whmfpqty { get; set; }

    [Column("WHUsePriceDefs")]
    public bool WhusePriceDefs { get; set; }

    [Column("WHUseInfoDefs")]
    public bool WhuseInfoDefs { get; set; }

    [Column("WHUseOrderDefs")]
    public bool WhuseOrderDefs { get; set; }

    [Column("WHUseDefaultDefs")]
    public bool WhuseDefaultDefs { get; set; }

    [Column("WHUseSupplierDefs")]
    public bool WhuseSupplierDefs { get; set; }

    [Column("WhseStk_iBranchID")]
    public int? WhseStkIBranchId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DefaultPriceListName { get; set; }

    public double? DefaultPriceExcl { get; set; }

    public double? DefaultPriceIncl { get; set; }

    public double? ExPr1 { get; set; }

    public double? InPr1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PriceListName1 { get; set; }

    public double? ExPr2 { get; set; }

    public double? InPr2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PriceListName2 { get; set; }

    public double? ExPr3 { get; set; }

    public double? InPr3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PriceListName3 { get; set; }

    public bool? UseMarkup1 { get; set; }

    public double? MarkupRate1 { get; set; }

    public bool? UseMarkup2 { get; set; }

    public double? MarkupRate2 { get; set; }

    public bool? UseMarkup3 { get; set; }

    public double? MarkupRate3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? StockGroup { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Bin { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PackCode { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? Barcode { get; set; }

    public double? ReorderLevel { get; set; }

    public double? ReorderQty { get; set; }

    public double? MinLevel { get; set; }

    public double? MaxLevel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Supplier { get; set; }

    [Column("fMinOrderQuantity")]
    public double? FMinOrderQuantity { get; set; }

    [Column("TTInv")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ttinv { get; set; }

    [Column("TTCrn")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ttcrn { get; set; }

    [Column("TTGrv")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ttgrv { get; set; }

    [Column("TTRts")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ttrts { get; set; }

    [Column("AveUCst")]
    public double AveUcst { get; set; }

    [Column("LatUCst")]
    public double LatUcst { get; set; }

    [Column("LowUCst")]
    public double LowUcst { get; set; }

    [Column("HigUCst")]
    public double HigUcst { get; set; }

    [Column("StdUCst")]
    public double StdUcst { get; set; }

    [Column("LstGRVCst")]
    public double LstGrvcst { get; set; }

    public double ItemCost { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string CostingMethodDescription { get; set; } = null!;

    public int CostingMethod { get; set; }
}
