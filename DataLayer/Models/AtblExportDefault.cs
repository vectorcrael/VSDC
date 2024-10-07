using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblExportDefaults")]
public partial class AtblExportDefault
{
    [Key]
    [Column("idExportDefault")]
    public int IdExportDefault { get; set; }

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

    [Column("cDocumentExportPath")]
    [StringLength(500)]
    [Unicode(false)]
    public string CDocumentExportPath { get; set; } = null!;

    [Column("bSendEmail")]
    public bool BSendEmail { get; set; }

    [Column("bAppendDate")]
    public bool BAppendDate { get; set; }

    [Column("iHeaderCaptionType")]
    public int IHeaderCaptionType { get; set; }

    [Column("iEmailAccountID")]
    public int IEmailAccountId { get; set; }
}
