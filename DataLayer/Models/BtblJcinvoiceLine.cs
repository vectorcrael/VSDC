using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblJCInvoiceLines")]
[Index("BtblJcinvoiceLinesChecksum", Name = "idx__btblJCInvoiceLines__btblJCInvoiceLines_Checksum")]
[Index("BtblJcinvoiceLinesIChangeSetId", Name = "idx__btblJCInvoiceLines_iChangeSetID")]
[Index("BtblJcinvoiceLinesDModifiedDate", Name = "idx_btblJCInvoiceLines_dModifiedDate")]
[Index("BtblJcinvoiceLinesIBranchId", Name = "idx_btblJCInvoiceLines_iBranchID")]
public partial class BtblJcinvoiceLine
{
    [Key]
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
}
