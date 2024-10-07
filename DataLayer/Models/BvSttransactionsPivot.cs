using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvSttransactionsPivot
{
    [Column("DCLink")]
    public int Dclink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ClientCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ClientName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [StringLength(172)]
    [Unicode(false)]
    public string? ClientBoth { get; set; }

    [Column("iClassID")]
    public int IClassId { get; set; }

    [Column("iAreasID")]
    public int IAreasId { get; set; }

    [Column("On_Hold")]
    public bool OnHold { get; set; }

    public double? QtyInStock { get; set; }

    public bool? ServiceItem { get; set; }

    public bool? ItemActive { get; set; }

    [Column("iInvSegValue1ID")]
    public int? IInvSegValue1Id { get; set; }

    [Column("iInvSegValue2ID")]
    public int? IInvSegValue2Id { get; set; }

    [Column("iInvSegValue3ID")]
    public int? IInvSegValue3Id { get; set; }

    [Column("iInvSegValue4ID")]
    public int? IInvSegValue4Id { get; set; }

    [Column("iInvSegValue5ID")]
    public int? IInvSegValue5Id { get; set; }

    [Column("iInvSegValue6ID")]
    public int? IInvSegValue6Id { get; set; }

    [Column("iInvSegValue7ID")]
    public int? IInvSegValue7Id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TxDate { get; set; }

    [Column("id")]
    [StringLength(5)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    public double? Quantity { get; set; }

    public double? Cost { get; set; }

    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    public double? Profit { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Module { get; set; } = null!;

    public double? ActualValue { get; set; }

    public double? ActualSalesValue { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TrCode { get; set; }

    [Column("TrCodeID")]
    public int? TrCodeId { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [Column("cReference2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference2 { get; set; }

    public long AutoIdx { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("fQuantityInvoiced")]
    public double FQuantityInvoiced { get; set; }

    public int Project { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [StringLength(73)]
    [Unicode(false)]
    public string? ProjectBoth { get; set; }

    public int? StockLink { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription { get; set; }

    [Column("WarehouseID")]
    public int WarehouseId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WhseName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WhseCode { get; set; }

    [StringLength(72)]
    [Unicode(false)]
    public string? WhseBoth { get; set; }

    [Column("ItemGroupID")]
    public int? ItemGroupId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ItemGroupName { get; set; }

    [StringLength(52)]
    [Unicode(false)]
    public string? ItemGroupBoth { get; set; }

    [Column("RepID")]
    public int RepId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RepName { get; set; }

    [StringLength(52)]
    [Unicode(false)]
    public string? RepBoth { get; set; }

    [Column("iTxBranchID")]
    public int ITxBranchId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TxBranchCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TxBranchDescription { get; set; }

    [StringLength(72)]
    [Unicode(false)]
    public string? BranchBoth { get; set; }

    public double? TotalCost { get; set; }

    public double? MarkupPerc { get; set; }

    public double? ProfitPerc { get; set; }

    [Column("idPeriod")]
    public int IdPeriod { get; set; }

    [Column("iYearID")]
    public int IYearId { get; set; }

    [StringLength(13)]
    public string? Perioddate { get; set; }

    [Column("cYearDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CYearDescription { get; set; } = null!;

    [Column("idBinLocation")]
    public int IdBinLocation { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BinLocationName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BinLocationDescription { get; set; }

    [StringLength(132)]
    [Unicode(false)]
    public string? BinBoth { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ClassCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ClassName { get; set; }

    [StringLength(122)]
    [Unicode(false)]
    public string? ClassBoth { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AreaCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AreaName { get; set; }

    [StringLength(42)]
    [Unicode(false)]
    public string? AreaBoth { get; set; }
}
