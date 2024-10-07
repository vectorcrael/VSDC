using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retTradingSession")]
[Index("RetTradingSessionChecksum", Name = "idx__retTradingSession__retTradingSession_Checksum")]
[Index("RetTradingSessionDModifiedDate", Name = "idx__retTradingSession__retTradingSession_dModifiedDate")]
[Index("RetTradingSessionIBranchId", Name = "idx__retTradingSession__retTradingSession_iBranchID")]
[Index("RetTradingSessionIChangeSetId", Name = "idx__retTradingSession__retTradingSession_iChangeSetID")]
public partial class RetTradingSession
{
    [Key]
    [Column("idTradingSession")]
    public int IdTradingSession { get; set; }

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

    [Column("iStartAgentID")]
    public int? IStartAgentId { get; set; }

    [Column("dEndTime", TypeName = "datetime")]
    public DateTime? DEndTime { get; set; }

    [Column("iEndAgentID")]
    public int? IEndAgentId { get; set; }

    [Column("iFinaliseAgentID")]
    public int? IFinaliseAgentId { get; set; }

    [Column("iExpectedDuration")]
    public int? IExpectedDuration { get; set; }

    [Column("bDisableTradingOnExpiry")]
    public bool BDisableTradingOnExpiry { get; set; }

    [Column("_retTradingSession_iBranchID")]
    public int? RetTradingSessionIBranchId { get; set; }

    [Column("_retTradingSession_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetTradingSessionDCreatedDate { get; set; }

    [Column("_retTradingSession_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetTradingSessionDModifiedDate { get; set; }

    [Column("_retTradingSession_iCreatedBranchID")]
    public int? RetTradingSessionICreatedBranchId { get; set; }

    [Column("_retTradingSession_iModifiedBranchID")]
    public int? RetTradingSessionIModifiedBranchId { get; set; }

    [Column("_retTradingSession_iCreatedAgentID")]
    public int? RetTradingSessionICreatedAgentId { get; set; }

    [Column("_retTradingSession_iModifiedAgentID")]
    public int? RetTradingSessionIModifiedAgentId { get; set; }

    [Column("_retTradingSession_iChangeSetID")]
    public int? RetTradingSessionIChangeSetId { get; set; }

    [Column("_retTradingSession_Checksum")]
    [MaxLength(20)]
    public byte[]? RetTradingSessionChecksum { get; set; }
}
