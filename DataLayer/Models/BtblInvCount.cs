using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvCount")]
[Index("BtblInvCountChecksum", Name = "idx__btblInvCount__btblInvCount_Checksum")]
[Index("BtblInvCountIChangeSetId", Name = "idx__btblInvCount_iChangeSetID")]
[Index("BtblInvCountDModifiedDate", Name = "idx_btblInvCount_dModifiedDate")]
[Index("BtblInvCountIBranchId", Name = "idx_btblInvCount_iBranchID")]
public partial class BtblInvCount
{
    [Key]
    [Column("idInvCount")]
    public int IdInvCount { get; set; }

    [Column("cInvCountNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CInvCountNo { get; set; }

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

    [Column("cStartCode")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CStartCode { get; set; }

    [Column("cEndCode")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CEndCode { get; set; }

    [Column("cGroups")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CGroups { get; set; }

    [Column("cPacks")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CPacks { get; set; }

    [Column("bIgnoreZero")]
    public bool BIgnoreZero { get; set; }

    [Column("bIgnoreInactive")]
    public bool BIgnoreInactive { get; set; }

    [Column("iCount")]
    public int ICount { get; set; }

    [Column("iUncounted")]
    public int IUncounted { get; set; }

    [Column("iGroupBy")]
    public int IGroupBy { get; set; }

    [Column("iSortBy")]
    public int ISortBy { get; set; }

    [Column("bIncludeSystemQty")]
    public bool BIncludeSystemQty { get; set; }

    [Column("cWarehouses")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CWarehouses { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("cBinLocations")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CBinLocations { get; set; }

    [Column("iStartBinLocationID")]
    public int? IStartBinLocationId { get; set; }

    [Column("iEndBinLocationID")]
    public int? IEndBinLocationId { get; set; }

    [Column("cInventoryTypes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CInventoryTypes { get; set; }

    [Column("cLotStatus")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLotStatus { get; set; }

    [Column("bIncludeJCWIP")]
    public bool BIncludeJcwip { get; set; }

    [Column("bIncludeMFWIP")]
    public bool BIncludeMfwip { get; set; }

    [Column("bIncludeOrdResQty")]
    public bool BIncludeOrdResQty { get; set; }

    [Column("bDeleteAftComplete")]
    public bool BDeleteAftComplete { get; set; }

    [Column("_btblInvCount_iBranchID")]
    public int? BtblInvCountIBranchId { get; set; }

    [Column("_btblInvCount_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountDCreatedDate { get; set; }

    [Column("_btblInvCount_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvCountDModifiedDate { get; set; }

    [Column("_btblInvCount_iCreatedBranchID")]
    public int? BtblInvCountICreatedBranchId { get; set; }

    [Column("_btblInvCount_iModifiedBranchID")]
    public int? BtblInvCountIModifiedBranchId { get; set; }

    [Column("_btblInvCount_iCreatedAgentID")]
    public int? BtblInvCountICreatedAgentId { get; set; }

    [Column("_btblInvCount_iModifiedAgentID")]
    public int? BtblInvCountIModifiedAgentId { get; set; }

    [Column("_btblInvCount_iChangeSetID")]
    public int? BtblInvCountIChangeSetId { get; set; }

    [Column("bIncludeDelivery")]
    public bool BIncludeDelivery { get; set; }

    [Column("bSpotCount")]
    public bool BSpotCount { get; set; }

    [Column("bScheduledCount")]
    public bool BScheduledCount { get; set; }

    [Column("dScheduledDate", TypeName = "datetime")]
    public DateTime? DScheduledDate { get; set; }

    [Column("iStatus")]
    public int? IStatus { get; set; }

    [Column("bForceCapture")]
    public bool BForceCapture { get; set; }

    [Column("cGroupsChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CGroupsChkLstInd { get; set; }

    [Column("cPacksChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CPacksChkLstInd { get; set; }

    [Column("cWarehousesChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CWarehousesChkLstInd { get; set; }

    [Column("cBinLocationsChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CBinLocationsChkLstInd { get; set; }

    [Column("cInventoryTypesChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CInventoryTypesChkLstInd { get; set; }

    [Column("cLotStatusChkLstInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CLotStatusChkLstInd { get; set; }

    [Column("bTakeSnapshot")]
    public bool? BTakeSnapshot { get; set; }

    [Column("cBinFromCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBinFromCode { get; set; }

    [Column("cBinToCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CBinToCode { get; set; }

    [Column("_btblInvCount_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvCountChecksum { get; set; }
}
