using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_CostCentre")]
[Index("RfqCostcentreChecksum", Name = "idx_RFQ_costcentre_RFQ_costcentre_Checksum")]
[Index("RfqCostcentreDModifiedDate", Name = "idx_RFQ_costcentre_RFQ_costcentre_dModifiedDate")]
[Index("RfqCostcentreIBranchId", Name = "idx_RFQ_costcentre_RFQ_costcentre_iBranchID")]
[Index("RfqCostcentreIChangeSetId", Name = "idx_RFQ_costcentre_RFQ_costcentre_iChangeSetID")]
public partial class RfqCostCentre
{
    [Key]
    [Column("idCostCentre")]
    public int IdCostCentre { get; set; }

    [Column("cCostCentre")]
    [StringLength(100)]
    public string? CCostCentre { get; set; }

    [Column("cDescription")]
    [StringLength(200)]
    public string? CDescription { get; set; }

    [Column("bAddedToUDF")]
    public bool? BAddedToUdf { get; set; }

    [Column("RFQ_costcentre_iBranchID")]
    public int? RfqCostcentreIBranchId { get; set; }

    [Column("RFQ_costcentre_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqCostcentreDCreatedDate { get; set; }

    [Column("RFQ_costcentre_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqCostcentreDModifiedDate { get; set; }

    [Column("RFQ_costcentre_iCreatedBranchID")]
    public int? RfqCostcentreICreatedBranchId { get; set; }

    [Column("RFQ_costcentre_iModifiedBranchID")]
    public int? RfqCostcentreIModifiedBranchId { get; set; }

    [Column("RFQ_costcentre_iCreatedAgentID")]
    public int? RfqCostcentreICreatedAgentId { get; set; }

    [Column("RFQ_costcentre_iModifiedAgentID")]
    public int? RfqCostcentreIModifiedAgentId { get; set; }

    [Column("RFQ_costcentre_iChangeSetID")]
    public int? RfqCostcentreIChangeSetId { get; set; }

    [Column("RFQ_costcentre_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqCostcentreChecksum { get; set; }
}
