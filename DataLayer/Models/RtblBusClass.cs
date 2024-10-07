using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblBusClass")]
[Index("RtblBusClassChecksum", Name = "idx__rtblBusClass__rtblBusClass_Checksum")]
[Index("RtblBusClassIChangeSetId", Name = "idx__rtblBusClass_iChangeSetID")]
[Index("RtblBusClassDModifiedDate", Name = "idx_rtblBusClass_dModifiedDate")]
[Index("RtblBusClassIBranchId", Name = "idx_rtblBusClass_iBranchID")]
public partial class RtblBusClass
{
    [Key]
    [Column("idBusClass")]
    public int IdBusClass { get; set; }

    [Column("cBusClass")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBusClass { get; set; }

    [Column("_rtblBusClass_iBranchID")]
    public int? RtblBusClassIBranchId { get; set; }

    [Column("_rtblBusClass_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblBusClassDCreatedDate { get; set; }

    [Column("_rtblBusClass_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblBusClassDModifiedDate { get; set; }

    [Column("_rtblBusClass_iCreatedBranchID")]
    public int? RtblBusClassICreatedBranchId { get; set; }

    [Column("_rtblBusClass_iModifiedBranchID")]
    public int? RtblBusClassIModifiedBranchId { get; set; }

    [Column("_rtblBusClass_iCreatedAgentID")]
    public int? RtblBusClassICreatedAgentId { get; set; }

    [Column("_rtblBusClass_iModifiedAgentID")]
    public int? RtblBusClassIModifiedAgentId { get; set; }

    [Column("_rtblBusClass_iChangeSetID")]
    public int? RtblBusClassIChangeSetId { get; set; }

    [Column("_rtblBusClass_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblBusClassChecksum { get; set; }
}
