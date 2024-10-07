using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvEftsfileLayout
{
    [StringLength(200)]
    [Unicode(false)]
    public string LayoutDescription { get; set; } = null!;

    [Column("EFTSLayoutDetailsID")]
    public int? EftslayoutDetailsId { get; set; }

    [Column("EFTSLayoutID")]
    public int? EftslayoutId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecordType { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FieldName { get; set; }

    public int? FieldLength { get; set; }

    public int? DecimalPlaces { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FieldFormat { get; set; }

    public int? FillerType { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? DefaultValue { get; set; }

    public bool? FieldInUse { get; set; }
}
