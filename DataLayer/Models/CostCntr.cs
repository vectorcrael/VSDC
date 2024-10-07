using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CostCntr")]
[Index("CostCntrDModifiedDate", Name = "idxCostCntr_dModifiedDate")]
[Index("CostCntrIBranchId", Name = "idxCostCntr_iBranchID")]
[Index("CostCntrChecksum", Name = "idx_CostCntr_CostCntr_Checksum")]
[Index("CostCntrIChangeSetId", Name = "idx_CostCntr_iChangeSetID")]
public partial class CostCntr
{
    [Key]
    public int Counter { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CostCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CostName { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ActiveCenter { get; set; }

    [Column("iDepartmentID")]
    public int? IDepartmentId { get; set; }

    [Column("iGLAccountID")]
    public int? IGlaccountId { get; set; }

    [Column("CostCntr_iBranchID")]
    public int? CostCntrIBranchId { get; set; }

    [Column("CostCntr_dCreatedDate", TypeName = "datetime")]
    public DateTime? CostCntrDCreatedDate { get; set; }

    [Column("CostCntr_dModifiedDate", TypeName = "datetime")]
    public DateTime? CostCntrDModifiedDate { get; set; }

    [Column("CostCntr_iCreatedBranchID")]
    public int? CostCntrICreatedBranchId { get; set; }

    [Column("CostCntr_iModifiedBranchID")]
    public int? CostCntrIModifiedBranchId { get; set; }

    [Column("CostCntr_iCreatedAgentID")]
    public int? CostCntrICreatedAgentId { get; set; }

    [Column("CostCntr_iModifiedAgentID")]
    public int? CostCntrIModifiedAgentId { get; set; }

    [Column("CostCntr_iChangeSetID")]
    public int? CostCntrIChangeSetId { get; set; }

    [Column("CostCntr_Checksum")]
    [MaxLength(20)]
    public byte[]? CostCntrChecksum { get; set; }
}
