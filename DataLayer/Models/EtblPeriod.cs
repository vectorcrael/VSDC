using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPeriod")]
[Index("EtblPeriodChecksum", Name = "idx__etblPeriod__etblPeriod_Checksum")]
[Index("EtblPeriodDModifiedDate", Name = "idx__etblPeriod__etblPeriod_dModifiedDate")]
[Index("EtblPeriodIBranchId", Name = "idx__etblPeriod__etblPeriod_iBranchID")]
[Index("EtblPeriodIChangeSetId", Name = "idx__etblPeriod__etblPeriod_iChangeSetID")]
public partial class EtblPeriod
{
    [Key]
    [Column("idPeriod")]
    public int IdPeriod { get; set; }

    [Column("dPeriodDate", TypeName = "datetime")]
    public DateTime DPeriodDate { get; set; }

    [Column("bBlocked")]
    public bool BBlocked { get; set; }

    [Column("bPBTProcessed")]
    public bool BPbtprocessed { get; set; }

    [Column("bPeriodProcessed")]
    public bool BPeriodProcessed { get; set; }

    [Column("_etblPeriod_iBranchID")]
    public int? EtblPeriodIBranchId { get; set; }

    [Column("_etblPeriod_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPeriodDCreatedDate { get; set; }

    [Column("_etblPeriod_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPeriodDModifiedDate { get; set; }

    [Column("_etblPeriod_iCreatedBranchID")]
    public int? EtblPeriodICreatedBranchId { get; set; }

    [Column("_etblPeriod_iModifiedBranchID")]
    public int? EtblPeriodIModifiedBranchId { get; set; }

    [Column("_etblPeriod_iCreatedAgentID")]
    public int? EtblPeriodICreatedAgentId { get; set; }

    [Column("_etblPeriod_iModifiedAgentID")]
    public int? EtblPeriodIModifiedAgentId { get; set; }

    [Column("_etblPeriod_iChangeSetID")]
    public int? EtblPeriodIChangeSetId { get; set; }

    [Column("_etblPeriod_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPeriodChecksum { get; set; }

    [Column("iYearID")]
    public int IYearId { get; set; }
}
