using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblInvSegType")]
[Index("EtblInvSegTypeChecksum", Name = "idx__etblInvSegType__etblInvSegType_Checksum")]
[Index("EtblInvSegTypeIChangeSetId", Name = "idx__etblInvSegType_iChangeSetID")]
[Index("EtblInvSegTypeDModifiedDate", Name = "idx_etblInvSegType_dModifiedDate")]
[Index("EtblInvSegTypeIBranchId", Name = "idx_etblInvSegType_iBranchID")]
public partial class EtblInvSegType
{
    [Key]
    [Column("idInvSegType")]
    public int IdInvSegType { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblInvSegType_iBranchID")]
    public int? EtblInvSegTypeIBranchId { get; set; }

    [Column("_etblInvSegType_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvSegTypeDCreatedDate { get; set; }

    [Column("_etblInvSegType_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvSegTypeDModifiedDate { get; set; }

    [Column("_etblInvSegType_iCreatedBranchID")]
    public int? EtblInvSegTypeICreatedBranchId { get; set; }

    [Column("_etblInvSegType_iModifiedBranchID")]
    public int? EtblInvSegTypeIModifiedBranchId { get; set; }

    [Column("_etblInvSegType_iCreatedAgentID")]
    public int? EtblInvSegTypeICreatedAgentId { get; set; }

    [Column("_etblInvSegType_iModifiedAgentID")]
    public int? EtblInvSegTypeIModifiedAgentId { get; set; }

    [Column("_etblInvSegType_iChangeSetID")]
    public int? EtblInvSegTypeIChangeSetId { get; set; }

    [Column("_etblInvSegType_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvSegTypeChecksum { get; set; }
}
