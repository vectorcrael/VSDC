using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("PckTbl")]
[Index("PckTblDModifiedDate", Name = "idxPckTbl_dModifiedDate")]
[Index("PckTblIBranchId", Name = "idxPckTbl_iBranchID")]
[Index("PckTblChecksum", Name = "idx_PckTbl_PckTbl_Checksum")]
[Index("PckTblIChangeSetId", Name = "idx_PckTbl_iChangeSetID")]
public partial class PckTbl
{
    [Key]
    [Column("idPckTbl")]
    public int IdPckTbl { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    public double? PackSize { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("PckTbl_iBranchID")]
    public int? PckTblIBranchId { get; set; }

    [Column("PckTbl_dCreatedDate", TypeName = "datetime")]
    public DateTime? PckTblDCreatedDate { get; set; }

    [Column("PckTbl_dModifiedDate", TypeName = "datetime")]
    public DateTime? PckTblDModifiedDate { get; set; }

    [Column("PckTbl_iCreatedBranchID")]
    public int? PckTblICreatedBranchId { get; set; }

    [Column("PckTbl_iModifiedBranchID")]
    public int? PckTblIModifiedBranchId { get; set; }

    [Column("PckTbl_iCreatedAgentID")]
    public int? PckTblICreatedAgentId { get; set; }

    [Column("PckTbl_iModifiedAgentID")]
    public int? PckTblIModifiedAgentId { get; set; }

    [Column("PckTbl_iChangeSetID")]
    public int? PckTblIChangeSetId { get; set; }

    [Column("PckTbl_Checksum")]
    [MaxLength(20)]
    public byte[]? PckTblChecksum { get; set; }
}
