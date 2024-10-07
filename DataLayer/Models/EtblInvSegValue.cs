using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblInvSegValue")]
[Index("EtblInvSegValueChecksum", Name = "idx__etblInvSegValue__etblInvSegValue_Checksum")]
[Index("EtblInvSegValueIChangeSetId", Name = "idx__etblInvSegValue_iChangeSetID")]
[Index("EtblInvSegValueDModifiedDate", Name = "idx_etblInvSegValue_dModifiedDate")]
[Index("EtblInvSegValueIBranchId", Name = "idx_etblInvSegValue_iBranchID")]
public partial class EtblInvSegValue
{
    [Key]
    [Column("idInvSegValue")]
    public int IdInvSegValue { get; set; }

    [Column("iInvSegGroupID")]
    public int IInvSegGroupId { get; set; }

    [Column("cValue")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CValue { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_etblInvSegValue_iBranchID")]
    public int? EtblInvSegValueIBranchId { get; set; }

    [Column("_etblInvSegValue_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvSegValueDCreatedDate { get; set; }

    [Column("_etblInvSegValue_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvSegValueDModifiedDate { get; set; }

    [Column("_etblInvSegValue_iCreatedBranchID")]
    public int? EtblInvSegValueICreatedBranchId { get; set; }

    [Column("_etblInvSegValue_iModifiedBranchID")]
    public int? EtblInvSegValueIModifiedBranchId { get; set; }

    [Column("_etblInvSegValue_iCreatedAgentID")]
    public int? EtblInvSegValueICreatedAgentId { get; set; }

    [Column("_etblInvSegValue_iModifiedAgentID")]
    public int? EtblInvSegValueIModifiedAgentId { get; set; }

    [Column("_etblInvSegValue_iChangeSetID")]
    public int? EtblInvSegValueIChangeSetId { get; set; }

    [Column("_etblInvSegValue_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvSegValueChecksum { get; set; }
}
