using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblWorkCal")]
[Index("RtblWorkCalChecksum", Name = "idx__rtblWorkCal__rtblWorkCal_Checksum")]
[Index("RtblWorkCalIChangeSetId", Name = "idx__rtblWorkCal_iChangeSetID")]
[Index("RtblWorkCalDModifiedDate", Name = "idx_rtblWorkCal_dModifiedDate")]
[Index("RtblWorkCalIBranchId", Name = "idx_rtblWorkCal_iBranchID")]
public partial class RtblWorkCal
{
    [Key]
    [Column("idWorkCal")]
    public int IdWorkCal { get; set; }

    [Column("iStartTime")]
    public int IStartTime { get; set; }

    [Column("iEndTime")]
    public int IEndTime { get; set; }

    [Column("cDescription")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bSunday")]
    public bool BSunday { get; set; }

    [Column("bMonday")]
    public bool BMonday { get; set; }

    [Column("bTuesday")]
    public bool BTuesday { get; set; }

    [Column("bWednesday")]
    public bool BWednesday { get; set; }

    [Column("bThursday")]
    public bool BThursday { get; set; }

    [Column("bFriday")]
    public bool BFriday { get; set; }

    [Column("bSaturday")]
    public bool BSaturday { get; set; }

    [Column("_rtblWorkCal_iBranchID")]
    public int? RtblWorkCalIBranchId { get; set; }

    [Column("_rtblWorkCal_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblWorkCalDCreatedDate { get; set; }

    [Column("_rtblWorkCal_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblWorkCalDModifiedDate { get; set; }

    [Column("_rtblWorkCal_iCreatedBranchID")]
    public int? RtblWorkCalICreatedBranchId { get; set; }

    [Column("_rtblWorkCal_iModifiedBranchID")]
    public int? RtblWorkCalIModifiedBranchId { get; set; }

    [Column("_rtblWorkCal_iCreatedAgentID")]
    public int? RtblWorkCalICreatedAgentId { get; set; }

    [Column("_rtblWorkCal_iModifiedAgentID")]
    public int? RtblWorkCalIModifiedAgentId { get; set; }

    [Column("_rtblWorkCal_iChangeSetID")]
    public int? RtblWorkCalIChangeSetId { get; set; }

    [Column("_rtblWorkCal_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblWorkCalChecksum { get; set; }
}
