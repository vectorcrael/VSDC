using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblRefBase")]
[Index("RtblRefBaseChecksum", Name = "idx__rtblRefBase__rtblRefBase_Checksum")]
[Index("RtblRefBaseIChangeSetId", Name = "idx__rtblRefBase_iChangeSetID")]
[Index("RtblRefBaseDModifiedDate", Name = "idx_rtblRefBase_dModifiedDate")]
[Index("RtblRefBaseIBranchId", Name = "idx_rtblRefBase_iBranchID")]
public partial class RtblRefBase
{
    [Key]
    [Column("idRefBase")]
    public int IdRefBase { get; set; }

    [Column("cRefType")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CRefType { get; set; }

    [Column("iNextNo")]
    public int? INextNo { get; set; }

    [Column("_rtblRefBase_iBranchID")]
    public int? RtblRefBaseIBranchId { get; set; }

    [Column("_rtblRefBase_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblRefBaseDCreatedDate { get; set; }

    [Column("_rtblRefBase_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblRefBaseDModifiedDate { get; set; }

    [Column("_rtblRefBase_iCreatedBranchID")]
    public int? RtblRefBaseICreatedBranchId { get; set; }

    [Column("_rtblRefBase_iModifiedBranchID")]
    public int? RtblRefBaseIModifiedBranchId { get; set; }

    [Column("_rtblRefBase_iCreatedAgentID")]
    public int? RtblRefBaseICreatedAgentId { get; set; }

    [Column("_rtblRefBase_iModifiedAgentID")]
    public int? RtblRefBaseIModifiedAgentId { get; set; }

    [Column("_rtblRefBase_iChangeSetID")]
    public int? RtblRefBaseIChangeSetId { get; set; }

    [Column("_rtblRefBase_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblRefBaseChecksum { get; set; }
}
