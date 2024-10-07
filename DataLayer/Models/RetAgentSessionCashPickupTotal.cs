using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retAgentSessionCashPickupTotals")]
[Index("RetAgentSessionCashPickupTotalsChecksum", Name = "idx__retAgentSessionCashPickupTotals__retAgentSessionCashPickupTotals_Checksum")]
[Index("RetAgentSessionCashPickupTotalsDModifiedDate", Name = "idx__retAgentSessionCashPickupTotals__retAgentSessionCashPickupTotals_dModifiedDate")]
[Index("RetAgentSessionCashPickupTotalsIBranchId", Name = "idx__retAgentSessionCashPickupTotals__retAgentSessionCashPickupTotals_iBranchID")]
[Index("RetAgentSessionCashPickupTotalsIChangeSetId", Name = "idx__retAgentSessionCashPickupTotals__retAgentSessionCashPickupTotals_iChangeSetID")]
[Index("IAgentSessionId", Name = "idx__retAgentSessionCashPickupTotals_iAgentSessionID")]
public partial class RetAgentSessionCashPickupTotal
{
    [Key]
    [Column("idAgentSessionCashPickupTotals")]
    public int IdAgentSessionCashPickupTotals { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("fCashPickupTotalSystem")]
    public double? FCashPickupTotalSystem { get; set; }

    [Column("fCashPickupTotalCounted")]
    public double? FCashPickupTotalCounted { get; set; }

    [Column("fCashPickupTotalFinalised")]
    public double? FCashPickupTotalFinalised { get; set; }

    [Column("_retAgentSessionCashPickupTotals_iBranchID")]
    public int? RetAgentSessionCashPickupTotalsIBranchId { get; set; }

    [Column("_retAgentSessionCashPickupTotals_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionCashPickupTotalsDCreatedDate { get; set; }

    [Column("_retAgentSessionCashPickupTotals_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionCashPickupTotalsDModifiedDate { get; set; }

    [Column("_retAgentSessionCashPickupTotals_iCreatedBranchID")]
    public int? RetAgentSessionCashPickupTotalsICreatedBranchId { get; set; }

    [Column("_retAgentSessionCashPickupTotals_iModifiedBranchID")]
    public int? RetAgentSessionCashPickupTotalsIModifiedBranchId { get; set; }

    [Column("_retAgentSessionCashPickupTotals_iCreatedAgentID")]
    public int? RetAgentSessionCashPickupTotalsICreatedAgentId { get; set; }

    [Column("_retAgentSessionCashPickupTotals_iModifiedAgentID")]
    public int? RetAgentSessionCashPickupTotalsIModifiedAgentId { get; set; }

    [Column("_retAgentSessionCashPickupTotals_iChangeSetID")]
    public int? RetAgentSessionCashPickupTotalsIChangeSetId { get; set; }

    [Column("_retAgentSessionCashPickupTotals_Checksum")]
    [MaxLength(20)]
    public byte[]? RetAgentSessionCashPickupTotalsChecksum { get; set; }
}
