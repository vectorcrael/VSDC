using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblInvSegGroup")]
[Index("EtblInvSegGroupChecksum", Name = "idx__etblInvSegGroup__etblInvSegGroup_Checksum")]
[Index("EtblInvSegGroupIChangeSetId", Name = "idx__etblInvSegGroup_iChangeSetID")]
[Index("EtblInvSegGroupDModifiedDate", Name = "idx_etblInvSegGroup_dModifiedDate")]
[Index("EtblInvSegGroupIBranchId", Name = "idx_etblInvSegGroup_iBranchID")]
public partial class EtblInvSegGroup
{
    [Key]
    [Column("idInvSegGroup")]
    public int IdInvSegGroup { get; set; }

    [Column("iInvSegTypeID")]
    public int IInvSegTypeId { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblInvSegGroup_iBranchID")]
    public int? EtblInvSegGroupIBranchId { get; set; }

    [Column("_etblInvSegGroup_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvSegGroupDCreatedDate { get; set; }

    [Column("_etblInvSegGroup_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvSegGroupDModifiedDate { get; set; }

    [Column("_etblInvSegGroup_iCreatedBranchID")]
    public int? EtblInvSegGroupICreatedBranchId { get; set; }

    [Column("_etblInvSegGroup_iModifiedBranchID")]
    public int? EtblInvSegGroupIModifiedBranchId { get; set; }

    [Column("_etblInvSegGroup_iCreatedAgentID")]
    public int? EtblInvSegGroupICreatedAgentId { get; set; }

    [Column("_etblInvSegGroup_iModifiedAgentID")]
    public int? EtblInvSegGroupIModifiedAgentId { get; set; }

    [Column("_etblInvSegGroup_iChangeSetID")]
    public int? EtblInvSegGroupIChangeSetId { get; set; }

    [Column("_etblInvSegGroup_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvSegGroupChecksum { get; set; }
}
