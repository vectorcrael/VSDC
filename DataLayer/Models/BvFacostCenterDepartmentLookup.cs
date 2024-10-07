using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFacostCenterDepartmentLookup
{
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

    [StringLength(40)]
    [Unicode(false)]
    public string? DepartmentName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DepartmentCode { get; set; }

    [Column("GLAccount")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Glaccount { get; set; }
}
