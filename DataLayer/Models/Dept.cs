using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("Dept")]
[Index("DeptDModifiedDate", Name = "idxDept_dModifiedDate")]
[Index("DeptIBranchId", Name = "idxDept_iBranchID")]
[Index("DeptChecksum", Name = "idx_Dept_Dept_Checksum")]
[Index("DeptIChangeSetId", Name = "idx_Dept_iChangeSetID")]
public partial class Dept
{
    [Key]
    [Column("idDept")]
    public int IdDept { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Info { get; set; }

    [Column("dBrDeptTimeStamp", TypeName = "datetime")]
    public DateTime? DBrDeptTimeStamp { get; set; }

    [Column("Dept_iBranchID")]
    public int? DeptIBranchId { get; set; }

    [Column("Dept_dCreatedDate", TypeName = "datetime")]
    public DateTime? DeptDCreatedDate { get; set; }

    [Column("Dept_dModifiedDate", TypeName = "datetime")]
    public DateTime? DeptDModifiedDate { get; set; }

    [Column("Dept_iCreatedBranchID")]
    public int? DeptICreatedBranchId { get; set; }

    [Column("Dept_iModifiedBranchID")]
    public int? DeptIModifiedBranchId { get; set; }

    [Column("Dept_iCreatedAgentID")]
    public int? DeptICreatedAgentId { get; set; }

    [Column("Dept_iModifiedAgentID")]
    public int? DeptIModifiedAgentId { get; set; }

    [Column("Dept_iChangeSetID")]
    public int? DeptIChangeSetId { get; set; }

    [Column("Dept_Checksum")]
    [MaxLength(20)]
    public byte[]? DeptChecksum { get; set; }
}
