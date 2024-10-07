using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFaassetTracking
{
    [Column("idAssetTracking")]
    public int IdAssetTracking { get; set; }

    [Column("cAssetTrackingNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAssetTrackingNo { get; set; }

    [Column("cDescription")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("dPrepared", TypeName = "datetime")]
    public DateTime? DPrepared { get; set; }

    [Column("cReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("cStartAssetCode")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CStartAssetCode { get; set; }

    [Column("cEndAssetCode")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CEndAssetCode { get; set; }

    [Column("iCount")]
    public int ICount { get; set; }

    [Column("iUncounted")]
    public int IUncounted { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("cLocations")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLocations { get; set; }

    [Column("bDeleteAftComplete")]
    public bool BDeleteAftComplete { get; set; }

    [Column("bCompleted")]
    public bool BCompleted { get; set; }

    [Column("_btblFAAssetTracking_iBranchID")]
    public int? BtblFaassetTrackingIBranchId { get; set; }

    [Column("_btblFAAssetTracking_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetTrackingDCreatedDate { get; set; }

    [Column("_btblFAAssetTracking_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetTrackingDModifiedDate { get; set; }

    [Column("_btblFAAssetTracking_iCreatedBranchID")]
    public int? BtblFaassetTrackingICreatedBranchId { get; set; }

    [Column("_btblFAAssetTracking_iModifiedBranchID")]
    public int? BtblFaassetTrackingIModifiedBranchId { get; set; }

    [Column("_btblFAAssetTracking_iCreatedAgentID")]
    public int? BtblFaassetTrackingICreatedAgentId { get; set; }

    [Column("_btblFAAssetTracking_iModifiedAgentID")]
    public int? BtblFaassetTrackingIModifiedAgentId { get; set; }

    [Column("_btblFAAssetTracking_iChangeSetID")]
    public int? BtblFaassetTrackingIChangeSetId { get; set; }

    [Column("_btblFAAssetTracking_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaassetTrackingChecksum { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }
}
