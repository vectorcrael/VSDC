using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblLotTracking")]
[Index("EtblLotTrackingChecksum", Name = "idx__etblLotTracking__etblLotTracking_Checksum")]
[Index("EtblLotTrackingIChangeSetId", Name = "idx__etblLotTracking_iChangeSetID")]
[Index("EtblLotTrackingDModifiedDate", Name = "idx_etblLotTracking_dModifiedDate")]
[Index("EtblLotTrackingIBranchId", Name = "idx_etblLotTracking_iBranchID")]
public partial class EtblLotTracking
{
    [Key]
    [Column("idLotTracking")]
    public int IdLotTracking { get; set; }

    [Column("cLotDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotDescription { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("iLotStatusID")]
    public int? ILotStatusId { get; set; }

    [Column("dExpiryDate", TypeName = "datetime")]
    public DateTime? DExpiryDate { get; set; }

    [Column("bIsActive")]
    public bool BIsActive { get; set; }

    [Column("_etblLotTracking_iBranchID")]
    public int? EtblLotTrackingIBranchId { get; set; }

    [Column("_etblLotTracking_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblLotTrackingDCreatedDate { get; set; }

    [Column("_etblLotTracking_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblLotTrackingDModifiedDate { get; set; }

    [Column("_etblLotTracking_iCreatedBranchID")]
    public int? EtblLotTrackingICreatedBranchId { get; set; }

    [Column("_etblLotTracking_iModifiedBranchID")]
    public int? EtblLotTrackingIModifiedBranchId { get; set; }

    [Column("_etblLotTracking_iCreatedAgentID")]
    public int? EtblLotTrackingICreatedAgentId { get; set; }

    [Column("_etblLotTracking_iModifiedAgentID")]
    public int? EtblLotTrackingIModifiedAgentId { get; set; }

    [Column("_etblLotTracking_iChangeSetID")]
    public int? EtblLotTrackingIChangeSetId { get; set; }

    [Column("dLastGRVDate", TypeName = "datetime")]
    public DateTime? DLastGrvdate { get; set; }

    [Column("_etblLotTracking_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblLotTrackingChecksum { get; set; }
}
