using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CrDiscHd")]
[Index("CrDiscHdDModifiedDate", Name = "idxCrDiscHd_dModifiedDate")]
[Index("CrDiscHdIBranchId", Name = "idxCrDiscHd_iBranchID")]
[Index("CrDiscHdChecksum", Name = "idx_CrDiscHd_CrDiscHd_Checksum")]
[Index("CrDiscHdIChangeSetId", Name = "idx_CrDiscHd_iChangeSetID")]
public partial class CrDiscHd
{
    [Key]
    [Column("idCrDiscHd")]
    public int IdCrDiscHd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Place { get; set; } = null!;

    public int Position { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("CrDiscHd_iBranchID")]
    public int? CrDiscHdIBranchId { get; set; }

    [Column("CrDiscHd_dCreatedDate", TypeName = "datetime")]
    public DateTime? CrDiscHdDCreatedDate { get; set; }

    [Column("CrDiscHd_dModifiedDate", TypeName = "datetime")]
    public DateTime? CrDiscHdDModifiedDate { get; set; }

    [Column("CrDiscHd_iCreatedBranchID")]
    public int? CrDiscHdICreatedBranchId { get; set; }

    [Column("CrDiscHd_iModifiedBranchID")]
    public int? CrDiscHdIModifiedBranchId { get; set; }

    [Column("CrDiscHd_iCreatedAgentID")]
    public int? CrDiscHdICreatedAgentId { get; set; }

    [Column("CrDiscHd_iModifiedAgentID")]
    public int? CrDiscHdIModifiedAgentId { get; set; }

    [Column("CrDiscHd_iChangeSetID")]
    public int? CrDiscHdIChangeSetId { get; set; }

    [Column("CrDiscHd_Checksum")]
    [MaxLength(20)]
    public byte[]? CrDiscHdChecksum { get; set; }
}
