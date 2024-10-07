using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_simtblReqHeader")]
public partial class SimtblReqHeader
{
    [Key]
    [Column("idReqHeader")]
    public int IdReqHeader { get; set; }

    [Column("cRequisitionNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRequisitionNo { get; set; }

    [Column("dRequisitionDate", TypeName = "datetime")]
    public DateTime? DRequisitionDate { get; set; }

    [Column("iProjectDefaultID")]
    public int? IProjectDefaultId { get; set; }

    [Column("cRequestedBy")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRequestedBy { get; set; }

    [Column("iIncidentTypeDefaultID")]
    public int? IIncidentTypeDefaultId { get; set; }

    [Column("iStatus")]
    public int? IStatus { get; set; }

    [Column("iAgentID")]
    public int? IAgentId { get; set; }
}
