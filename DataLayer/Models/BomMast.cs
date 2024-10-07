using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("BomMast")]
[Index("BomMastDModifiedDate", Name = "idxBomMast_dModifiedDate")]
[Index("BomMastIBranchId", Name = "idxBomMast_iBranchID")]
[Index("BomMastChecksum", Name = "idx_BomMast_BomMast_Checksum")]
[Index("BomMastIChangeSetId", Name = "idx_BomMast_iChangeSetID")]
public partial class BomMast
{
    [Key]
    [Column("BomID")]
    public int BomId { get; set; }

    public int? BomStockLink { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BomStockCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BomDescription { get; set; }

    public double? BomProductionQty { get; set; }

    public double? BomUnitCost { get; set; }

    public double? ThisLevelCost { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DateLastCosted { get; set; }

    [Column("bBreakOnGrv")]
    public bool BBreakOnGrv { get; set; }

    [Column("bBreakAllocCostsbyPerc")]
    public bool BBreakAllocCostsbyPerc { get; set; }

    [Column("bShowComponentsOnGRV")]
    public bool BShowComponentsOnGrv { get; set; }

    [Column("bShowAvailAllLevels")]
    public bool BShowAvailAllLevels { get; set; }

    [Column("bShowCompOnInv")]
    public bool BShowCompOnInv { get; set; }

    [Column("bManufWithDefaultWH")]
    public bool BManufWithDefaultWh { get; set; }

    [Column("bBreakUpWithDefaultWH")]
    public bool BBreakUpWithDefaultWh { get; set; }

    [Column("bAllowOverUnderManufacture")]
    public bool BAllowOverUnderManufacture { get; set; }

    [Column("BomMast_iBranchID")]
    public int? BomMastIBranchId { get; set; }

    [Column("BomMast_dCreatedDate", TypeName = "datetime")]
    public DateTime? BomMastDCreatedDate { get; set; }

    [Column("BomMast_dModifiedDate", TypeName = "datetime")]
    public DateTime? BomMastDModifiedDate { get; set; }

    [Column("BomMast_iCreatedBranchID")]
    public int? BomMastICreatedBranchId { get; set; }

    [Column("BomMast_iModifiedBranchID")]
    public int? BomMastIModifiedBranchId { get; set; }

    [Column("BomMast_iCreatedAgentID")]
    public int? BomMastICreatedAgentId { get; set; }

    [Column("BomMast_iModifiedAgentID")]
    public int? BomMastIModifiedAgentId { get; set; }

    [Column("BomMast_iChangeSetID")]
    public int? BomMastIChangeSetId { get; set; }

    [Column("BomMast_fLeadDays")]
    public double? BomMastFLeadDays { get; set; }

    [Column("BomMast_Checksum")]
    [MaxLength(20)]
    public byte[]? BomMastChecksum { get; set; }

    [Column("bExplodeOnDocument")]
    public bool? BExplodeOnDocument { get; set; }
}
