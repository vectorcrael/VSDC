using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevCashPickupFull
{
    [Column("idCashPickup")]
    public int IdCashPickup { get; set; }

    [Column("cTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCode { get; set; }

    [Column("dStartTime", TypeName = "datetime")]
    public DateTime? DStartTime { get; set; }

    [Column("dPickupDate", TypeName = "datetime")]
    public DateTime? DPickupDate { get; set; }

    [Column("cCashPickupReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCashPickupReference { get; set; }

    [Column("fPickupAmount")]
    public double? FPickupAmount { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }
}
