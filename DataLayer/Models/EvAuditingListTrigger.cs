using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvAuditingListTrigger
{
    [StringLength(128)]
    public string? TableName { get; set; }

    [StringLength(128)]
    public string TriggerName { get; set; } = null!;
}
