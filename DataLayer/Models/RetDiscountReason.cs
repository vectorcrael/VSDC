using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retDiscountReason")]
[Index("RetDiscountReasonChecksum", Name = "idx__retDiscountReason__retDiscountReason_Checksum")]
[Index("RetDiscountReasonIChangeSetId", Name = "idx__retDiscountReason_iChangeSetID")]
[Index("RetDiscountReasonDModifiedDate", Name = "idx_retDiscountReason_dModifiedDate")]
[Index("RetDiscountReasonIBranchId", Name = "idx_retDiscountReason_iBranchID")]
public partial class RetDiscountReason
{
    [Key]
    [Column("idDiscountReason")]
    public int IdDiscountReason { get; set; }

    [Column("cDiscountReasonCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CDiscountReasonCode { get; set; }

    [Column("cDiscountReasonDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CDiscountReasonDesc { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_retDiscountReason_iBranchID")]
    public int? RetDiscountReasonIBranchId { get; set; }

    [Column("_retDiscountReason_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetDiscountReasonDCreatedDate { get; set; }

    [Column("_retDiscountReason_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetDiscountReasonDModifiedDate { get; set; }

    [Column("_retDiscountReason_iCreatedBranchID")]
    public int? RetDiscountReasonICreatedBranchId { get; set; }

    [Column("_retDiscountReason_iModifiedBranchID")]
    public int? RetDiscountReasonIModifiedBranchId { get; set; }

    [Column("_retDiscountReason_iCreatedAgentID")]
    public int? RetDiscountReasonICreatedAgentId { get; set; }

    [Column("_retDiscountReason_iModifiedAgentID")]
    public int? RetDiscountReasonIModifiedAgentId { get; set; }

    [Column("_retDiscountReason_iChangeSetID")]
    public int? RetDiscountReasonIChangeSetId { get; set; }

    [Column("_retDiscountReason_Checksum")]
    [MaxLength(20)]
    public byte[]? RetDiscountReasonChecksum { get; set; }
}
