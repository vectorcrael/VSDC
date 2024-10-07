using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblWorkers")]
[Index("EtblWorkersChecksum", Name = "idx__etblWorkers__etblWorkers_Checksum")]
[Index("EtblWorkersIChangeSetId", Name = "idx__etblWorkers_iChangeSetID")]
[Index("EtblWorkersDModifiedDate", Name = "idx_etblWorkers_dModifiedDate")]
[Index("EtblWorkersIBranchId", Name = "idx_etblWorkers_iBranchID")]
public partial class EtblWorker
{
    [Key]
    [Column("idWorkers")]
    public int IdWorkers { get; set; }

    [Column("cWorkerCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string CWorkerCode { get; set; } = null!;

    [Column("cWorkerName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CWorkerName { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("fWorkerCost")]
    public double? FWorkerCost { get; set; }

    [Column("fBillableRate")]
    public double? FBillableRate { get; set; }

    [Column("_etblWorkers_iBranchID")]
    public int? EtblWorkersIBranchId { get; set; }

    [Column("_etblWorkers_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWorkersDCreatedDate { get; set; }

    [Column("_etblWorkers_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWorkersDModifiedDate { get; set; }

    [Column("_etblWorkers_iCreatedBranchID")]
    public int? EtblWorkersICreatedBranchId { get; set; }

    [Column("_etblWorkers_iModifiedBranchID")]
    public int? EtblWorkersIModifiedBranchId { get; set; }

    [Column("_etblWorkers_iCreatedAgentID")]
    public int? EtblWorkersICreatedAgentId { get; set; }

    [Column("_etblWorkers_iModifiedAgentID")]
    public int? EtblWorkersIModifiedAgentId { get; set; }

    [Column("_etblWorkers_iChangeSetID")]
    public int? EtblWorkersIChangeSetId { get; set; }

    [Column("_etblWorkers_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWorkersChecksum { get; set; }
}
