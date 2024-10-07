using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RecurRC")]
[Index("RecurRcDModifiedDate", Name = "idxRecurRC_dModifiedDate")]
[Index("RecurRcIBranchId", Name = "idxRecurRC_iBranchID")]
[Index("RecurRcChecksum", Name = "idx_RecurRC_RecurRC_Checksum")]
[Index("RecurRcIChangeSetId", Name = "idx_RecurRC_iChangeSetID")]
public partial class RecurRc
{
    [Key]
    public int AutoIdx { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Description { get; set; }

    public bool Active { get; set; }

    public int? IntType { get; set; }

    public int? IntData1 { get; set; }

    public int? IntData2 { get; set; }

    public int? Occur { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ActDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? TermDate { get; set; }

    public bool ChgNow { get; set; }

    [Column("RecurRC_iBranchID")]
    public int? RecurRcIBranchId { get; set; }

    [Column("RecurRC_dCreatedDate", TypeName = "datetime")]
    public DateTime? RecurRcDCreatedDate { get; set; }

    [Column("RecurRC_dModifiedDate", TypeName = "datetime")]
    public DateTime? RecurRcDModifiedDate { get; set; }

    [Column("RecurRC_iCreatedBranchID")]
    public int? RecurRcICreatedBranchId { get; set; }

    [Column("RecurRC_iModifiedBranchID")]
    public int? RecurRcIModifiedBranchId { get; set; }

    [Column("RecurRC_iCreatedAgentID")]
    public int? RecurRcICreatedAgentId { get; set; }

    [Column("RecurRC_iModifiedAgentID")]
    public int? RecurRcIModifiedAgentId { get; set; }

    [Column("RecurRC_iChangeSetID")]
    public int? RecurRcIChangeSetId { get; set; }

    [Column("RecurRC_Checksum")]
    [MaxLength(20)]
    public byte[]? RecurRcChecksum { get; set; }
}
