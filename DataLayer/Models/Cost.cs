using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("Cost")]
[Index("CostDModifiedDate", Name = "idxCost_dModifiedDate")]
[Index("CostIBranchId", Name = "idxCost_iBranchID")]
[Index("CostChecksum", Name = "idx_Cost_Cost_Checksum")]
[Index("CostIChangeSetId", Name = "idx_Cost_iChangeSetID")]
public partial class Cost
{
    [Key]
    public int Autoidx { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DebtorAccNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Dated { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? TypeofCost { get; set; }

    public double? Amount { get; set; }

    [Column("Cost_iBranchID")]
    public int? CostIBranchId { get; set; }

    [Column("Cost_dCreatedDate", TypeName = "datetime")]
    public DateTime? CostDCreatedDate { get; set; }

    [Column("Cost_dModifiedDate", TypeName = "datetime")]
    public DateTime? CostDModifiedDate { get; set; }

    [Column("Cost_iCreatedBranchID")]
    public int? CostICreatedBranchId { get; set; }

    [Column("Cost_iModifiedBranchID")]
    public int? CostIModifiedBranchId { get; set; }

    [Column("Cost_iCreatedAgentID")]
    public int? CostICreatedAgentId { get; set; }

    [Column("Cost_iModifiedAgentID")]
    public int? CostIModifiedAgentId { get; set; }

    [Column("Cost_iChangeSetID")]
    public int? CostIChangeSetId { get; set; }

    [Column("Cost_Checksum")]
    [MaxLength(20)]
    public byte[]? CostChecksum { get; set; }
}
