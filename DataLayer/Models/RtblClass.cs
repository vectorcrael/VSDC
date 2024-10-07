using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblClass")]
[Index("RtblClassChecksum", Name = "idx__rtblClass__rtblClass_Checksum")]
[Index("RtblClassIChangeSetId", Name = "idx__rtblClass_iChangeSetID")]
[Index("RtblClassDModifiedDate", Name = "idx_rtblClass_dModifiedDate")]
[Index("RtblClassIBranchId", Name = "idx_rtblClass_iBranchID")]
public partial class RtblClass
{
    [Key]
    [Column("idClass")]
    public int IdClass { get; set; }

    [Column("cDescription")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bAvailable")]
    public bool BAvailable { get; set; }

    [Column("_rtblClass_iBranchID")]
    public int? RtblClassIBranchId { get; set; }

    [Column("_rtblClass_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblClassDCreatedDate { get; set; }

    [Column("_rtblClass_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblClassDModifiedDate { get; set; }

    [Column("_rtblClass_iCreatedBranchID")]
    public int? RtblClassICreatedBranchId { get; set; }

    [Column("_rtblClass_iModifiedBranchID")]
    public int? RtblClassIModifiedBranchId { get; set; }

    [Column("_rtblClass_iCreatedAgentID")]
    public int? RtblClassICreatedAgentId { get; set; }

    [Column("_rtblClass_iModifiedAgentID")]
    public int? RtblClassIModifiedAgentId { get; set; }

    [Column("_rtblClass_iChangeSetID")]
    public int? RtblClassIChangeSetId { get; set; }

    [Column("_rtblClass_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblClassChecksum { get; set; }
}
