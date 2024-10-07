using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retAgentSessionPettyCashTotals")]
[Index("RetAgentSessionPettyCashTotalsChecksum", Name = "idx__retAgentSessionPettyCashTotals__retAgentSessionPettyCashTotals_Checksum")]
[Index("RetAgentSessionPettyCashTotalsDModifiedDate", Name = "idx__retAgentSessionPettyCashTotals__retAgentSessionPettyCashTotals_dModifiedDate")]
[Index("RetAgentSessionPettyCashTotalsIBranchId", Name = "idx__retAgentSessionPettyCashTotals__retAgentSessionPettyCashTotals_iBranchID")]
[Index("RetAgentSessionPettyCashTotalsIChangeSetId", Name = "idx__retAgentSessionPettyCashTotals__retAgentSessionPettyCashTotals_iChangeSetID")]
[Index("IAgentSessionId", Name = "idx__retAgentSessionPettyCashTotals_iAgentSessionID")]
public partial class RetAgentSessionPettyCashTotal
{
    [Key]
    [Column("idAgentSessionPettyCashTotals")]
    public int IdAgentSessionPettyCashTotals { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("fAdvancedTotalSystem")]
    public double? FAdvancedTotalSystem { get; set; }

    [Column("fAdvancedTotalCounted")]
    public double? FAdvancedTotalCounted { get; set; }

    [Column("fAdvancedTotalFinalised")]
    public double? FAdvancedTotalFinalised { get; set; }

    [Column("fChangeTotalSystem")]
    public double? FChangeTotalSystem { get; set; }

    [Column("fChangeTotalCounted")]
    public double? FChangeTotalCounted { get; set; }

    [Column("fChangeTotalFinalised")]
    public double? FChangeTotalFinalised { get; set; }

    [Column("_retAgentSessionPettyCashTotals_iBranchID")]
    public int? RetAgentSessionPettyCashTotalsIBranchId { get; set; }

    [Column("_retAgentSessionPettyCashTotals_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionPettyCashTotalsDCreatedDate { get; set; }

    [Column("_retAgentSessionPettyCashTotals_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionPettyCashTotalsDModifiedDate { get; set; }

    [Column("_retAgentSessionPettyCashTotals_iCreatedBranchID")]
    public int? RetAgentSessionPettyCashTotalsICreatedBranchId { get; set; }

    [Column("_retAgentSessionPettyCashTotals_iModifiedBranchID")]
    public int? RetAgentSessionPettyCashTotalsIModifiedBranchId { get; set; }

    [Column("_retAgentSessionPettyCashTotals_iCreatedAgentID")]
    public int? RetAgentSessionPettyCashTotalsICreatedAgentId { get; set; }

    [Column("_retAgentSessionPettyCashTotals_iModifiedAgentID")]
    public int? RetAgentSessionPettyCashTotalsIModifiedAgentId { get; set; }

    [Column("_retAgentSessionPettyCashTotals_iChangeSetID")]
    public int? RetAgentSessionPettyCashTotalsIChangeSetId { get; set; }

    [Column("_retAgentSessionPettyCashTotals_Checksum")]
    [MaxLength(20)]
    public byte[]? RetAgentSessionPettyCashTotalsChecksum { get; set; }
}
