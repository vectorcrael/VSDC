using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblDashboardLayouts")]
[Index("EtblDashboardLayoutsChecksum", Name = "idx__etblDashboardLayouts__etblDashboardLayouts_Checksum")]
[Index("EtblDashboardLayoutsDModifiedDate", Name = "idx__etblDashboardLayouts__etblDashboardLayouts_dModifiedDate")]
[Index("EtblDashboardLayoutsIBranchId", Name = "idx__etblDashboardLayouts__etblDashboardLayouts_iBranchID")]
[Index("EtblDashboardLayoutsIChangeSetId", Name = "idx__etblDashboardLayouts__etblDashboardLayouts_iChangeSetID")]
public partial class EtblDashboardLayout
{
    [Key]
    [Column("idDashboardLayouts")]
    public int IdDashboardLayouts { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("iAgentGroupID")]
    public int IAgentGroupId { get; set; }

    [Column("nLayout")]
    [Unicode(false)]
    public string NLayout { get; set; } = null!;

    [Column("_etblDashboardLayouts_iBranchID")]
    public int? EtblDashboardLayoutsIBranchId { get; set; }

    [Column("_etblDashboardLayouts_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblDashboardLayoutsDCreatedDate { get; set; }

    [Column("_etblDashboardLayouts_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblDashboardLayoutsDModifiedDate { get; set; }

    [Column("_etblDashboardLayouts_iCreatedBranchID")]
    public int? EtblDashboardLayoutsICreatedBranchId { get; set; }

    [Column("_etblDashboardLayouts_iModifiedBranchID")]
    public int? EtblDashboardLayoutsIModifiedBranchId { get; set; }

    [Column("_etblDashboardLayouts_iCreatedAgentID")]
    public int? EtblDashboardLayoutsICreatedAgentId { get; set; }

    [Column("_etblDashboardLayouts_iModifiedAgentID")]
    public int? EtblDashboardLayoutsIModifiedAgentId { get; set; }

    [Column("_etblDashboardLayouts_iChangeSetID")]
    public int? EtblDashboardLayoutsIChangeSetId { get; set; }

    [Column("_etblDashboardLayouts_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblDashboardLayoutsChecksum { get; set; }
}
