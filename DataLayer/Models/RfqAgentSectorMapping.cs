using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_AgentSectorMapping")]
public partial class RfqAgentSectorMapping
{
    [Key]
    [Column("idAgentSectorMap")]
    public int IdAgentSectorMap { get; set; }

    [Column("idAgents")]
    public int? IdAgents { get; set; }

    [Unicode(false)]
    public string? SectorIds { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [ForeignKey("IdAgents")]
    [InverseProperty("RfqAgentSectorMappings")]
    public virtual RtblAgent? IdAgentsNavigation { get; set; }
}
