using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Index("MastOffsDModifiedDate", Name = "idxMastOffs_dModifiedDate")]
[Index("MastOffsIBranchId", Name = "idxMastOffs_iBranchID")]
[Index("MastOffsChecksum", Name = "idx_MastOffs_MastOffs_Checksum")]
[Index("MastOffsIChangeSetId", Name = "idx_MastOffs_iChangeSetID")]
public partial class MastOff
{
    [Key]
    [Column("idMastOffs")]
    public int IdMastOffs { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? Address { get; set; }

    [Column("MastOffs_iBranchID")]
    public int? MastOffsIBranchId { get; set; }

    [Column("MastOffs_dCreatedDate", TypeName = "datetime")]
    public DateTime? MastOffsDCreatedDate { get; set; }

    [Column("MastOffs_dModifiedDate", TypeName = "datetime")]
    public DateTime? MastOffsDModifiedDate { get; set; }

    [Column("MastOffs_iCreatedBranchID")]
    public int? MastOffsICreatedBranchId { get; set; }

    [Column("MastOffs_iModifiedBranchID")]
    public int? MastOffsIModifiedBranchId { get; set; }

    [Column("MastOffs_iCreatedAgentID")]
    public int? MastOffsICreatedAgentId { get; set; }

    [Column("MastOffs_iModifiedAgentID")]
    public int? MastOffsIModifiedAgentId { get; set; }

    [Column("MastOffs_iChangeSetID")]
    public int? MastOffsIChangeSetId { get; set; }

    [Column("MastOffs_Checksum")]
    [MaxLength(20)]
    public byte[]? MastOffsChecksum { get; set; }
}
