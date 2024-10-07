using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvJcinvoiceLinesFull
{
    [Column("idJCInvoiceLines")]
    public long IdJcinvoiceLines { get; set; }

    [Column("iJobNumID")]
    public int IJobNumId { get; set; }

    [Column("iJobTxTpID")]
    public int? IJobTxTpId { get; set; }

    [Column("bAdded")]
    public bool BAdded { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("iSupplierID")]
    public int? ISupplierId { get; set; }

    [Column("iLedgerID")]
    public int? ILedgerId { get; set; }

    [Column("iEmployeeId")]
    public int? IEmployeeId { get; set; }

    [Column("cDescription")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("fQuantity")]
    public double? FQuantity { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    [Column("fUnitPriceExcl")]
    public double? FUnitPriceExcl { get; set; }

    [Column("fUnitPriceIncl")]
    public double? FUnitPriceIncl { get; set; }

    [Column("fUnitCost")]
    public double? FUnitCost { get; set; }

    [Column("fLineDiscount")]
    public double? FLineDiscount { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("fTaxRate")]
    public double? FTaxRate { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("iPriceListNameID")]
    public int? IPriceListNameId { get; set; }

    [Column("fLineTotIncl")]
    public double? FLineTotIncl { get; set; }

    [Column("fLineTotExcl")]
    public double? FLineTotExcl { get; set; }

    [Column("fLineTotInclNoDisc")]
    public double? FLineTotInclNoDisc { get; set; }

    [Column("fLineTotExclNoDisc")]
    public double? FLineTotExclNoDisc { get; set; }

    [Column("fLineTotTaxAmount")]
    public double? FLineTotTaxAmount { get; set; }

    [Column("fLineTotTaxAmountNoDisc")]
    public double? FLineTotTaxAmountNoDisc { get; set; }

    [Column("iJobStockGroupID")]
    public int? IJobStockGroupId { get; set; }

    [Column("iSerialNumberGroupID")]
    public int? ISerialNumberGroupId { get; set; }

    [Column("iSource")]
    public int? ISource { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fUnitPriceExclForeign")]
    public double? FUnitPriceExclForeign { get; set; }

    [Column("fUnitPriceInclForeign")]
    public double? FUnitPriceInclForeign { get; set; }

    [Column("fLineTotInclForeign")]
    public double? FLineTotInclForeign { get; set; }

    [Column("fLineTotExclForeign")]
    public double? FLineTotExclForeign { get; set; }

    [Column("fLineTotInclNoDiscForeign")]
    public double? FLineTotInclNoDiscForeign { get; set; }

    [Column("fLineTotExclNoDiscForeign")]
    public double? FLineTotExclNoDiscForeign { get; set; }

    [Column("fLineTotTaxAmountForeign")]
    public double? FLineTotTaxAmountForeign { get; set; }

    [Column("fLineTotTaxAmountNoDiscForeign")]
    public double? FLineTotTaxAmountNoDiscForeign { get; set; }

    [Column("iLineRepID")]
    public int? ILineRepId { get; set; }

    [Column("iLineProjectID")]
    public int? ILineProjectId { get; set; }

    [Column("bChargeCom")]
    public bool BChargeCom { get; set; }

    [Column("bLotItem")]
    public bool BLotItem { get; set; }

    [Column("iLotID")]
    public int? ILotId { get; set; }

    [Column("cLotNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotNumber { get; set; }

    [Column("dLotExpiryDate", TypeName = "datetime")]
    public DateTime? DLotExpiryDate { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("iAPSettlementTermsID")]
    public int IApsettlementTermsId { get; set; }

    [Column("iInvEUNoTCID")]
    public int IInvEunoTcid { get; set; }

    [Column("iJCTxLinesID")]
    public long? IJctxLinesId { get; set; }

    [Column("_btblJCInvoiceLines_iBranchID")]
    public int? BtblJcinvoiceLinesIBranchId { get; set; }

    [Column("_btblJCInvoiceLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblJcinvoiceLinesDCreatedDate { get; set; }

    [Column("_btblJCInvoiceLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblJcinvoiceLinesDModifiedDate { get; set; }

    [Column("_btblJCInvoiceLines_iCreatedBranchID")]
    public int? BtblJcinvoiceLinesICreatedBranchId { get; set; }

    [Column("_btblJCInvoiceLines_iModifiedBranchID")]
    public int? BtblJcinvoiceLinesIModifiedBranchId { get; set; }

    [Column("_btblJCInvoiceLines_iCreatedAgentID")]
    public int? BtblJcinvoiceLinesICreatedAgentId { get; set; }

    [Column("_btblJCInvoiceLines_iModifiedAgentID")]
    public int? BtblJcinvoiceLinesIModifiedAgentId { get; set; }

    [Column("_btblJCInvoiceLines_iChangeSetID")]
    public int? BtblJcinvoiceLinesIChangeSetId { get; set; }

    [Column("_btblJCInvoiceLines_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblJcinvoiceLinesChecksum { get; set; }

    [Column("UOMStockingUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomstockingUnitCode { get; set; }

    [Column("UOMUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomunitCode { get; set; }

    [Column("UOMfStockingQuantity")]
    public double? UomfStockingQuantity { get; set; }

    [Column("UOMfStockingUnitCost")]
    public double? UomfStockingUnitCost { get; set; }

    [Column("UOMfStockingUnitPriceExcl")]
    public double? UomfStockingUnitPriceExcl { get; set; }

    [Column("UOMfStockingUnitPriceIncl")]
    public double? UomfStockingUnitPriceIncl { get; set; }

    [Column("UOMfStockingUnitPriceExclForeign")]
    public double? UomfStockingUnitPriceExclForeign { get; set; }

    [Column("UOMfStockingUnitPriceInclForeign")]
    public double? UomfStockingUnitPriceInclForeign { get; set; }

    public double? ActTxQty { get; set; }

    [Column("UOMActStockingTxQty")]
    public double? UomactStockingTxQty { get; set; }

    public double? ActUnitPriceIncl { get; set; }

    public double? ActUnitPriceExcl { get; set; }

    public double? ActUnitPriceInclForeign { get; set; }

    public double? ActUnitPriceExclForeign { get; set; }

    [Column("UOMActStockingUnitPriceIncl")]
    public double? UomactStockingUnitPriceIncl { get; set; }

    [Column("UOMActStockingUnitPriceExcl")]
    public double? UomactStockingUnitPriceExcl { get; set; }

    [Column("UOMActStockingUnitPriceInclForeign")]
    public double? UomactStockingUnitPriceInclForeign { get; set; }

    [Column("UOMActStockingUnitPriceExclForeign")]
    public double? UomactStockingUnitPriceExclForeign { get; set; }

    public double? ActLineTotalIncl { get; set; }

    public double? ActLineTotalExcl { get; set; }

    public double? ActLineTotalInclForeign { get; set; }

    public double? ActLineTotalExclForeign { get; set; }

    public double? ActLineTotalTax { get; set; }

    public double? ActLineTotalTaxForeign { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? TxTypeDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TxTypeCode { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? TxSource { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? TxSourceSort { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? TxAccount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? TxAccDescription { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemGroup { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ItemBin { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ItemPack { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemBarCode { get; set; }

    public double ItemQtyAvail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WarehouseCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WarehouseName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Supplier { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SupplierName { get; set; }

    [Column("GLAccount")]
    [StringLength(91)]
    [Unicode(false)]
    public string? Glaccount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WorkerCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkerName { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RepName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LotExpiryDate { get; set; }

    [Column("iLineID")]
    public int? ILineId { get; set; }

    [Column("iStatus")]
    public int? IStatus { get; set; }
}
