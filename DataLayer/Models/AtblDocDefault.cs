using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblDocDefaults")]
public partial class AtblDocDefault
{
    [Key]
    [Column("idDocDefault")]
    public int IdDocDefault { get; set; }

    [Column("bCreateIncident")]
    public bool BCreateIncident { get; set; }

    [Column("iIncidentDefaultAgentID")]
    public int? IIncidentDefaultAgentId { get; set; }

    [Column("iIncidentTypeID")]
    public int? IIncidentTypeId { get; set; }

    [Column("bIncidentAttachDocument")]
    public bool? BIncidentAttachDocument { get; set; }

    [Column("iImportFileType")]
    public int IImportFileType { get; set; }

    [Column("cDelimiter")]
    [StringLength(5)]
    [Unicode(false)]
    public string CDelimiter { get; set; } = null!;

    [Column("cDateFormat")]
    [StringLength(20)]
    [Unicode(false)]
    public string CDateFormat { get; set; } = null!;

    [Column("cDateSeparator")]
    [StringLength(5)]
    [Unicode(false)]
    public string CDateSeparator { get; set; } = null!;

    [Column("bUseShortDate")]
    public bool BUseShortDate { get; set; }

    [Column("cDocumentImportPath")]
    [StringLength(500)]
    [Unicode(false)]
    public string CDocumentImportPath { get; set; } = null!;

    [Column("bSendEmail")]
    public bool BSendEmail { get; set; }

    [Column("bEmailAttachDocument")]
    public bool? BEmailAttachDocument { get; set; }

    [Column("iEmailAccountID")]
    public int IEmailAccountId { get; set; }

    [Column("iHeaderCaptionType")]
    public int IHeaderCaptionType { get; set; }

    [Column("cServerName")]
    [StringLength(200)]
    [Unicode(false)]
    public string CServerName { get; set; } = null!;
}
