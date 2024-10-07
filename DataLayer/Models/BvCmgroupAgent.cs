using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCmgroupAgent
{
    [Column("iGroupID")]
    public int IGroupId { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("idAgents")]
    public int? IdAgents { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }

    [Column("cEmail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CEmail { get; set; }

    [Column("_rtblAgents_iBranchID")]
    public int? RtblAgentsIBranchId { get; set; }
}
