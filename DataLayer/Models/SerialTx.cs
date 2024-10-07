using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("SerialTX")]
[Index("SerialTxDModifiedDate", Name = "idxSerialTX_dModifiedDate")]
[Index("SerialTxIBranchId", Name = "idxSerialTX_iBranchID")]
[Index("SerialTxChecksum", Name = "idx_SerialTX_SerialTX_Checksum")]
[Index("SerialTxIChangeSetId", Name = "idx_SerialTX_iChangeSetID")]
public partial class SerialTx
{
    [Key]
    [Column("SNTxCounter")]
    public long SntxCounter { get; set; }

    [Column("SNLink")]
    public int? Snlink { get; set; }

    [Column("SNTxDate", TypeName = "smalldatetime")]
    public DateTime? SntxDate { get; set; }

    [Column("SNTxAccLink")]
    public int? SntxAccLink { get; set; }

    [Column("SNTxReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SntxReference { get; set; }

    [Column("SNTrCodeID")]
    public int? SntrCodeId { get; set; }

    [Column("SNAccModule")]
    [StringLength(5)]
    [Unicode(false)]
    public string? SnaccModule { get; set; }

    [Column("SNTransType")]
    public int? SntransType { get; set; }

    [Column("SNProjectLink")]
    public int? SnprojectLink { get; set; }

    [Column("SNWarehouseID")]
    public int? SnwarehouseId { get; set; }

    [Column("SNAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SnauditNumber { get; set; }

    [Column("cSNTXReference2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSntxreference2 { get; set; }

    [Column("SerialTX_iBranchID")]
    public int? SerialTxIBranchId { get; set; }

    [Column("SerialTX_dCreatedDate", TypeName = "datetime")]
    public DateTime? SerialTxDCreatedDate { get; set; }

    [Column("SerialTX_dModifiedDate", TypeName = "datetime")]
    public DateTime? SerialTxDModifiedDate { get; set; }

    [Column("SerialTX_iCreatedBranchID")]
    public int? SerialTxICreatedBranchId { get; set; }

    [Column("SerialTX_iModifiedBranchID")]
    public int? SerialTxIModifiedBranchId { get; set; }

    [Column("SerialTX_iCreatedAgentID")]
    public int? SerialTxICreatedAgentId { get; set; }

    [Column("SerialTX_iModifiedAgentID")]
    public int? SerialTxIModifiedAgentId { get; set; }

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

    [Column("SerialTX_iChangeSetID")]
    public int? SerialTxIChangeSetId { get; set; }

    [Column("SerialTX_Checksum")]
    [MaxLength(20)]
    public byte[]? SerialTxChecksum { get; set; }
}
