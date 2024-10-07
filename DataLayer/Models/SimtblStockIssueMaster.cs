using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_simtblStockIssueMaster")]
public partial class SimtblStockIssueMaster
{
    [Key]
    [Column("iStkIssueId")]
    public int IStkIssueId { get; set; }

    [Column("cStkIssueNumber")]
    [StringLength(50)]
    public string? CStkIssueNumber { get; set; }

    [Column("cDescripton")]
    public string? CDescripton { get; set; }

    [Column("cType")]
    [StringLength(10)]
    public string? CType { get; set; }

    [Column("iStatus")]
    public int? IStatus { get; set; }

    [Column("dIssueDate", TypeName = "datetime")]
    public DateTime? DIssueDate { get; set; }

    [Column("iProjectId")]
    public int? IProjectId { get; set; }

    [Column("bIsTemplate")]
    public bool? BIsTemplate { get; set; }

    [Column("cTemplateId")]
    [StringLength(20)]
    public string? CTemplateId { get; set; }

    [Column("cTemplateDescription")]
    [StringLength(20)]
    public string? CTemplateDescription { get; set; }

    [Column("iRequisitionId")]
    public int IRequisitionId { get; set; }

    [Column("cRequestedBy")]
    [StringLength(50)]
    public string? CRequestedBy { get; set; }
}
