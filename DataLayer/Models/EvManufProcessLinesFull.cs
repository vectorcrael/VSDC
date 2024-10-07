using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvManufProcessLinesFull
{
    [Column("idManufProcessLine")]
    public long IdManufProcessLine { get; set; }

    [Column("iManufProcessID")]
    public int IManufProcessId { get; set; }

    public int LineAction { get; set; }

    [Column("LineLotID")]
    public int? LineLotId { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string LineActionDesc { get; set; } = null!;

    public int LineLineNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LineReference { get; set; }

    [Column("LineMFPItemID")]
    public double? LineMfpitemId { get; set; }

    [Column("LineInvItemID")]
    public int LineInvItemId { get; set; }

    [Column("LineWarehouseID")]
    public int? LineWarehouseId { get; set; }

    [Column("LineNewInvItemID")]
    public int? LineNewInvItemId { get; set; }

    [Column("LineNewWarehouseID")]
    public int? LineNewWarehouseId { get; set; }

    public double? LineQuantity { get; set; }

    public double? LineCost { get; set; }

    public bool LineProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LineTransactionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LineLastUpdateDate { get; set; }

    public double? LineQtyAvailable { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? LineDescription { get; set; }

    public int LinePickingSlipPrinted { get; set; }

    public int LineUnmanufactureLineNo { get; set; }

    public int LineDocVersion { get; set; }

    public double LineTotalCost { get; set; }

    [Column("ManufProcessID")]
    public int? ManufProcessId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ManufStatus { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string ManufStatusDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ManufProcessRefNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ManufOtherRefNumber { get; set; }

    [Column("ManufBomMasterID")]
    public int? ManufBomMasterId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ManufDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ManufCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ManufLastUpdatedDate { get; set; }

    public double? ManufQuantity { get; set; }

    public double? ManufQtyManufactured { get; set; }

    [Column("ManufProjectID")]
    public int? ManufProjectId { get; set; }

    [Column("ManufWarehouseID")]
    public int? ManufWarehouseId { get; set; }

    public bool? ManufOverrideCompWhse { get; set; }

    [Column("ManufInvoiceLineID")]
    public long? ManufInvoiceLineId { get; set; }

    public bool? ManufIsLinkedToOrder { get; set; }

    [Column("ManufInvNumID")]
    public int? ManufInvNumId { get; set; }

    [Column("ManufJCMasterID")]
    public int? ManufJcmasterId { get; set; }

    public double? ManufLeadDays { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualCompletionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProjectedCompletionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    public double? ManufQtyStillToManuf { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    public bool? ActiveProject { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LineWarehouse { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ManufWarehouse { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LineItemCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvNumber { get; set; }

    [Column("MFPItemDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MfpitemDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LineNewItemCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LineNewWarehouse { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LineLotNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LineLotExpiryDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LineBinLocationName { get; set; }

    [Column("StkItem_iBranchID")]
    public int? StkItemIBranchId { get; set; }

    [Column("idManufProcess")]
    public int? IdManufProcess { get; set; }

    [Column("iStatus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IStatus { get; set; }

    [Column("cProcessRefNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CProcessRefNumber { get; set; }

    [Column("cOtherRefNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COtherRefNumber { get; set; }

    [Column("iBOMMasterID")]
    public int? IBommasterId { get; set; }

    [Column("cManufDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CManufDescription { get; set; }

    [Column("dCreated", TypeName = "datetime")]
    public DateTime? DCreated { get; set; }

    [Column("dLastUpdated", TypeName = "datetime")]
    public DateTime? DLastUpdated { get; set; }

    [Column("fManufQuantity")]
    public double? FManufQuantity { get; set; }

    [Column("fQtyManufactured")]
    public double? FQtyManufactured { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("iManufWarehouseID")]
    public int? IManufWarehouseId { get; set; }

    [Column("bOverrideCompWhse")]
    public bool? BOverrideCompWhse { get; set; }

    [Column("iInvoiceLineID")]
    public long? IInvoiceLineId { get; set; }

    [Column("bIsLinkedToOrder")]
    public bool? BIsLinkedToOrder { get; set; }

    [Column("iInvNumID")]
    public int? IInvNumId { get; set; }

    [Column("iJCMasterID")]
    public int? IJcmasterId { get; set; }

    [Column("_etblManufProcess_iBranchID")]
    public int? EtblManufProcessIBranchId { get; set; }

    [Column("_etblManufProcess_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblManufProcessDCreatedDate { get; set; }

    [Column("_etblManufProcess_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblManufProcessDModifiedDate { get; set; }

    [Column("_etblManufProcess_iCreatedBranchID")]
    public int? EtblManufProcessICreatedBranchId { get; set; }

    [Column("_etblManufProcess_iModifiedBranchID")]
    public int? EtblManufProcessIModifiedBranchId { get; set; }

    [Column("_etblManufProcess_iCreatedAgentID")]
    public int? EtblManufProcessICreatedAgentId { get; set; }

    [Column("_etblManufProcess_iModifiedAgentID")]
    public int? EtblManufProcessIModifiedAgentId { get; set; }

    [Column("_etblManufProcess_iChangeSetID")]
    public int? EtblManufProcessIChangeSetId { get; set; }

    [Column("dProjectedCompletionDate", TypeName = "datetime")]
    public DateTime? DProjectedCompletionDate { get; set; }

    [Column("dActualCompletionDate", TypeName = "datetime")]
    public DateTime? DActualCompletionDate { get; set; }

    [Column("_etblManufProcess_fLeadDays")]
    public double? EtblManufProcessFLeadDays { get; set; }

    [Column("_etblManufProcess_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblManufProcessChecksum { get; set; }

    [Column("BomID")]
    public int? BomId { get; set; }

    public int? BomStockLink { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BomStockCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BomDescription { get; set; }

    public double? BomProductionQty { get; set; }

    public double? BomUnitCost { get; set; }

    public double? ThisLevelCost { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DateLastCosted { get; set; }

    [Column("bBreakOnGrv")]
    public bool? BBreakOnGrv { get; set; }

    [Column("bBreakAllocCostsbyPerc")]
    public bool? BBreakAllocCostsbyPerc { get; set; }

    [Column("bShowComponentsOnGRV")]
    public bool? BShowComponentsOnGrv { get; set; }

    [Column("bShowAvailAllLevels")]
    public bool? BShowAvailAllLevels { get; set; }

    [Column("bShowCompOnInv")]
    public bool? BShowCompOnInv { get; set; }

    [Column("bManufWithDefaultWH")]
    public bool? BManufWithDefaultWh { get; set; }

    [Column("bBreakUpWithDefaultWH")]
    public bool? BBreakUpWithDefaultWh { get; set; }

    [Column("bAllowOverUnderManufacture")]
    public bool? BAllowOverUnderManufacture { get; set; }

    [Column("BomMast_iBranchID")]
    public int? BomMastIBranchId { get; set; }

    [Column("BomMast_dCreatedDate", TypeName = "datetime")]
    public DateTime? BomMastDCreatedDate { get; set; }

    [Column("BomMast_dModifiedDate", TypeName = "datetime")]
    public DateTime? BomMastDModifiedDate { get; set; }

    [Column("BomMast_iCreatedBranchID")]
    public int? BomMastICreatedBranchId { get; set; }

    [Column("BomMast_iModifiedBranchID")]
    public int? BomMastIModifiedBranchId { get; set; }

    [Column("BomMast_iCreatedAgentID")]
    public int? BomMastICreatedAgentId { get; set; }

    [Column("BomMast_iModifiedAgentID")]
    public int? BomMastIModifiedAgentId { get; set; }

    [Column("BomMast_iChangeSetID")]
    public int? BomMastIChangeSetId { get; set; }

    [Column("BomMast_fLeadDays")]
    public double? BomMastFLeadDays { get; set; }

    [Column("BomMast_Checksum")]
    [MaxLength(20)]
    public byte[]? BomMastChecksum { get; set; }

    [Column("bExplodeOnDocument")]
    public bool? BExplodeOnDocument { get; set; }
}
