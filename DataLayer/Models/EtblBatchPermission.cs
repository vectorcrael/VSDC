using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblBatchPermissions")]
[Index("EtblBatchPermissionsChecksum", Name = "idx__etblBatchPermissions__etblBatchPermissions_Checksum")]
[Index("EtblBatchPermissionsIChangeSetId", Name = "idx__etblBatchPermissions_iChangeSetID")]
[Index("EtblBatchPermissionsDModifiedDate", Name = "idx_etblBatchPermissions_dModifiedDate")]
[Index("EtblBatchPermissionsIBranchId", Name = "idx_etblBatchPermissions_iBranchID")]
public partial class EtblBatchPermission
{
    [Key]
    [Column("idBatchPermissions")]
    public int IdBatchPermissions { get; set; }

    [Column("iBatchID")]
    public int IBatchId { get; set; }

    [Column("cBatchType")]
    [StringLength(1)]
    [Unicode(false)]
    public string CBatchType { get; set; } = null!;

    [Column("cAgentType")]
    [StringLength(1)]
    [Unicode(false)]
    public string CAgentType { get; set; } = null!;

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("bBatchVisible")]
    public bool BBatchVisible { get; set; }

    [Column("dDatePermissionCreated", TypeName = "datetime")]
    public DateTime DDatePermissionCreated { get; set; }

    [Column("iAgentPermissionCreated")]
    public int IAgentPermissionCreated { get; set; }

    [Column("_etblBatchPermissions_iBranchID")]
    public int? EtblBatchPermissionsIBranchId { get; set; }

    [Column("_etblBatchPermissions_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblBatchPermissionsDCreatedDate { get; set; }

    [Column("_etblBatchPermissions_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblBatchPermissionsDModifiedDate { get; set; }

    [Column("_etblBatchPermissions_iCreatedBranchID")]
    public int? EtblBatchPermissionsICreatedBranchId { get; set; }

    [Column("_etblBatchPermissions_iModifiedBranchID")]
    public int? EtblBatchPermissionsIModifiedBranchId { get; set; }

    [Column("_etblBatchPermissions_iCreatedAgentID")]
    public int? EtblBatchPermissionsICreatedAgentId { get; set; }

    [Column("_etblBatchPermissions_iModifiedAgentID")]
    public int? EtblBatchPermissionsIModifiedAgentId { get; set; }

    [Column("_etblBatchPermissions_iChangeSetID")]
    public int? EtblBatchPermissionsIChangeSetId { get; set; }

    [Column("_etblBatchPermissions_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblBatchPermissionsChecksum { get; set; }
}
