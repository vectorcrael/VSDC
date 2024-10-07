using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblLotStatus")]
[Index("EtblLotStatusChecksum", Name = "idx__etblLotStatus__etblLotStatus_Checksum")]
[Index("EtblLotStatusIChangeSetId", Name = "idx__etblLotStatus_iChangeSetID")]
[Index("EtblLotStatusDModifiedDate", Name = "idx_etblLotStatus_dModifiedDate")]
[Index("EtblLotStatusIBranchId", Name = "idx_etblLotStatus_iBranchID")]
public partial class EtblLotStatus
{
    [Key]
    [Column("idLotStatus")]
    public int IdLotStatus { get; set; }

    [Column("cLotStatusDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CLotStatusDescription { get; set; }

    [Column("bAllowPurchases")]
    public bool BAllowPurchases { get; set; }

    [Column("bAllowSales")]
    public bool BAllowSales { get; set; }

    [Column("_etblLotStatus_iBranchID")]
    public int? EtblLotStatusIBranchId { get; set; }

    [Column("_etblLotStatus_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblLotStatusDCreatedDate { get; set; }

    [Column("_etblLotStatus_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblLotStatusDModifiedDate { get; set; }

    [Column("_etblLotStatus_iCreatedBranchID")]
    public int? EtblLotStatusICreatedBranchId { get; set; }

    [Column("_etblLotStatus_iModifiedBranchID")]
    public int? EtblLotStatusIModifiedBranchId { get; set; }

    [Column("_etblLotStatus_iCreatedAgentID")]
    public int? EtblLotStatusICreatedAgentId { get; set; }

    [Column("_etblLotStatus_iModifiedAgentID")]
    public int? EtblLotStatusIModifiedAgentId { get; set; }

    [Column("_etblLotStatus_iChangeSetID")]
    public int? EtblLotStatusIChangeSetId { get; set; }

    [Column("_etblLotStatus_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblLotStatusChecksum { get; set; }
}
