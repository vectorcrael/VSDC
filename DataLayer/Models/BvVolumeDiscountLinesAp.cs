using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvVolumeDiscountLinesAp
{
    [Column("IDVDLn")]
    public int Idvdln { get; set; }

    [Column("iVDID")]
    public int? IVdid { get; set; }

    [Column("iStockID")]
    public int? IStockId { get; set; }

    [Column("iStGroupID")]
    public int? IStGroupId { get; set; }

    [Column("iCurrencyID")]
    public int ICurrencyId { get; set; }

    [Column("dEffDate", TypeName = "smalldatetime")]
    public DateTime? DEffDate { get; set; }

    [Column("dExpDate", TypeName = "smalldatetime")]
    public DateTime? DExpDate { get; set; }

    [Column("bUseStockPrc")]
    public bool BUseStockPrc { get; set; }

    [Column("cEnterInclExcl")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CEnterInclExcl { get; set; }

    [Column("bIncremental")]
    public bool BIncremental { get; set; }

    [Column("bStockAll")]
    public bool? BStockAll { get; set; }

    [Column("_etblVDLnAP_iBranchID")]
    public int? EtblVdlnApIBranchId { get; set; }

    [Column("_etblVDLnAP_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVdlnApDCreatedDate { get; set; }

    [Column("_etblVDLnAP_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVdlnApDModifiedDate { get; set; }

    [Column("_etblVDLnAP_iCreatedBranchID")]
    public int? EtblVdlnApICreatedBranchId { get; set; }

    [Column("_etblVDLnAP_iModifiedBranchID")]
    public int? EtblVdlnApIModifiedBranchId { get; set; }

    [Column("_etblVDLnAP_iCreatedAgentID")]
    public int? EtblVdlnApICreatedAgentId { get; set; }

    [Column("_etblVDLnAP_iModifiedAgentID")]
    public int? EtblVdlnApIModifiedAgentId { get; set; }

    [Column("_etblVDLnAP_iChangeSetID")]
    public int? EtblVdlnApIChangeSetId { get; set; }

    [Column("_etblVDLnAP_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVdlnApChecksum { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? StkCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StkDesc { get; set; }

    [Column("cStockGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CStockGroup { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? StkGroupDesc { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CurrencyDescription { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencySymbol { get; set; }
}
