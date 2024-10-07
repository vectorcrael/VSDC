using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblBulkEmailAccounts")]
public partial class AtblBulkEmailAccount
{
    [Key]
    [Column("idBulkEmailAccount")]
    public int IdBulkEmailAccount { get; set; }

    [Column("cEmailSettingName")]
    [StringLength(100)]
    [Unicode(false)]
    public string CEmailSettingName { get; set; } = null!;

    [Column("cFromEmail")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CFromEmail { get; set; }

    [Column("cToEmail")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CToEmail { get; set; }

    [Column("cSMTPServer")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSmtpserver { get; set; }

    [Column("iPortNumber")]
    public int? IPortNumber { get; set; }

    [Column("cEmailUserName")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CEmailUserName { get; set; }

    [Column("cEmailPassword")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CEmailPassword { get; set; }

    [Column("bEmailRequiresSSL")]
    public bool BEmailRequiresSsl { get; set; }
}
