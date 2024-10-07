using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_wtblPEMMobilityModules")]
public partial class WtblPemmobilityModule
{
    [Key]
    [Column("idMobilityModule")]
    public int IdMobilityModule { get; set; }

    [Column("cCode")]
    [StringLength(50)]
    public string CCode { get; set; } = null!;

    [Column("cName")]
    [StringLength(50)]
    public string CName { get; set; } = null!;

    [Column("cDescription")]
    public string CDescription { get; set; } = null!;

    [Column("iModuleTypeId")]
    public int IModuleTypeId { get; set; }

    [Column("gIdentifier")]
    public Guid? GIdentifier { get; set; }

    [Column("bIsWinjitModule")]
    public bool BIsWinjitModule { get; set; }

    [Column("bIsOneAgentPerDevice")]
    public bool BIsOneAgentPerDevice { get; set; }

    [Column("bIsMultipleDevicePerAgent")]
    public bool BIsMultipleDevicePerAgent { get; set; }

    [Column("bIsActive")]
    public bool BIsActive { get; set; }
}
