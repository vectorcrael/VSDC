using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CrDiscMx")]
[Index("CrDiscMxDModifiedDate", Name = "idxCrDiscMx_dModifiedDate")]
[Index("CrDiscMxIBranchId", Name = "idxCrDiscMx_iBranchID")]
[Index("CrDiscMxChecksum", Name = "idx_CrDiscMx_CrDiscMx_Checksum")]
[Index("CrDiscMxIChangeSetId", Name = "idx_CrDiscMx_iChangeSetID")]
public partial class CrDiscMx
{
    [Key]
    [Column("idCrDiscMx")]
    public int IdCrDiscMx { get; set; }

    [Column("XPos")]
    public int Xpos { get; set; }

    [Column("YPos")]
    public int Ypos { get; set; }

    public double? Percentage { get; set; }

    [Column("CrDiscMx_iBranchID")]
    public int? CrDiscMxIBranchId { get; set; }

    [Column("CrDiscMx_dCreatedDate", TypeName = "datetime")]
    public DateTime? CrDiscMxDCreatedDate { get; set; }

    [Column("CrDiscMx_dModifiedDate", TypeName = "datetime")]
    public DateTime? CrDiscMxDModifiedDate { get; set; }

    [Column("CrDiscMx_iCreatedBranchID")]
    public int? CrDiscMxICreatedBranchId { get; set; }

    [Column("CrDiscMx_iModifiedBranchID")]
    public int? CrDiscMxIModifiedBranchId { get; set; }

    [Column("CrDiscMx_iCreatedAgentID")]
    public int? CrDiscMxICreatedAgentId { get; set; }

    [Column("CrDiscMx_iModifiedAgentID")]
    public int? CrDiscMxIModifiedAgentId { get; set; }

    [Column("CrDiscMx_iChangeSetID")]
    public int? CrDiscMxIChangeSetId { get; set; }

    [Column("CrDiscMx_Checksum")]
    [MaxLength(20)]
    public byte[]? CrDiscMxChecksum { get; set; }
}
