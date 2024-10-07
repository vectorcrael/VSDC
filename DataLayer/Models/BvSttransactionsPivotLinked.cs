using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvSttransactionsPivotLinked
{
    [Column("cAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LinkedAccount { get; set; }

    public int? LinkedAccLink { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? LinkedAccountName { get; set; }

    [StringLength(172)]
    [Unicode(false)]
    public string? LinkedBoth { get; set; }

    [Column("LinkedRepID")]
    public int LinkedRepId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LinkedRepCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LinkedRepName { get; set; }

    [StringLength(52)]
    [Unicode(false)]
    public string? LinkedRepBoth { get; set; }

    [Column("LinkedClassID")]
    public int LinkedClassId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LinkedClassCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LinkedClassName { get; set; }

    [StringLength(122)]
    [Unicode(false)]
    public string? LinkedClassBoth { get; set; }

    [Column("LinkedAreaID")]
    public int LinkedAreaId { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? LinkedAreaCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LinkedAreaName { get; set; }

    [StringLength(42)]
    [Unicode(false)]
    public string? LinkedAreaBoth { get; set; }
}
