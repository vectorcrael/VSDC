using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvSerialMasterFull
{
    public int SerialCounter { get; set; }

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
    public long ISnmfplineId { get; set; }

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
    public string CurrentLocationDesc { get; set; } = null!;
}
