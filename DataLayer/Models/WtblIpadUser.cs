using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_wtblIPadUser")]
public partial class WtblIpadUser
{
    [Key]
    [Column("idIPadUser")]
    public long IdIpadUser { get; set; }

    [Column("iAgentId")]
    public long IAgentId { get; set; }

    [Column("bIsUserRoleMgmt")]
    public bool BIsUserRoleMgmt { get; set; }

    [Column("bIsActive")]
    public bool BIsActive { get; set; }

    [Column("dtCreatedDt", TypeName = "datetime")]
    public DateTime? DtCreatedDt { get; set; }

    [Column("dtModifiedDt", TypeName = "datetime")]
    public DateTime? DtModifiedDt { get; set; }

    [Column("iCreatedAgentId")]
    public int? ICreatedAgentId { get; set; }

    [Column("iModifiedAgentId")]
    public int? IModifiedAgentId { get; set; }

    [Column("iModuleType")]
    public int IModuleType { get; set; }

    [Column("iDefSalesRepID")]
    public int? IDefSalesRepId { get; set; }

    [Column("iDefWarehouseID")]
    public int? IDefWarehouseId { get; set; }

    [Column("iAssignedIPadID")]
    public long? IAssignedIpadId { get; set; }

    [Column("bAllCustomers")]
    public bool? BAllCustomers { get; set; }

    [Column("iSalesWarehouseID")]
    public int? ISalesWarehouseId { get; set; }

    [Column("iTrCodeID")]
    public int? ITrCodeId { get; set; }

    [Column("bUseInvoice")]
    public bool? BUseInvoice { get; set; }
}
