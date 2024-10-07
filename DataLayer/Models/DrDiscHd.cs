using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("DrDiscHd")]
[Index("DrDiscHdDModifiedDate", Name = "idxDrDiscHd_dModifiedDate")]
[Index("DrDiscHdIBranchId", Name = "idxDrDiscHd_iBranchID")]
[Index("DrDiscHdChecksum", Name = "idx_DrDiscHd_DrDiscHd_Checksum")]
[Index("DrDiscHdIChangeSetId", Name = "idx_DrDiscHd_iChangeSetID")]
public partial class DrDiscHd
{
    [Key]
    [Column("idDrDiscHd")]
    public int IdDrDiscHd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Place { get; set; } = null!;

    public int Position { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("DrDiscHd_iBranchID")]
    public int? DrDiscHdIBranchId { get; set; }

    [Column("DrDiscHd_dCreatedDate", TypeName = "datetime")]
    public DateTime? DrDiscHdDCreatedDate { get; set; }

    [Column("DrDiscHd_dModifiedDate", TypeName = "datetime")]
    public DateTime? DrDiscHdDModifiedDate { get; set; }

    [Column("DrDiscHd_iCreatedBranchID")]
    public int? DrDiscHdICreatedBranchId { get; set; }

    [Column("DrDiscHd_iModifiedBranchID")]
    public int? DrDiscHdIModifiedBranchId { get; set; }

    [Column("DrDiscHd_iCreatedAgentID")]
    public int? DrDiscHdICreatedAgentId { get; set; }

    [Column("DrDiscHd_iModifiedAgentID")]
    public int? DrDiscHdIModifiedAgentId { get; set; }

    [Column("DrDiscHd_iChangeSetID")]
    public int? DrDiscHdIChangeSetId { get; set; }

    [Column("DrDiscHd_Checksum")]
    [MaxLength(20)]
    public byte[]? DrDiscHdChecksum { get; set; }
}
