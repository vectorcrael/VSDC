using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblVDLnAR")]
[Index("EtblVdlnArChecksum", Name = "idx__etblVDLnAR__etblVDLnAR_Checksum")]
[Index("EtblVdlnArIChangeSetId", Name = "idx__etblVDLnAR_iChangeSetID")]
[Index("EtblVdlnArDModifiedDate", Name = "idx_etblVDLnAR_dModifiedDate")]
[Index("EtblVdlnArIBranchId", Name = "idx_etblVDLnAR_iBranchID")]
public partial class EtblVdlnAr
{
    [Key]
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

    [Column("_etblVDLnAR_iBranchID")]
    public int? EtblVdlnArIBranchId { get; set; }

    [Column("_etblVDLnAR_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblVdlnArDCreatedDate { get; set; }

    [Column("_etblVDLnAR_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblVdlnArDModifiedDate { get; set; }

    [Column("_etblVDLnAR_iCreatedBranchID")]
    public int? EtblVdlnArICreatedBranchId { get; set; }

    [Column("_etblVDLnAR_iModifiedBranchID")]
    public int? EtblVdlnArIModifiedBranchId { get; set; }

    [Column("_etblVDLnAR_iCreatedAgentID")]
    public int? EtblVdlnArICreatedAgentId { get; set; }

    [Column("_etblVDLnAR_iModifiedAgentID")]
    public int? EtblVdlnArIModifiedAgentId { get; set; }

    [Column("_etblVDLnAR_iChangeSetID")]
    public int? EtblVdlnArIChangeSetId { get; set; }

    [Column("_etblVDLnAR_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblVdlnArChecksum { get; set; }
}
