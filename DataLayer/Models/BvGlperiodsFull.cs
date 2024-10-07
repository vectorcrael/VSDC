using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvGlperiodsFull
{
    [StringLength(61)]
    public string? PeriodEndDate { get; set; }

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

    [Column("idYear")]
    public int IdYear { get; set; }

    [Column("cYearDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CYearDescription { get; set; } = null!;

    [Column("dYearStartDate", TypeName = "datetime")]
    public DateTime DYearStartDate { get; set; }

    [Column("_etblPeriodYear_iBranchID")]
    public int? EtblPeriodYearIBranchId { get; set; }

    [Column("_etblPeriodYear_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPeriodYearDCreatedDate { get; set; }

    [Column("_etblPeriodYear_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPeriodYearDModifiedDate { get; set; }

    [Column("_etblPeriodYear_iCreatedBranchID")]
    public int? EtblPeriodYearICreatedBranchId { get; set; }

    [Column("_etblPeriodYear_iModifiedBranchID")]
    public int? EtblPeriodYearIModifiedBranchId { get; set; }

    [Column("_etblPeriodYear_iCreatedAgentID")]
    public int? EtblPeriodYearICreatedAgentId { get; set; }

    [Column("_etblPeriodYear_iModifiedAgentID")]
    public int? EtblPeriodYearIModifiedAgentId { get; set; }

    [Column("_etblPeriodYear_iChangeSetID")]
    public int? EtblPeriodYearIChangeSetId { get; set; }

    [Column("_etblPeriodYear_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPeriodYearChecksum { get; set; }

    [Column("bArchived")]
    public bool BArchived { get; set; }

    [Column("bPurged")]
    public bool BPurged { get; set; }
}
