using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvWhseIbtline
{
    [Column("IDWhseIBTLines")]
    public int IdwhseIbtlines { get; set; }

    [Column("iWhseIBTID")]
    public int? IWhseIbtid { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("bIsSerialItem")]
    public bool BIsSerialItem { get; set; }

    [Column("bIsLotItem")]
    public bool BIsLotItem { get; set; }

    [Column("iLotID")]
    public int? ILotId { get; set; }

    [Column("cLotNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotNumber { get; set; }

    [Column("dLotExpiryDate", TypeName = "datetime")]
    public DateTime? DLotExpiryDate { get; set; }

    [Column("fQtyIssued")]
    public double? FQtyIssued { get; set; }

    [Column("fQtyReceived")]
    public double? FQtyReceived { get; set; }

    [Column("fQtyDamaged")]
    public double? FQtyDamaged { get; set; }

    [Column("fQtyVariance")]
    public double? FQtyVariance { get; set; }

    [Column("fNewReceiveCost")]
    public double? FNewReceiveCost { get; set; }

    [Column("iSNIssuedGroupID")]
    public int? ISnissuedGroupId { get; set; }

    [Column("iSNReceivedGroupID")]
    public int? ISnreceivedGroupId { get; set; }

    [Column("iSNDamagedGroupID")]
    public int? ISndamagedGroupId { get; set; }

    [Column("iSNVarianceGroupID")]
    public int? ISnvarianceGroupId { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("fAdditionalCost")]
    public double FAdditionalCost { get; set; }

    [Column("fIssuedCost")]
    public double? FIssuedCost { get; set; }

    [Column("_etblWhseIBTLines_iBranchID")]
    public int? EtblWhseIbtlinesIBranchId { get; set; }

    [Column("_etblWhseIBTLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWhseIbtlinesDCreatedDate { get; set; }

    [Column("_etblWhseIBTLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWhseIbtlinesDModifiedDate { get; set; }

    [Column("_etblWhseIBTLines_iCreatedBranchID")]
    public int? EtblWhseIbtlinesICreatedBranchId { get; set; }

    [Column("_etblWhseIBTLines_iModifiedBranchID")]
    public int? EtblWhseIbtlinesIModifiedBranchId { get; set; }

    [Column("_etblWhseIBTLines_iCreatedAgentID")]
    public int? EtblWhseIbtlinesICreatedAgentId { get; set; }

    [Column("_etblWhseIBTLines_iModifiedAgentID")]
    public int? EtblWhseIbtlinesIModifiedAgentId { get; set; }

    [Column("_etblWhseIBTLines_iChangeSetID")]
    public int? EtblWhseIbtlinesIChangeSetId { get; set; }

    [Column("iUnitsOfMeasureStockingID")]
    public int? IUnitsOfMeasureStockingId { get; set; }

    [Column("iUnitsOfMeasureCategoryID")]
    public int? IUnitsOfMeasureCategoryId { get; set; }

    [Column("iUnitsOfMeasureID")]
    public int? IUnitsOfMeasureId { get; set; }

    [Column("fQtyOverDelivered")]
    public double FQtyOverDelivered { get; set; }

    [Column("fQtyRequired")]
    public double FQtyRequired { get; set; }

    [Column("fQtyApproved")]
    public double FQtyApproved { get; set; }

    [Column("iReqLineStatus")]
    public int? IReqLineStatus { get; set; }

    [Column("_etblWhseIBTLines_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWhseIbtlinesChecksum { get; set; }

    [Column("UOMUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? UomunitCode { get; set; }

    [Column("UOMUnitDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UomunitDescription { get; set; }

    public int? ProjectLink { get; set; }

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

    [StringLength(41)]
    [Unicode(false)]
    public string? MasterSubProject { get; set; }

    public int? ProjectLevel { get; set; }

    public int? SubProjectOfLink { get; set; }

    [Column("Project_iBranchID")]
    public int? ProjectIBranchId { get; set; }

    [Column("Project_dCreatedDate", TypeName = "datetime")]
    public DateTime? ProjectDCreatedDate { get; set; }

    [Column("Project_dModifiedDate", TypeName = "datetime")]
    public DateTime? ProjectDModifiedDate { get; set; }

    [Column("Project_iCreatedBranchID")]
    public int? ProjectICreatedBranchId { get; set; }

    [Column("Project_iModifiedBranchID")]
    public int? ProjectIModifiedBranchId { get; set; }

    [Column("Project_iCreatedAgentID")]
    public int? ProjectICreatedAgentId { get; set; }

    [Column("Project_iModifiedAgentID")]
    public int? ProjectIModifiedAgentId { get; set; }

    [Column("Project_iChangeSetID")]
    public int? ProjectIChangeSetId { get; set; }

    [Column("Project_Checksum")]
    [MaxLength(20)]
    public byte[]? ProjectChecksum { get; set; }
}
