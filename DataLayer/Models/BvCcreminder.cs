using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCcreminder
{
    public int Autoidx { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Dated { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? TypeofRemind { get; set; }

    [Column(TypeName = "text")]
    public string? TextMemo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telephone { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RemindDate { get; set; }

    [Column("Reminder_iBranchID")]
    public int? ReminderIBranchId { get; set; }

    [Column("Reminder_dCreatedDate", TypeName = "datetime")]
    public DateTime? ReminderDCreatedDate { get; set; }

    [Column("Reminder_dModifiedDate", TypeName = "datetime")]
    public DateTime? ReminderDModifiedDate { get; set; }

    [Column("Reminder_iCreatedBranchID")]
    public int? ReminderICreatedBranchId { get; set; }

    [Column("Reminder_iModifiedBranchID")]
    public int? ReminderIModifiedBranchId { get; set; }

    [Column("Reminder_iCreatedAgentID")]
    public int? ReminderICreatedAgentId { get; set; }

    [Column("Reminder_iModifiedAgentID")]
    public int? ReminderIModifiedAgentId { get; set; }

    [Column("Reminder_iChangeSetID")]
    public int? ReminderIChangeSetId { get; set; }

    [Column("Reminder_Checksum")]
    [MaxLength(20)]
    public byte[]? ReminderChecksum { get; set; }

    [Column("COStatus")]
    [StringLength(6)]
    [Unicode(false)]
    public string Costatus { get; set; } = null!;
}
