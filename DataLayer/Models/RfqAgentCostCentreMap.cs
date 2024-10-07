using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_AgentCostCentreMap")]
public partial class RfqAgentCostCentreMap
{
    [Key]
    [Column("idAgentCostCentreMap")]
    public int IdAgentCostCentreMap { get; set; }

    [Column("idAgent")]
    public int? IdAgent { get; set; }

    [Unicode(false)]
    public string? CostCentreId { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [ForeignKey("IdAgent")]
    [InverseProperty("RfqAgentCostCentreMaps")]
    public virtual RtblAgent? IdAgentNavigation { get; set; }
}
