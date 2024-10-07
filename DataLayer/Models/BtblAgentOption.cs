using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblAgentOptions")]
[Index("BtblAgentOptionsChecksum", Name = "idx__btblAgentOptions__btblAgentOptions_Checksum")]
[Index("BtblAgentOptionsIChangeSetId", Name = "idx__btblAgentOptions_iChangeSetID")]
[Index("BtblAgentOptionsDModifiedDate", Name = "idx_btblAgentOptions_dModifiedDate")]
[Index("BtblAgentOptionsIBranchId", Name = "idx_btblAgentOptions_iBranchID")]
public partial class BtblAgentOption
{
    [Key]
    [Column("IDAgentOptions")]
    public int IdagentOptions { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("iCalTimeFormat")]
    public int? ICalTimeFormat { get; set; }

    [Column("iCalDVDaysVisible")]
    public int? ICalDvdaysVisible { get; set; }

    [Column("iCalDVTimeInterval")]
    public int? ICalDvtimeInterval { get; set; }

    [Column("bCalDVShowWeekends")]
    public bool BCalDvshowWeekends { get; set; }

    [Column("bCalWVShowEventTimes")]
    public bool BCalWvshowEventTimes { get; set; }

    [Column("bCalMVShowEvents")]
    public bool BCalMvshowEvents { get; set; }

    [Column("bCalMVShowEventTimes")]
    public bool BCalMvshowEventTimes { get; set; }

    [Column("bAlarmSet")]
    public bool BAlarmSet { get; set; }

    [Column("iAlarmAdvance")]
    public int? IAlarmAdvance { get; set; }

    [Column("iAlarmAdvanceType")]
    public int? IAlarmAdvanceType { get; set; }

    [Column("cDingPath")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CDingPath { get; set; }

    [Column("bShowContactPerson")]
    public bool BShowContactPerson { get; set; }

    [Column("bShowIncTypeGroup")]
    public bool BShowIncTypeGroup { get; set; }

    [Column("bShowWorkflow")]
    public bool BShowWorkflow { get; set; }

    [Column("bShowEscGroup")]
    public bool BShowEscGroup { get; set; }

    [Column("bShowInvItem")]
    public bool BShowInvItem { get; set; }

    [Column("bShowSupplier")]
    public bool BShowSupplier { get; set; }

    [Column("bShowWorker")]
    public bool BShowWorker { get; set; }

    [Column("bShowFixedAssets")]
    public bool BShowFixedAssets { get; set; }

    [Column("bShowProject")]
    public bool BShowProject { get; set; }

    [Column("bShowJobCosting")]
    public bool BShowJobCosting { get; set; }

    [Column("bShowProspect")]
    public bool BShowProspect { get; set; }

    [Column("bShowOpportunity")]
    public bool? BShowOpportunity { get; set; }

    [Column("_btblAgentOptions_iBranchID")]
    public int? BtblAgentOptionsIBranchId { get; set; }

    [Column("_btblAgentOptions_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblAgentOptionsDCreatedDate { get; set; }

    [Column("_btblAgentOptions_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblAgentOptionsDModifiedDate { get; set; }

    [Column("_btblAgentOptions_iCreatedBranchID")]
    public int? BtblAgentOptionsICreatedBranchId { get; set; }

    [Column("_btblAgentOptions_iModifiedBranchID")]
    public int? BtblAgentOptionsIModifiedBranchId { get; set; }

    [Column("_btblAgentOptions_iCreatedAgentID")]
    public int? BtblAgentOptionsICreatedAgentId { get; set; }

    [Column("_btblAgentOptions_iModifiedAgentID")]
    public int? BtblAgentOptionsIModifiedAgentId { get; set; }

    [Column("_btblAgentOptions_iChangeSetID")]
    public int? BtblAgentOptionsIChangeSetId { get; set; }

    [Column("_btblAgentOptions_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblAgentOptionsChecksum { get; set; }
}
