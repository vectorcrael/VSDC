﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvInvNumArlookupDatum
{
    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNum { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? OrderDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    public int AutoIndex { get; set; }

    [Column("AccountID")]
    public int? AccountId { get; set; }
}
