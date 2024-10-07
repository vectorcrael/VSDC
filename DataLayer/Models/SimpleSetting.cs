using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

public partial class SimpleSetting
{
    [Key]
    [Column("SimpleSettingID")]
    public int SimpleSettingId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string Value { get; set; } = null!;

    [Column("AgentID")]
    public int AgentId { get; set; }

    [StringLength(50)]
    public string ApplicationName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Modified { get; set; }
}
