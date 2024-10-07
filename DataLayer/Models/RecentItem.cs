using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

public partial class RecentItem
{
    [Key]
    [Column("RecentItemID")]
    public int RecentItemId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [Column("AgentID")]
    public int AgentId { get; set; }

    [StringLength(50)]
    public string ApplicationName { get; set; } = null!;
}
