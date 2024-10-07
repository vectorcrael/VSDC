using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblLotTrackingTx")]
[Index("EtblLotTrackingTxChecksum", Name = "idx__etblLotTrackingTx__etblLotTrackingTx_Checksum")]
[Index("EtblLotTrackingTxIChangeSetId", Name = "idx__etblLotTrackingTx_iChangeSetID")]
[Index("EtblLotTrackingTxDModifiedDate", Name = "idx_etblLotTrackingTx_dModifiedDate")]
[Index("EtblLotTrackingTxIBranchId", Name = "idx_etblLotTrackingTx_iBranchID")]
public partial class EtblLotTrackingTx
{
    [Key]
    [Column("idLotTrackingTx")]
    public long IdLotTrackingTx { get; set; }

    [Column("iLotTrackingID")]
    public int? ILotTrackingId { get; set; }

    [Column("dLTTxDate", TypeName = "datetime")]
    public DateTime? DLttxDate { get; set; }

    [Column("iLTTxAccountID")]
    public int? ILttxAccountId { get; set; }

    [Column("cLTTxReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLttxReference { get; set; }

    [Column("cLTTxReference2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLttxReference2 { get; set; }

    [Column("iLTTxTrCodeID")]
    public int? ILttxTrCodeId { get; set; }

    [Column("iLTTxTransTypeID")]
    public int? ILttxTransTypeId { get; set; }

    [Column("iLTTxWarehouseID")]
    public int? ILttxWarehouseId { get; set; }

    [Column("cLTTxAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLttxAuditNumber { get; set; }

    [Column("dLTTxExpiryDate", TypeName = "datetime")]
    public DateTime? DLttxExpiryDate { get; set; }

    [Column("iLTTxStatusID")]
    public int? ILttxStatusId { get; set; }

    [Column("fLTTxQty")]
    public double? FLttxQty { get; set; }

    [Column("_etblLotTrackingTx_iBranchID")]
    public int? EtblLotTrackingTxIBranchId { get; set; }

    [Column("_etblLotTrackingTx_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblLotTrackingTxDCreatedDate { get; set; }

    [Column("_etblLotTrackingTx_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblLotTrackingTxDModifiedDate { get; set; }

    [Column("_etblLotTrackingTx_iCreatedBranchID")]
    public int? EtblLotTrackingTxICreatedBranchId { get; set; }

    [Column("_etblLotTrackingTx_iModifiedBranchID")]
    public int? EtblLotTrackingTxIModifiedBranchId { get; set; }

    [Column("_etblLotTrackingTx_iCreatedAgentID")]
    public int? EtblLotTrackingTxICreatedAgentId { get; set; }

    [Column("_etblLotTrackingTx_iModifiedAgentID")]
    public int? EtblLotTrackingTxIModifiedAgentId { get; set; }

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

    [Column("_etblLotTrackingTx_iChangeSetID")]
    public int? EtblLotTrackingTxIChangeSetId { get; set; }

    [Column("_etblLotTrackingTx_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblLotTrackingTxChecksum { get; set; }
}
