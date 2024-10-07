using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevAgentSessionCashUp
{
    [Column("idAgentSession")]
    public int IdAgentSession { get; set; }

    [Column("_retAgentSession_iBranchID")]
    public int? RetAgentSessionIBranchId { get; set; }

    [Column("iTradingSessionID")]
    public int? ITradingSessionId { get; set; }

    [Column("iTillID")]
    public int? ITillId { get; set; }

    [Column("bIsTillSession")]
    public bool BIsTillSession { get; set; }

    [Column("iTillSessionID")]
    public int? ITillSessionId { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("fAgentFloat")]
    public double? FAgentFloat { get; set; }

    [Column("fAgentFloatCounted")]
    public double? FAgentFloatCounted { get; set; }

    [Column("fAgentFloatFinalised")]
    public double? FAgentFloatFinalised { get; set; }

    [Column("dStartTime", TypeName = "datetime")]
    public DateTime? DStartTime { get; set; }

    [Column("dCurrentDate", TypeName = "datetime")]
    public DateTime? DCurrentDate { get; set; }

    [Column("bCashedUp")]
    public bool? BCashedUp { get; set; }

    [Column("dCashUpDate", TypeName = "datetime")]
    public DateTime? DCashUpDate { get; set; }

    [Column("bCashUpFinalised")]
    public bool BCashUpFinalised { get; set; }

    [Column("iFinaliseAgentID")]
    public int? IFinaliseAgentId { get; set; }

    [Column("cAgentNameFinalised")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentNameFinalised { get; set; }

    [Column("dFinalisedDate", TypeName = "datetime")]
    public DateTime? DFinalisedDate { get; set; }

    [Column("cCashUpReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCashUpReference { get; set; }

    [Column("iCashUpTillID")]
    public int? ICashUpTillId { get; set; }

    [Column("cTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCode { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? OpenTillCode { get; set; }

    public double TotalCashTenders { get; set; }

    public double TotalCashTendersPredicted { get; set; }

    public double TotalCashTendersFinalisedPredicted { get; set; }

    public double TotalCashPickupSystem { get; set; }

    public double TotalCashPickupCounted { get; set; }

    public double TotalCashPickupFinalised { get; set; }

    public double TotalPettyCashAdvancedSystem { get; set; }

    public double TotalPettyCashAdvancedCounted { get; set; }

    public double TotalPettyCashAdvancedFinalised { get; set; }

    public double TotalPettyCashChangeSystem { get; set; }

    public double TotalPettyCashChangeCounted { get; set; }

    public double TotalPettyCashChangeFinalised { get; set; }

    public double TotalCashSystem { get; set; }

    public double TotalCashAdjusted { get; set; }

    public double TotalCashCounted { get; set; }

    public double TotalCashFinalised { get; set; }

    public double TotalSystem { get; set; }

    public double TotalSystemAdjusted { get; set; }

    public double TotalSystemCounted { get; set; }

    public double TotalSystemFinalised { get; set; }

    [Column("cCashupAgent")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCashupAgent { get; set; }
}
