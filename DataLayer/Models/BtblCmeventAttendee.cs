using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCMEventAttendees")]
[Index("BtblCmeventAttendeesChecksum", Name = "idx__btblCMEventAttendees__btblCMEventAttendees_Checksum")]
[Index("BtblCmeventAttendeesIChangeSetId", Name = "idx__btblCMEventAttendees_iChangeSetID")]
[Index("BtblCmeventAttendeesDModifiedDate", Name = "idx_btblCMEventAttendees_dModifiedDate")]
[Index("BtblCmeventAttendeesIBranchId", Name = "idx_btblCMEventAttendees_iBranchID")]
public partial class BtblCmeventAttendee
{
    [Column("iEventID")]
    public int IEventId { get; set; }

    [Column("iAttendeeID")]
    public int IAttendeeId { get; set; }

    [Column("cAttendeeType")]
    [StringLength(1)]
    [Unicode(false)]
    public string CAttendeeType { get; set; } = null!;

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
    public bool BAlarmSet { get; set; }

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

    [Key]
    [Column("idCMEventAttendees")]
    public int IdCmeventAttendees { get; set; }

    [Column("_btblCMEventAttendees_iChangeSetID")]
    public int? BtblCmeventAttendeesIChangeSetId { get; set; }

    [Column("_btblCMEventAttendees_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCmeventAttendeesChecksum { get; set; }
}
