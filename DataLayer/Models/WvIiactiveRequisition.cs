using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class WvIiactiveRequisition
{
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

    [StringLength(400)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("Description_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Description1 { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cStatus")]
    [StringLength(8)]
    [Unicode(false)]
    public string? CStatus { get; set; }

    [Column("iReqStatus")]
    public int? IReqStatus { get; set; }

    [Column("idAgents")]
    public int IdAgents { get; set; }

    [Column("StkItem_iBranchID")]
    public int? StkItemIBranchId { get; set; }
}
