using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("SerialMF")]
[Index("SerialMfDModifiedDate", Name = "idxSerialMF_dModifiedDate")]
[Index("SerialMfIBranchId", Name = "idxSerialMF_iBranchID")]
[Index("SerialMfChecksum", Name = "idx_SerialMF_SerialMF_Checksum")]
[Index("SerialMfIChangeSetId", Name = "idx_SerialMF_iChangeSetID")]
public partial class SerialMf
{
    [Key]
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
}
