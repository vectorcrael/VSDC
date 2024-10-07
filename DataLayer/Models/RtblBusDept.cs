using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblBusDept")]
[Index("RtblBusDeptChecksum", Name = "idx__rtblBusDept__rtblBusDept_Checksum")]
[Index("RtblBusDeptIChangeSetId", Name = "idx__rtblBusDept_iChangeSetID")]
[Index("RtblBusDeptDModifiedDate", Name = "idx_rtblBusDept_dModifiedDate")]
[Index("RtblBusDeptIBranchId", Name = "idx_rtblBusDept_iBranchID")]
public partial class RtblBusDept
{
    [Key]
    [Column("idBusDept")]
    public int IdBusDept { get; set; }

    [Column("cBusDept")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBusDept { get; set; }

    [Column("_rtblBusDept_iBranchID")]
    public int? RtblBusDeptIBranchId { get; set; }

    [Column("_rtblBusDept_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblBusDeptDCreatedDate { get; set; }

    [Column("_rtblBusDept_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblBusDeptDModifiedDate { get; set; }

    [Column("_rtblBusDept_iCreatedBranchID")]
    public int? RtblBusDeptICreatedBranchId { get; set; }

    [Column("_rtblBusDept_iModifiedBranchID")]
    public int? RtblBusDeptIModifiedBranchId { get; set; }

    [Column("_rtblBusDept_iCreatedAgentID")]
    public int? RtblBusDeptICreatedAgentId { get; set; }

    [Column("_rtblBusDept_iModifiedAgentID")]
    public int? RtblBusDeptIModifiedAgentId { get; set; }

    [Column("_rtblBusDept_iChangeSetID")]
    public int? RtblBusDeptIChangeSetId { get; set; }

    [Column("_rtblBusDept_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblBusDeptChecksum { get; set; }
}
