using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_wtblIPadDetails")]
public partial class WtblIpadDetail
{
    [Key]
    [Column("idIPadNumber")]
    public long IdIpadNumber { get; set; }

    [Column("cCode")]
    [StringLength(18)]
    public string? CCode { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    public string? CDescription { get; set; }

    [Column("cUDID")]
    [StringLength(50)]
    public string? CUdid { get; set; }

    [Column("cAutoNumber")]
    [StringLength(50)]
    public string? CAutoNumber { get; set; }

    [Column("dtTimeStamp", TypeName = "datetime")]
    public DateTime? DtTimeStamp { get; set; }

    [Column("dtCreatedDt", TypeName = "datetime")]
    public DateTime? DtCreatedDt { get; set; }

    [Column("dtModifiedDt", TypeName = "datetime")]
    public DateTime? DtModifiedDt { get; set; }

    [Column("iCreatedAgentId")]
    public int? ICreatedAgentId { get; set; }

    [Column("iModifiedAgentId")]
    public int? IModifiedAgentId { get; set; }

    [Column("iDeviceType")]
    public int IDeviceType { get; set; }

    [Column("bIsActive")]
    public bool BIsActive { get; set; }
}
