using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvAuditingAuditedTable
{
    [StringLength(128)]
    public string TableName { get; set; } = null!;

    public int Audited { get; set; }

    public int AuditTableExists { get; set; }
}
