using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retAgentSessionDenomination")]
[Index("RetAgentSessionDenominationChecksum", Name = "idx__retAgentSessionDenomination__retAgentSessionDenomination_Checksum")]
[Index("RetAgentSessionDenominationDModifiedDate", Name = "idx__retAgentSessionDenomination__retAgentSessionDenomination_dModifiedDate")]
[Index("RetAgentSessionDenominationIBranchId", Name = "idx__retAgentSessionDenomination__retAgentSessionDenomination_iBranchID")]
[Index("RetAgentSessionDenominationIChangeSetId", Name = "idx__retAgentSessionDenomination__retAgentSessionDenomination_iChangeSetID")]
[Index("IAgentSessionId", Name = "idx__retAgentSessionDenomination_iAgentSessionID")]
public partial class RetAgentSessionDenomination
{
    [Key]
    [Column("idAgentSessionDenomination")]
    public int IdAgentSessionDenomination { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("iDenominationID")]
    public int? IDenominationId { get; set; }

    [Column("iFloatCount")]
    public int? IFloatCount { get; set; }

    [Column("iCashCount")]
    public int? ICashCount { get; set; }

    [Column("iFloatCountFinalised")]
    public int? IFloatCountFinalised { get; set; }

    [Column("iCashCountFinalised")]
    public int? ICashCountFinalised { get; set; }

    [Column("_retAgentSessionDenomination_iBranchID")]
    public int? RetAgentSessionDenominationIBranchId { get; set; }

    [Column("_retAgentSessionDenomination_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionDenominationDCreatedDate { get; set; }

    [Column("_retAgentSessionDenomination_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionDenominationDModifiedDate { get; set; }

    [Column("_retAgentSessionDenomination_iCreatedBranchID")]
    public int? RetAgentSessionDenominationICreatedBranchId { get; set; }

    [Column("_retAgentSessionDenomination_iModifiedBranchID")]
    public int? RetAgentSessionDenominationIModifiedBranchId { get; set; }

    [Column("_retAgentSessionDenomination_iCreatedAgentID")]
    public int? RetAgentSessionDenominationICreatedAgentId { get; set; }

    [Column("_retAgentSessionDenomination_iModifiedAgentID")]
    public int? RetAgentSessionDenominationIModifiedAgentId { get; set; }

    [Column("_retAgentSessionDenomination_iChangeSetID")]
    public int? RetAgentSessionDenominationIChangeSetId { get; set; }

    [Column("_retAgentSessionDenomination_Checksum")]
    [MaxLength(20)]
    public byte[]? RetAgentSessionDenominationChecksum { get; set; }
}
