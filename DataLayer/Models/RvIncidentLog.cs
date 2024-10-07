using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RvIncidentLog
{
    [Column("IncidentID")]
    public int IncidentId { get; set; }

    [Column("IncidentLogID")]
    public int IncidentLogId { get; set; }

    [Column(TypeName = "text")]
    public string? IncidentActionResolution { get; set; }

    [Column("dActionDate", TypeName = "datetime")]
    public DateTime DActionDate { get; set; }

    [Column("ActionTypeID")]
    public int ActionTypeId { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? ActionTypeDescription { get; set; }

    [Column("ActionTypePDescription")]
    [StringLength(32)]
    [Unicode(false)]
    public string? ActionTypePdescription { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ActionReceiverText { get; set; } = null!;

    [Column("ActionByAgentID")]
    public int? ActionByAgentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ActionByAgentName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ActionByAgentFullName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActionByAgentTelWork { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActionByAgentTelMobile { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ActionByAgentEmail { get; set; }

    public bool ProxyAction { get; set; }

    [Column("ActionToAgentID")]
    public int? ActionToAgentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ActionToAgentName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ActionToAgentFullName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActionToAgentTelWork { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActionToAgentTelMobile { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ActionToAgentEmail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RejectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RejectReason { get; set; }

    [Column("_rtblIncidentLog_iBranchID")]
    public int? RtblIncidentLogIBranchId { get; set; }
}
