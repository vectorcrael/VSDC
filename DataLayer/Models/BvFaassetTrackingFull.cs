using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFaassetTrackingFull
{
    [Column("idAssetTrackingLines")]
    public int IdAssetTrackingLines { get; set; }

    [Column("iAssetTrackingID")]
    public int IAssetTrackingId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string ActualAssetCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ActualSerialNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ActualBarCode { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ActualLocationCode { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string? ActualLocationDesc { get; set; }

    public double ActualCount { get; set; }

    [Column("bModified")]
    public bool BModified { get; set; }

    public int? TrackingStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TrackingStatusDesc { get; set; }

    public int? TrackingDifference { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string? TrackingDifferenceDesc { get; set; }

    public int? TrackingAdjustment { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string? TrackingAdjustmentDesc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string SystemAssetCode { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string SystemAssetDesc { get; set; } = null!;

    [Column("SystemUnitNoID")]
    public int SystemUnitNoId { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string SystemSerialNo { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string SystemBarCode { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string SystemLocationCode { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string SystemLocationDesc { get; set; } = null!;

    public double TotalSystemCount { get; set; }

    public int SystemCount { get; set; }

    public double PurchaseValue { get; set; }

    public double RevalueValue { get; set; }
}
