using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class WvIncinvCntBatchByDeviceUser
{
    [Column("idIPadInvCount")]
    public int IdIpadInvCount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Number { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int CountLines { get; set; }

    public int? CountedLines { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Agent { get; set; }

    [StringLength(18)]
    public string DeviceCode { get; set; } = null!;

    [StringLength(50)]
    public string DeviceDescription { get; set; } = null!;

    [Column("DeviceUniqueID")]
    [StringLength(50)]
    public string DeviceUniqueId { get; set; } = null!;

    [Column("idAgents")]
    public int IdAgents { get; set; }

    [Column("idInvCount")]
    public int IdInvCount { get; set; }

    [Column("idIPadUser")]
    public long IdIpadUser { get; set; }

    [Column("_wtblMapIPadUserToInvCount_iBranchID")]
    public int? WtblMapIpadUserToInvCountIBranchId { get; set; }

    [Column("iStatusId")]
    public int? IStatusId { get; set; }
}
