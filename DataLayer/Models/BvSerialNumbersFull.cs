﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvSerialNumbersFull
{
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

    [StringLength(400)]
    [Unicode(false)]
    public string? TransAccount { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string TransTypeDesc { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Movement { get; set; } = null!;

    [StringLength(21)]
    [Unicode(false)]
    public string? Project { get; set; }

    public int? SerialCounter { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SerialNumber { get; set; }

    [Column("SNStockLink")]
    public int? SnstockLink { get; set; }

    [Column("SNDateLMove", TypeName = "smalldatetime")]
    public DateTime? SndateLmove { get; set; }

    public int? CurrentLoc { get; set; }

    public int? CurrentAccLink { get; set; }

    [Column("iSNLotID")]
    public int? ISnlotId { get; set; }

    [Column("iSNMFPID")]
    public int? ISnmfpid { get; set; }

    [Column("iSNMFPLineID")]
    public long? ISnmfplineId { get; set; }

    [Column("SerialMF_iBranchID")]
    public int? SerialMfIBranchId { get; set; }

    [Column("SerialMF_dCreatedDate", TypeName = "datetime")]
    public DateTime? SerialMfDCreatedDate { get; set; }

    [Column("SerialMF_dModifiedDate", TypeName = "datetime")]
    public DateTime? SerialMfDModifiedDate { get; set; }

    [Column("SerialMF_iCreatedBranchID")]
    public int? SerialMfICreatedBranchId { get; set; }

    [Column("SerialMF_iModifiedBranchID")]
    public int? SerialMfIModifiedBranchId { get; set; }

    [Column("SerialMF_iCreatedAgentID")]
    public int? SerialMfICreatedAgentId { get; set; }

    [Column("SerialMF_iModifiedAgentID")]
    public int? SerialMfIModifiedAgentId { get; set; }

    [Column("SerialMF_iChangeSetID")]
    public int? SerialMfIChangeSetId { get; set; }

    [Column("SerialMF_Checksum")]
    [MaxLength(20)]
    public byte[]? SerialMfChecksum { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? StockCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LotNumber { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? CurrentAccount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CurrentAccountDesc { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string? CurrentLocationDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WarehouseCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TrCode { get; set; }
}
