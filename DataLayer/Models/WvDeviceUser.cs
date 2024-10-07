using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class WvDeviceUser
{
    [Column("idIPadUser")]
    public long IdIpadUser { get; set; }

    [Column("idAgents")]
    public int IdAgents { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cDisplayName")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDisplayName { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bIsActive")]
    public bool BIsActive { get; set; }

    [Column("sUserRole")]
    [StringLength(14)]
    [Unicode(false)]
    public string SUserRole { get; set; } = null!;

    [StringLength(24)]
    [Unicode(false)]
    public string Device { get; set; } = null!;

    [Column("iModuleType")]
    public int IModuleType { get; set; }

    [Column("bIsUserRoleMgmt")]
    public bool BIsUserRoleMgmt { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string WhseCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RepCode { get; set; } = null!;

    [Column("cCode")]
    [StringLength(18)]
    public string CCode { get; set; } = null!;

    [Column("cDeviceDescription")]
    [StringLength(50)]
    public string CDeviceDescription { get; set; } = null!;

    [Column("cUDID")]
    [StringLength(50)]
    public string CUdid { get; set; } = null!;

    [Column("bAllCustomers")]
    public bool? BAllCustomers { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TrCode { get; set; } = null!;

    [Column("SalesWH")]
    [StringLength(20)]
    [Unicode(false)]
    public string SalesWh { get; set; } = null!;

    [Column("iTrCodeID")]
    public int? ITrCodeId { get; set; }
}
