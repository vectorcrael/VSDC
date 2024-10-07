using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblWhseIBTLines")]
[Index("EtblWhseIbtlinesChecksum", Name = "idx__etblWhseIBTLines__etblWhseIBTLines_Checksum")]
[Index("EtblWhseIbtlinesIChangeSetId", Name = "idx__etblWhseIBTLines_iChangeSetID")]
[Index("EtblWhseIbtlinesDModifiedDate", Name = "idx_etblWhseIBTLines_dModifiedDate")]
[Index("EtblWhseIbtlinesIBranchId", Name = "idx_etblWhseIBTLines_iBranchID")]
public partial class EtblWhseIbtline
{
    [Key]
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
}
