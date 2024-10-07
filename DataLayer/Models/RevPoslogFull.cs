using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevPoslogFull
{
    [Column("iInvNumID")]
    public int? IInvNumId { get; set; }

    [Column("iInvLineID")]
    public long? IInvLineId { get; set; }

    [Column("iSystemFunctionID")]
    public int? ISystemFunctionId { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }

    [Column("iSupervisorAgentID")]
    public int? ISupervisorAgentId { get; set; }

    [Column("cDescription")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("dStartTime", TypeName = "datetime")]
    public DateTime? DStartTime { get; set; }

    [Column("_retPOSLogLinks_iBranchID")]
    public int? RetPoslogLinksIBranchId { get; set; }
}
