using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Index("PeriodPermissionsDModifiedDate", Name = "idxPeriodPermissions_dModifiedDate")]
[Index("PeriodPermissionsIBranchId", Name = "idxPeriodPermissions_iBranchID")]
[Index("PeriodPermissionsChecksum", Name = "idx_PeriodPermissions_PeriodPermissions_Checksum")]
[Index("PeriodPermissionsIChangeSetId", Name = "idx_PeriodPermissions_iChangeSetID")]
public partial class PeriodPermission
{
    [Key]
    [Column("idPeriodPermissions")]
    public int IdPeriodPermissions { get; set; }

    public int? Period { get; set; }

    public int? AgentType { get; set; }

    [Column("AgentID")]
    public int? AgentId { get; set; }

    public bool Allow { get; set; }

    [Column("PeriodPermissions_iBranchID")]
    public int? PeriodPermissionsIBranchId { get; set; }

    [Column("PeriodPermissions_dCreatedDate", TypeName = "datetime")]
    public DateTime? PeriodPermissionsDCreatedDate { get; set; }

    [Column("PeriodPermissions_dModifiedDate", TypeName = "datetime")]
    public DateTime? PeriodPermissionsDModifiedDate { get; set; }

    [Column("PeriodPermissions_iCreatedBranchID")]
    public int? PeriodPermissionsICreatedBranchId { get; set; }

    [Column("PeriodPermissions_iModifiedBranchID")]
    public int? PeriodPermissionsIModifiedBranchId { get; set; }

    [Column("PeriodPermissions_iCreatedAgentID")]
    public int? PeriodPermissionsICreatedAgentId { get; set; }

    [Column("PeriodPermissions_iModifiedAgentID")]
    public int? PeriodPermissionsIModifiedAgentId { get; set; }

    [Column("PeriodPermissions_iChangeSetID")]
    public int? PeriodPermissionsIChangeSetId { get; set; }

    [Column("PeriodPermissions_Checksum")]
    [MaxLength(20)]
    public byte[]? PeriodPermissionsChecksum { get; set; }
}
