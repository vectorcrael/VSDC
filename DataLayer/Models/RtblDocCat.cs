using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblDocCat")]
[Index("RtblDocCatChecksum", Name = "idx__rtblDocCat__rtblDocCat_Checksum")]
[Index("RtblDocCatIChangeSetId", Name = "idx__rtblDocCat_iChangeSetID")]
[Index("RtblDocCatDModifiedDate", Name = "idx_rtblDocCat_dModifiedDate")]
[Index("RtblDocCatIBranchId", Name = "idx_rtblDocCat_iBranchID")]
public partial class RtblDocCat
{
    [Key]
    [Column("idDocCat")]
    public int IdDocCat { get; set; }

    [Column("cDescription")]
    [StringLength(64)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("_rtblDocCat_iBranchID")]
    public int? RtblDocCatIBranchId { get; set; }

    [Column("_rtblDocCat_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblDocCatDCreatedDate { get; set; }

    [Column("_rtblDocCat_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblDocCatDModifiedDate { get; set; }

    [Column("_rtblDocCat_iCreatedBranchID")]
    public int? RtblDocCatICreatedBranchId { get; set; }

    [Column("_rtblDocCat_iModifiedBranchID")]
    public int? RtblDocCatIModifiedBranchId { get; set; }

    [Column("_rtblDocCat_iCreatedAgentID")]
    public int? RtblDocCatICreatedAgentId { get; set; }

    [Column("_rtblDocCat_iModifiedAgentID")]
    public int? RtblDocCatIModifiedAgentId { get; set; }

    [Column("_rtblDocCat_iChangeSetID")]
    public int? RtblDocCatIChangeSetId { get; set; }

    [Column("_rtblDocCat_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblDocCatChecksum { get; set; }
}
