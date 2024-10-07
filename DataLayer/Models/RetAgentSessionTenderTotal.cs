using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retAgentSessionTenderTotals")]
[Index("RetAgentSessionTenderTotalsChecksum", Name = "idx__retAgentSessionTenderTotals__retAgentSessionTenderTotals_Checksum")]
[Index("RetAgentSessionTenderTotalsDModifiedDate", Name = "idx__retAgentSessionTenderTotals__retAgentSessionTenderTotals_dModifiedDate")]
[Index("RetAgentSessionTenderTotalsIBranchId", Name = "idx__retAgentSessionTenderTotals__retAgentSessionTenderTotals_iBranchID")]
[Index("RetAgentSessionTenderTotalsIChangeSetId", Name = "idx__retAgentSessionTenderTotals__retAgentSessionTenderTotals_iChangeSetID")]
[Index("IAgentSessionId", Name = "idx__retAgentSessionTenderTotals_iAgentSessionID")]
public partial class RetAgentSessionTenderTotal
{
    [Key]
    [Column("idAgentSessionTenderTotals")]
    public int IdAgentSessionTenderTotals { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("iTenderTypeID")]
    public int? ITenderTypeId { get; set; }

    [Column("bCashTenderType")]
    public bool BCashTenderType { get; set; }

    [Column("iTenderCount")]
    public int? ITenderCount { get; set; }

    [Column("fTenderAmountSystem")]
    public double? FTenderAmountSystem { get; set; }

    [Column("fTenderAmountAdjusted")]
    public double? FTenderAmountAdjusted { get; set; }

    [Column("fTenderAmountCounted")]
    public double? FTenderAmountCounted { get; set; }

    [Column("fTenderAmountFinalised")]
    public double? FTenderAmountFinalised { get; set; }

    [Column("_retAgentSessionTenderTotals_iBranchID")]
    public int? RetAgentSessionTenderTotalsIBranchId { get; set; }

    [Column("_retAgentSessionTenderTotals_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionTenderTotalsDCreatedDate { get; set; }

    [Column("_retAgentSessionTenderTotals_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionTenderTotalsDModifiedDate { get; set; }

    [Column("_retAgentSessionTenderTotals_iCreatedBranchID")]
    public int? RetAgentSessionTenderTotalsICreatedBranchId { get; set; }

    [Column("_retAgentSessionTenderTotals_iModifiedBranchID")]
    public int? RetAgentSessionTenderTotalsIModifiedBranchId { get; set; }

    [Column("_retAgentSessionTenderTotals_iCreatedAgentID")]
    public int? RetAgentSessionTenderTotalsICreatedAgentId { get; set; }

    [Column("_retAgentSessionTenderTotals_iModifiedAgentID")]
    public int? RetAgentSessionTenderTotalsIModifiedAgentId { get; set; }

    [Column("_retAgentSessionTenderTotals_iChangeSetID")]
    public int? RetAgentSessionTenderTotalsIChangeSetId { get; set; }

    [Column("_retAgentSessionTenderTotals_Checksum")]
    [MaxLength(20)]
    public byte[]? RetAgentSessionTenderTotalsChecksum { get; set; }
}
