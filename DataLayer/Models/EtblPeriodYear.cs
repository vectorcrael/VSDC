using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPeriodYear")]
[Index("EtblPeriodYearChecksum", Name = "idx__etblPeriodYear__etblPeriodYear_Checksum")]
[Index("EtblPeriodYearDModifiedDate", Name = "idx__etblPeriodYear__etblPeriodYear_dModifiedDate")]
[Index("EtblPeriodYearIBranchId", Name = "idx__etblPeriodYear__etblPeriodYear_iBranchID")]
[Index("EtblPeriodYearIChangeSetId", Name = "idx__etblPeriodYear__etblPeriodYear_iChangeSetID")]
public partial class EtblPeriodYear
{
    [Key]
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
