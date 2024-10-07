using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CCDefs")]
[Index("CcdefsDModifiedDate", Name = "idxCCDefs_dModifiedDate")]
[Index("CcdefsIBranchId", Name = "idxCCDefs_iBranchID")]
[Index("CcdefsChecksum", Name = "idx_CCDefs_CCDefs_Checksum")]
[Index("CcdefsIChangeSetId", Name = "idx_CCDefs_iChangeSetID")]
public partial class Ccdef
{
    [Key]
    [Column("idCCDefs")]
    public int IdCcdefs { get; set; }

    public double PassScore { get; set; }

    [Column(TypeName = "text")]
    public string? Completeness { get; set; }

    [Column("iPromptOpt")]
    public int? IPromptOpt { get; set; }

    [Column("CCDefs_iBranchID")]
    public int? CcdefsIBranchId { get; set; }

    [Column("CCDefs_dCreatedDate", TypeName = "datetime")]
    public DateTime? CcdefsDCreatedDate { get; set; }

    [Column("CCDefs_dModifiedDate", TypeName = "datetime")]
    public DateTime? CcdefsDModifiedDate { get; set; }

    [Column("CCDefs_iCreatedBranchID")]
    public int? CcdefsICreatedBranchId { get; set; }

    [Column("CCDefs_iModifiedBranchID")]
    public int? CcdefsIModifiedBranchId { get; set; }

    [Column("CCDefs_iCreatedAgentID")]
    public int? CcdefsICreatedAgentId { get; set; }

    [Column("CCDefs_iModifiedAgentID")]
    public int? CcdefsIModifiedAgentId { get; set; }

    [Column("CCDefs_iChangeSetID")]
    public int? CcdefsIChangeSetId { get; set; }

    [Column("CCDefs_Checksum")]
    [MaxLength(20)]
    public byte[]? CcdefsChecksum { get; set; }
}
