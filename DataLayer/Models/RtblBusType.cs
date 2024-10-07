using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblBusType")]
[Index("RtblBusTypeChecksum", Name = "idx__rtblBusType__rtblBusType_Checksum")]
[Index("RtblBusTypeIChangeSetId", Name = "idx__rtblBusType_iChangeSetID")]
[Index("RtblBusTypeDModifiedDate", Name = "idx_rtblBusType_dModifiedDate")]
[Index("RtblBusTypeIBranchId", Name = "idx_rtblBusType_iBranchID")]
public partial class RtblBusType
{
    [Key]
    [Column("idBusType")]
    public int IdBusType { get; set; }

    [Column("cBusType")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBusType { get; set; }

    [Column("_rtblBusType_iBranchID")]
    public int? RtblBusTypeIBranchId { get; set; }

    [Column("_rtblBusType_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblBusTypeDCreatedDate { get; set; }

    [Column("_rtblBusType_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblBusTypeDModifiedDate { get; set; }

    [Column("_rtblBusType_iCreatedBranchID")]
    public int? RtblBusTypeICreatedBranchId { get; set; }

    [Column("_rtblBusType_iModifiedBranchID")]
    public int? RtblBusTypeIModifiedBranchId { get; set; }

    [Column("_rtblBusType_iCreatedAgentID")]
    public int? RtblBusTypeICreatedAgentId { get; set; }

    [Column("_rtblBusType_iModifiedAgentID")]
    public int? RtblBusTypeIModifiedAgentId { get; set; }

    [Column("_rtblBusType_iChangeSetID")]
    public int? RtblBusTypeIChangeSetId { get; set; }

    [Column("_rtblBusType_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblBusTypeChecksum { get; set; }
}
