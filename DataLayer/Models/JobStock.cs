using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("JobStock")]
[Index("JobStockDModifiedDate", Name = "idxJobStock_dModifiedDate")]
[Index("JobStockIBranchId", Name = "idxJobStock_iBranchID")]
[Index("JobStockChecksum", Name = "idx_JobStock_JobStock_Checksum")]
[Index("JobStockIChangeSetId", Name = "idx_JobStock_iChangeSetID")]
public partial class JobStock
{
    [Column("JobStock")]
    public int JobStock1 { get; set; }

    [Column("iJobStockGroupID")]
    public int? IJobStockGroupId { get; set; }

    public int? StockItemLink { get; set; }

    [Column("UOM")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Uom { get; set; }

    public double? QtyIssued { get; set; }

    public double? QtyIssuedInvoiced { get; set; }

    public double? QtyIssuedToInvoice { get; set; }

    public double? QtyIssuedAvailable { get; set; }

    public double QtyIssuedAdjusted { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    public double? CostPrice { get; set; }

    public double? Discount { get; set; }

    public double? SellPriceExcl { get; set; }

    public double? SellPriceIncl { get; set; }

    public double? TaxRate { get; set; }

    public double? LineTotExcl { get; set; }

    public double? LineTotIncl { get; set; }

    public double? LineTotTax { get; set; }

    public double? LineTotExclToInvoice { get; set; }

    public double? LineTotInclToInvoice { get; set; }

    public double? LineTotTaxToInvoice { get; set; }

    public double? LineTotCost { get; set; }

    [Column("WarehouseID")]
    public int? WarehouseId { get; set; }

    [Column("iSerialNumberGroupID")]
    public int? ISerialNumberGroupId { get; set; }

    public double? ExchangeRate { get; set; }

    public double? SellPriceExclForeign { get; set; }

    public double? SellPriceInclForeign { get; set; }

    public double? LineTotExclForeign { get; set; }

    public double? LineTotInclForeign { get; set; }

    public double? LineTotTaxForeign { get; set; }

    public double? LineTotExclForeignToInvoice { get; set; }

    public double? LineTotInclForeignToInvoice { get; set; }

    public double? LineTotTaxForeignToInvoice { get; set; }

    [Column("JobStock_iBranchID")]
    public int? JobStockIBranchId { get; set; }

    [Column("JobStock_dCreatedDate", TypeName = "datetime")]
    public DateTime? JobStockDCreatedDate { get; set; }

    [Column("JobStock_dModifiedDate", TypeName = "datetime")]
    public DateTime? JobStockDModifiedDate { get; set; }

    [Column("JobStock_iCreatedBranchID")]
    public int? JobStockICreatedBranchId { get; set; }

    [Column("JobStock_iModifiedBranchID")]
    public int? JobStockIModifiedBranchId { get; set; }

    [Column("JobStock_iCreatedAgentID")]
    public int? JobStockICreatedAgentId { get; set; }

    [Column("JobStock_iModifiedAgentID")]
    public int? JobStockIModifiedAgentId { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("JobStock_iChangeSetID")]
    public int? JobStockIChangeSetId { get; set; }

    [Column("JobStock_Checksum")]
    [MaxLength(20)]
    public byte[]? JobStockChecksum { get; set; }
}
