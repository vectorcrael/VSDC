using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvArauditLinkedAccRep
{
    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LinkedAccount { get; set; }

    [Column("RepID")]
    public int? RepId { get; set; }
}
