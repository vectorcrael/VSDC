using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblNotify")]
[Index("RtblNotifyChecksum", Name = "idx__rtblNotify__rtblNotify_Checksum")]
[Index("RtblNotifyIChangeSetId", Name = "idx__rtblNotify_iChangeSetID")]
[Index("RtblNotifyDModifiedDate", Name = "idx_rtblNotify_dModifiedDate")]
[Index("RtblNotifyIBranchId", Name = "idx_rtblNotify_iBranchID")]
public partial class RtblNotify
{
    [Key]
    [Column("idNotify")]
    public int IdNotify { get; set; }

    [Column("dNotifyDate", TypeName = "datetime")]
    public DateTime? DNotifyDate { get; set; }

    [Column("iForAgentID")]
    public int IForAgentId { get; set; }

    [Column("iIncidentID")]
    public int? IIncidentId { get; set; }

    [Column("iIncidentLogID")]
    public int? IIncidentLogId { get; set; }

    [Column("bRead")]
    public bool BRead { get; set; }

    [Column("_rtblNotify_iBranchID")]
    public int? RtblNotifyIBranchId { get; set; }

    [Column("_rtblNotify_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblNotifyDCreatedDate { get; set; }

    [Column("_rtblNotify_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblNotifyDModifiedDate { get; set; }

    [Column("_rtblNotify_iCreatedBranchID")]
    public int? RtblNotifyICreatedBranchId { get; set; }

    [Column("_rtblNotify_iModifiedBranchID")]
    public int? RtblNotifyIModifiedBranchId { get; set; }

    [Column("_rtblNotify_iCreatedAgentID")]
    public int? RtblNotifyICreatedAgentId { get; set; }

    [Column("_rtblNotify_iModifiedAgentID")]
    public int? RtblNotifyIModifiedAgentId { get; set; }

    [Column("_rtblNotify_iChangeSetID")]
    public int? RtblNotifyIChangeSetId { get; set; }

    [Column("iWhseIBTID")]
    public int? IWhseIbtid { get; set; }

    [Column("_rtblNotify_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblNotifyChecksum { get; set; }
}
