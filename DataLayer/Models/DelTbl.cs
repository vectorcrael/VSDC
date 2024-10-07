using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("DelTbl")]
[Index("DelTblDModifiedDate", Name = "idxDelTbl_dModifiedDate")]
[Index("DelTblIBranchId", Name = "idxDelTbl_iBranchID")]
[Index("DelTblChecksum", Name = "idx_DelTbl_DelTbl_Checksum")]
[Index("DelTblIChangeSetId", Name = "idx_DelTbl_iChangeSetID")]
public partial class DelTbl
{
    [Key]
    public int Counter { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string Method { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [Column("DelTbl_iBranchID")]
    public int? DelTblIBranchId { get; set; }

    [Column("DelTbl_dCreatedDate", TypeName = "datetime")]
    public DateTime? DelTblDCreatedDate { get; set; }

    [Column("DelTbl_dModifiedDate", TypeName = "datetime")]
    public DateTime? DelTblDModifiedDate { get; set; }

    [Column("DelTbl_iCreatedBranchID")]
    public int? DelTblICreatedBranchId { get; set; }

    [Column("DelTbl_iModifiedBranchID")]
    public int? DelTblIModifiedBranchId { get; set; }

    [Column("DelTbl_iCreatedAgentID")]
    public int? DelTblICreatedAgentId { get; set; }

    [Column("DelTbl_iModifiedAgentID")]
    public int? DelTblIModifiedAgentId { get; set; }

    [Column("DelTbl_iChangeSetID")]
    public int? DelTblIChangeSetId { get; set; }

    [Column("bForDelivery")]
    public bool BForDelivery { get; set; }

    [Column("dEffectiveDate", TypeName = "datetime")]
    public DateTime? DEffectiveDate { get; set; }

    [Column("DelTbl_Checksum")]
    [MaxLength(20)]
    public byte[]? DelTblChecksum { get; set; }
}
