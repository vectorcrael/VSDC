using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("DrDiscMx")]
[Index("DrDiscMxDModifiedDate", Name = "idxDrDiscMx_dModifiedDate")]
[Index("DrDiscMxIBranchId", Name = "idxDrDiscMx_iBranchID")]
[Index("DrDiscMxChecksum", Name = "idx_DrDiscMx_DrDiscMx_Checksum")]
[Index("DrDiscMxIChangeSetId", Name = "idx_DrDiscMx_iChangeSetID")]
public partial class DrDiscMx
{
    [Key]
    [Column("idDrDiscMx")]
    public int IdDrDiscMx { get; set; }

    [Column("XPos")]
    public int Xpos { get; set; }

    [Column("YPos")]
    public int Ypos { get; set; }

    public double? Percentage { get; set; }

    [Column("DrDiscMx_iBranchID")]
    public int? DrDiscMxIBranchId { get; set; }

    [Column("DrDiscMx_dCreatedDate", TypeName = "datetime")]
    public DateTime? DrDiscMxDCreatedDate { get; set; }

    [Column("DrDiscMx_dModifiedDate", TypeName = "datetime")]
    public DateTime? DrDiscMxDModifiedDate { get; set; }

    [Column("DrDiscMx_iCreatedBranchID")]
    public int? DrDiscMxICreatedBranchId { get; set; }

    [Column("DrDiscMx_iModifiedBranchID")]
    public int? DrDiscMxIModifiedBranchId { get; set; }

    [Column("DrDiscMx_iCreatedAgentID")]
    public int? DrDiscMxICreatedAgentId { get; set; }

    [Column("DrDiscMx_iModifiedAgentID")]
    public int? DrDiscMxIModifiedAgentId { get; set; }

    [Column("DrDiscMx_iChangeSetID")]
    public int? DrDiscMxIChangeSetId { get; set; }

    [Column("DrDiscMx_Checksum")]
    [MaxLength(20)]
    public byte[]? DrDiscMxChecksum { get; set; }
}
