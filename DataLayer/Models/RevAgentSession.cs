using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevAgentSession
{
    [Column("idAgentSession")]
    public int IdAgentSession { get; set; }

    [Column("iTradingSessionID")]
    public int? ITradingSessionId { get; set; }

    [Column("bIsTillSession")]
    public bool BIsTillSession { get; set; }

    [Column("iTillSessionID")]
    public int? ITillSessionId { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("iTillID")]
    public int? ITillId { get; set; }

    [Column("fAgentFloat")]
    public double? FAgentFloat { get; set; }

    [Column("dCurrentDate", TypeName = "datetime")]
    public DateTime? DCurrentDate { get; set; }

    [Column("bCashedUp")]
    public bool? BCashedUp { get; set; }

    [Column("cCashUpReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCashUpReference { get; set; }

    [Column("dCashUpDate", TypeName = "datetime")]
    public DateTime? DCashUpDate { get; set; }

    [Column("iCashUpTillID")]
    public int? ICashUpTillId { get; set; }

    [Column("bCashUpFinalised")]
    public bool BCashUpFinalised { get; set; }

    [Column("iFinaliseAgentID")]
    public int? IFinaliseAgentId { get; set; }

    [Column("dFinalisedDate", TypeName = "datetime")]
    public DateTime? DFinalisedDate { get; set; }

    [Column("fAgentFloatCounted")]
    public double? FAgentFloatCounted { get; set; }

    [Column("fAgentFloatFinalised")]
    public double? FAgentFloatFinalised { get; set; }

    [Column("_retAgentSession_iBranchID")]
    public int? RetAgentSessionIBranchId { get; set; }

    [Column("_retAgentSession_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionDCreatedDate { get; set; }

    [Column("_retAgentSession_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetAgentSessionDModifiedDate { get; set; }

    [Column("_retAgentSession_iCreatedBranchID")]
    public int? RetAgentSessionICreatedBranchId { get; set; }

    [Column("_retAgentSession_iModifiedBranchID")]
    public int? RetAgentSessionIModifiedBranchId { get; set; }

    [Column("_retAgentSession_iCreatedAgentID")]
    public int? RetAgentSessionICreatedAgentId { get; set; }

    [Column("_retAgentSession_iModifiedAgentID")]
    public int? RetAgentSessionIModifiedAgentId { get; set; }

    [Column("_retAgentSession_iChangeSetID")]
    public int? RetAgentSessionIChangeSetId { get; set; }

    [Column("iFloatInitialiseAgentID")]
    public int? IFloatInitialiseAgentId { get; set; }

    [Column("iCashUpAgentID")]
    public int? ICashUpAgentId { get; set; }

    [Column("_retAgentSession_Checksum")]
    [MaxLength(20)]
    public byte[]? RetAgentSessionChecksum { get; set; }

    [Column("iSessionStatus")]
    public int? ISessionStatus { get; set; }

    [Column("dTradingDate", TypeName = "datetime")]
    public DateTime? DTradingDate { get; set; }

    [Column("cSessionDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSessionDescription { get; set; }

    [Column("dStartTime", TypeName = "datetime")]
    public DateTime? DStartTime { get; set; }

    [Column("dEndTime", TypeName = "datetime")]
    public DateTime? DEndTime { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCode { get; set; }

    [Column("cTillSessionTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillSessionTillCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FloatInitialiseAgent { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CashUpAgent { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FinaliseAgent { get; set; }
}
