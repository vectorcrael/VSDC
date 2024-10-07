using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblExportTemplates")]
public partial class AtblExportTemplate
{
    [Key]
    [Column("idExportTemplate")]
    public int IdExportTemplate { get; set; }

    [Column("cTemplateDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string CTemplateDescription { get; set; } = null!;

    [Column("cTableName")]
    [StringLength(258)]
    [Unicode(false)]
    public string CTableName { get; set; } = null!;

    [Column("cFilePrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string CFilePrefix { get; set; } = null!;

    [Column("bAppendDateToFile")]
    public bool BAppendDateToFile { get; set; }

    [Column("bPlaceInSubFolder")]
    public bool BPlaceInSubFolder { get; set; }

    [Column("cSubFolderName")]
    [StringLength(128)]
    [Unicode(false)]
    public string CSubFolderName { get; set; } = null!;

    [Column("bSendEmailAfterExport")]
    public bool BSendEmailAfterExport { get; set; }

    [Column("bAttachExportFileToEmail")]
    public bool BAttachExportFileToEmail { get; set; }

    [Column("cSendEmailTo")]
    [StringLength(256)]
    [Unicode(false)]
    public string CSendEmailTo { get; set; } = null!;

    [Column("bCreateIncidentAfterExport")]
    public bool BCreateIncidentAfterExport { get; set; }

    [Column("bAttachExportFileToIncident")]
    public bool BAttachExportFileToIncident { get; set; }

    [Column("iIncidentTypeID")]
    public int IIncidentTypeId { get; set; }

    [Column("iAssignedToAgentID")]
    public int IAssignedToAgentId { get; set; }

    [Column("iExportType")]
    public int? IExportType { get; set; }

    [Column("cColumnName")]
    [StringLength(128)]
    [Unicode(false)]
    public string? CColumnName { get; set; }

    [Column("iLastExportedID")]
    public int? ILastExportedId { get; set; }

    [Column("dLastExportedDate", TypeName = "datetime")]
    public DateTime? DLastExportedDate { get; set; }

    [Column("bIncludeRowCounter")]
    public bool? BIncludeRowCounter { get; set; }

    [Column("bCreateModifiedTrigger")]
    public bool? BCreateModifiedTrigger { get; set; }

    [Column("cRowCounterCaption")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRowCounterCaption { get; set; }
}
