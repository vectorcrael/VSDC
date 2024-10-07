using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_DeviationReason")]
[Index("RfqDeviationReasonChecksum", Name = "idx_RFQ_DeviationReason_RFQ_DeviationReason_Checksum")]
[Index("RfqDeviationReasonDModifiedDate", Name = "idx_RFQ_DeviationReason_RFQ_DeviationReason_dModifiedDate")]
[Index("RfqDeviationReasonIBranchId", Name = "idx_RFQ_DeviationReason_RFQ_DeviationReason_iBranchID")]
[Index("RfqDeviationReasonIChangeSetId", Name = "idx_RFQ_DeviationReason_RFQ_DeviationReason_iChangeSetID")]
public partial class RfqDeviationReason
{
    [Key]
    [Column("idDeviationReason")]
    public int IdDeviationReason { get; set; }

    [Column("cCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CCode { get; set; }

    [Column("cReasonDesc")]
    [StringLength(500)]
    public string? CReasonDesc { get; set; }

    [Column("bActive")]
    public bool? BActive { get; set; }

    [Column("bDefault")]
    public bool? BDefault { get; set; }

    [Column("dCreatedDate", TypeName = "datetime")]
    public DateTime? DCreatedDate { get; set; }

    [Column("dModifiedDate", TypeName = "datetime")]
    public DateTime? DModifiedDate { get; set; }

    [Column("RFQ_DeviationReason_iBranchID")]
    public int? RfqDeviationReasonIBranchId { get; set; }

    [Column("RFQ_DeviationReason_dCreatedDate", TypeName = "datetime")]
    public DateTime? RfqDeviationReasonDCreatedDate { get; set; }

    [Column("RFQ_DeviationReason_dModifiedDate", TypeName = "datetime")]
    public DateTime? RfqDeviationReasonDModifiedDate { get; set; }

    [Column("RFQ_DeviationReason_iCreatedBranchID")]
    public int? RfqDeviationReasonICreatedBranchId { get; set; }

    [Column("RFQ_DeviationReason_iModifiedBranchID")]
    public int? RfqDeviationReasonIModifiedBranchId { get; set; }

    [Column("RFQ_DeviationReason_iCreatedAgentID")]
    public int? RfqDeviationReasonICreatedAgentId { get; set; }

    [Column("RFQ_DeviationReason_iModifiedAgentID")]
    public int? RfqDeviationReasonIModifiedAgentId { get; set; }

    [Column("RFQ_DeviationReason_iChangeSetID")]
    public int? RfqDeviationReasonIChangeSetId { get; set; }

    [Column("RFQ_DeviationReason_Checksum")]
    [MaxLength(20)]
    public byte[]? RfqDeviationReasonChecksum { get; set; }
}
