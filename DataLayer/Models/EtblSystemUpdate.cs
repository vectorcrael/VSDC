using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSystemUpdate")]
[Index("EtblSystemUpdateChecksum", Name = "idx__etblSystemUpdate__etblSystemUpdate_Checksum")]
[Index("EtblSystemUpdateIChangeSetId", Name = "idx__etblSystemUpdate_iChangeSetID")]
[Index("EtblSystemUpdateDModifiedDate", Name = "idx_etblSystemUpdate_dModifiedDate")]
[Index("EtblSystemUpdateIBranchId", Name = "idx_etblSystemUpdate_iBranchID")]
public partial class EtblSystemUpdate
{
    [Key]
    [Column("idSystemUpdate")]
    public int IdSystemUpdate { get; set; }

    [Column("iUpdate")]
    public int IUpdate { get; set; }

    [Column("bForce")]
    public bool BForce { get; set; }

    [Column("_etblSystemUpdate_iBranchID")]
    public int? EtblSystemUpdateIBranchId { get; set; }

    [Column("_etblSystemUpdate_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblSystemUpdateDCreatedDate { get; set; }

    [Column("_etblSystemUpdate_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblSystemUpdateDModifiedDate { get; set; }

    [Column("_etblSystemUpdate_iCreatedBranchID")]
    public int? EtblSystemUpdateICreatedBranchId { get; set; }

    [Column("_etblSystemUpdate_iModifiedBranchID")]
    public int? EtblSystemUpdateIModifiedBranchId { get; set; }

    [Column("_etblSystemUpdate_iCreatedAgentID")]
    public int? EtblSystemUpdateICreatedAgentId { get; set; }

    [Column("_etblSystemUpdate_iModifiedAgentID")]
    public int? EtblSystemUpdateIModifiedAgentId { get; set; }

    [Column("_etblSystemUpdate_iChangeSetID")]
    public int? EtblSystemUpdateIChangeSetId { get; set; }

    [Column("_etblSystemUpdate_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblSystemUpdateChecksum { get; set; }
}
