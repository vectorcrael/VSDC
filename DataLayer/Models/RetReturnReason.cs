using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retReturnReason")]
[Index("RetReturnReasonChecksum", Name = "idx__retReturnReason__retReturnReason_Checksum")]
[Index("RetReturnReasonIChangeSetId", Name = "idx__retReturnReason_iChangeSetID")]
[Index("RetReturnReasonDModifiedDate", Name = "idx_retReturnReason_dModifiedDate")]
[Index("RetReturnReasonIBranchId", Name = "idx_retReturnReason_iBranchID")]
public partial class RetReturnReason
{
    [Key]
    [Column("idReturnReason")]
    public int IdReturnReason { get; set; }

    [Column("cReturnReasonCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CReturnReasonCode { get; set; }

    [Column("cReturnReasonDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CReturnReasonDesc { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_retReturnReason_iBranchID")]
    public int? RetReturnReasonIBranchId { get; set; }

    [Column("_retReturnReason_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetReturnReasonDCreatedDate { get; set; }

    [Column("_retReturnReason_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetReturnReasonDModifiedDate { get; set; }

    [Column("_retReturnReason_iCreatedBranchID")]
    public int? RetReturnReasonICreatedBranchId { get; set; }

    [Column("_retReturnReason_iModifiedBranchID")]
    public int? RetReturnReasonIModifiedBranchId { get; set; }

    [Column("_retReturnReason_iCreatedAgentID")]
    public int? RetReturnReasonICreatedAgentId { get; set; }

    [Column("_retReturnReason_iModifiedAgentID")]
    public int? RetReturnReasonIModifiedAgentId { get; set; }

    [Column("_retReturnReason_iChangeSetID")]
    public int? RetReturnReasonIChangeSetId { get; set; }

    [Column("_retReturnReason_Checksum")]
    [MaxLength(20)]
    public byte[]? RetReturnReasonChecksum { get; set; }
}
