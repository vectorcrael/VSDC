using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvCmevent
{
    [Column("idEvent")]
    public int IdEvent { get; set; }

    [Column("dStartTime", TypeName = "datetime")]
    public DateTime? DStartTime { get; set; }

    [Column("dEndTime", TypeName = "datetime")]
    public DateTime? DEndTime { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("cDescription")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bAllDayEvent")]
    public bool BAllDayEvent { get; set; }

    [Column("iRepeatCode")]
    public int? IRepeatCode { get; set; }

    [Column("dRepeatRangeEnd", TypeName = "datetime")]
    public DateTime? DRepeatRangeEnd { get; set; }

    [Column("iCustomInterval")]
    public int? ICustomInterval { get; set; }

    [Column("iIncidentID")]
    public int? IIncidentId { get; set; }

    [Column("cEventOutline")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CEventOutline { get; set; }

    [Column("_btblCMEvent_iBranchID")]
    public int? BtblCmeventIBranchId { get; set; }

    [Column("_btblCMEvent_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCmeventDCreatedDate { get; set; }

    [Column("_btblCMEvent_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCmeventDModifiedDate { get; set; }

    [Column("_btblCMEvent_iCreatedBranchID")]
    public int? BtblCmeventICreatedBranchId { get; set; }

    [Column("_btblCMEvent_iModifiedBranchID")]
    public int? BtblCmeventIModifiedBranchId { get; set; }

    [Column("_btblCMEvent_iCreatedAgentID")]
    public int? BtblCmeventICreatedAgentId { get; set; }

    [Column("_btblCMEvent_iModifiedAgentID")]
    public int? BtblCmeventIModifiedAgentId { get; set; }

    [Column("_btblCMEvent_iChangeSetID")]
    public int? BtblCmeventIChangeSetId { get; set; }

    [Column("_btblCMEvent_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCmeventChecksum { get; set; }

    [Column("cIncidentRef")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CIncidentRef { get; set; }

    [Column("cIncidentOutline")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CIncidentOutline { get; set; }
}
