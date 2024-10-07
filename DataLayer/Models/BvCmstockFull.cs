using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCmstockFull
{
    [Column("ItemID")]
    public int ItemId { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDesc1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDesc2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDesc3 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ItemDateReleased { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemComponent { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemRevision { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemModel { get; set; }

    public bool ItemActive { get; set; }

    [Column("iInvSegValue1ID")]
    public int? IInvSegValue1Id { get; set; }

    [Column("iInvSegValue2ID")]
    public int? IInvSegValue2Id { get; set; }

    [Column("iInvSegValue3ID")]
    public int? IInvSegValue3Id { get; set; }

    [Column("iInvSegValue4ID")]
    public int? IInvSegValue4Id { get; set; }

    [Column("iInvSegValue5ID")]
    public int? IInvSegValue5Id { get; set; }

    [Column("iInvSegValue6ID")]
    public int? IInvSegValue6Id { get; set; }

    [Column("iInvSegValue7ID")]
    public int? IInvSegValue7Id { get; set; }

    [Column("StkItem_iBranchID")]
    public int? StkItemIBranchId { get; set; }
}
