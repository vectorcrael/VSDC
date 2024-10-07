using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCmeventAttendee
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

    [Column("iEventID")]
    public int? IEventId { get; set; }

    [Column("iAttendeeID")]
    public int? IAttendeeId { get; set; }

    [Column("cAttendeeType")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CAttendeeType { get; set; }

    [Column("cAttendeeName")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CAttendeeName { get; set; }

    [Column("iResponse")]
    public int? IResponse { get; set; }

    [Column("cComment")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CComment { get; set; }

    [Column("dSnoozeTime", TypeName = "datetime")]
    public DateTime? DSnoozeTime { get; set; }

    [Column("bAlarmSet")]
    public bool? BAlarmSet { get; set; }

    [Column("iAlarmAdvance")]
    public int? IAlarmAdvance { get; set; }

    [Column("iAlarmAdvanceType")]
    public int? IAlarmAdvanceType { get; set; }

    [Column("cAlarmWavPath")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CAlarmWavPath { get; set; }

    [Column("cAttendeeEmail")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CAttendeeEmail { get; set; }

    [Column("_btblCMEventAttendees_iBranchID")]
    public int? BtblCmeventAttendeesIBranchId { get; set; }

    [Column("_btblCMEventAttendees_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCmeventAttendeesDCreatedDate { get; set; }

    [Column("_btblCMEventAttendees_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCmeventAttendeesDModifiedDate { get; set; }

    [Column("_btblCMEventAttendees_iCreatedBranchID")]
    public int? BtblCmeventAttendeesICreatedBranchId { get; set; }

    [Column("_btblCMEventAttendees_iModifiedBranchID")]
    public int? BtblCmeventAttendeesIModifiedBranchId { get; set; }

    [Column("_btblCMEventAttendees_iCreatedAgentID")]
    public int? BtblCmeventAttendeesICreatedAgentId { get; set; }

    [Column("_btblCMEventAttendees_iModifiedAgentID")]
    public int? BtblCmeventAttendeesIModifiedAgentId { get; set; }

    [Column("idCMEventAttendees")]
    public int? IdCmeventAttendees { get; set; }

    [Column("_btblCMEventAttendees_iChangeSetID")]
    public int? BtblCmeventAttendeesIChangeSetId { get; set; }

    [Column("_btblCMEventAttendees_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCmeventAttendeesChecksum { get; set; }
}
