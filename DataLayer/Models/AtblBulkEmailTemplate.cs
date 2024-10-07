using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblBulkEmailTemplates")]
public partial class AtblBulkEmailTemplate
{
    [Key]
    [Column("idBulkEmailTemplate")]
    public int IdBulkEmailTemplate { get; set; }

    [Column("cTemplateName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTemplateName { get; set; }

    [Column("cTemplateDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTemplateDescription { get; set; }

    [Column("cDefaultOutline")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDefaultOutline { get; set; }

    [Column("bAllowSendSameTemplate")]
    public bool BAllowSendSameTemplate { get; set; }

    [Column("bCreateIncident")]
    public bool BCreateIncident { get; set; }

    [Column("iIncidentDefaultAgentID")]
    public int IIncidentDefaultAgentId { get; set; }

    [Column("iIncidentTypeID")]
    public int IIncidentTypeId { get; set; }

    [Column("iDueInDays")]
    public int IDueInDays { get; set; }

    [Column("bCreateAsClosed")]
    public bool BCreateAsClosed { get; set; }
}
