using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

public partial class PinnedItem
{
    [Key]
    [Column("PinnedItemID")]
    public int PinnedItemId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(160)]
    public string? Description { get; set; }

    [StringLength(50)]
    public string? BackGround { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Modified { get; set; }

    [Column("AgentID")]
    public int AgentId { get; set; }

    [StringLength(50)]
    public string ApplicationName { get; set; } = null!;
}
