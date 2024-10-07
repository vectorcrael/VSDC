using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblUnits")]
[Index("EtblUnitsChecksum", Name = "idx__etblUnits__etblUnits_Checksum")]
[Index("EtblUnitsIChangeSetId", Name = "idx__etblUnits_iChangeSetID")]
[Index("EtblUnitsDModifiedDate", Name = "idx_etblUnits_dModifiedDate")]
[Index("EtblUnitsIBranchId", Name = "idx_etblUnits_iBranchID")]
public partial class EtblUnit
{
    [Key]
    [Column("idUnits")]
    public int IdUnits { get; set; }

    [Column("cUnitCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CUnitCode { get; set; }

    [Column("cUnitDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CUnitDescription { get; set; }

    [Column("iUnitCategoryID")]
    public int? IUnitCategoryId { get; set; }

    [Column("_etblUnits_iBranchID")]
    public int? EtblUnitsIBranchId { get; set; }

    [Column("_etblUnits_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblUnitsDCreatedDate { get; set; }

    [Column("_etblUnits_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblUnitsDModifiedDate { get; set; }

    [Column("_etblUnits_iCreatedBranchID")]
    public int? EtblUnitsICreatedBranchId { get; set; }

    [Column("_etblUnits_iModifiedBranchID")]
    public int? EtblUnitsIModifiedBranchId { get; set; }

    [Column("_etblUnits_iCreatedAgentID")]
    public int? EtblUnitsICreatedAgentId { get; set; }

    [Column("_etblUnits_iModifiedAgentID")]
    public int? EtblUnitsIModifiedAgentId { get; set; }

    [Column("bUnitRoundUp")]
    public bool BUnitRoundUp { get; set; }

    [Column("_etblUnits_iChangeSetID")]
    public int? EtblUnitsIChangeSetId { get; set; }

    [Column("_etblUnits_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblUnitsChecksum { get; set; }
}
