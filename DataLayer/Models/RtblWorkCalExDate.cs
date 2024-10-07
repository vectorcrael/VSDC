using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblWorkCalExDates")]
[Index("RtblWorkCalExDatesChecksum", Name = "idx__rtblWorkCalExDates__rtblWorkCalExDates_Checksum")]
[Index("RtblWorkCalExDatesIChangeSetId", Name = "idx__rtblWorkCalExDates_iChangeSetID")]
[Index("RtblWorkCalExDatesDModifiedDate", Name = "idx_rtblWorkCalExDates_dModifiedDate")]
[Index("RtblWorkCalExDatesIBranchId", Name = "idx_rtblWorkCalExDates_iBranchID")]
public partial class RtblWorkCalExDate
{
    [Key]
    [Column("idWorkCalExDates")]
    public int IdWorkCalExDates { get; set; }

    [Column("dExDate", TypeName = "smalldatetime")]
    public DateTime DExDate { get; set; }

    [Column("bRepeat")]
    public bool BRepeat { get; set; }

    [Column("_rtblWorkCalExDates_iBranchID")]
    public int? RtblWorkCalExDatesIBranchId { get; set; }

    [Column("_rtblWorkCalExDates_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblWorkCalExDatesDCreatedDate { get; set; }

    [Column("_rtblWorkCalExDates_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblWorkCalExDatesDModifiedDate { get; set; }

    [Column("_rtblWorkCalExDates_iCreatedBranchID")]
    public int? RtblWorkCalExDatesICreatedBranchId { get; set; }

    [Column("_rtblWorkCalExDates_iModifiedBranchID")]
    public int? RtblWorkCalExDatesIModifiedBranchId { get; set; }

    [Column("_rtblWorkCalExDates_iCreatedAgentID")]
    public int? RtblWorkCalExDatesICreatedAgentId { get; set; }

    [Column("_rtblWorkCalExDates_iModifiedAgentID")]
    public int? RtblWorkCalExDatesIModifiedAgentId { get; set; }

    [Column("_rtblWorkCalExDates_iChangeSetID")]
    public int? RtblWorkCalExDatesIChangeSetId { get; set; }

    [Column("_rtblWorkCalExDates_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblWorkCalExDatesChecksum { get; set; }
}
