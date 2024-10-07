using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblEFTSFileLayout")]
[Index("EtblEftsfileLayoutChecksum", Name = "idx__etblEFTSFileLayout__etblEFTSFileLayout_Checksum")]
[Index("EtblEftsfileLayoutIChangeSetId", Name = "idx__etblEFTSFileLayout_iChangeSetID")]
[Index("EtblEftsfileLayoutDModifiedDate", Name = "idx_etblEFTSFileLayout_dModifiedDate")]
[Index("EtblEftsfileLayoutIBranchId", Name = "idx_etblEFTSFileLayout_iBranchID")]
public partial class EtblEftsfileLayout
{
    [Key]
    [Column("idEFTSLayout")]
    public int IdEftslayout { get; set; }

    [Column("cDescription")]
    [StringLength(200)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("bSystemLayout")]
    public bool BSystemLayout { get; set; }

    [Column("cNameOutFile")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CNameOutFile { get; set; }

    [Column("cTypeOutFile")]
    [StringLength(3)]
    [Unicode(false)]
    public string? CTypeOutFile { get; set; }

    [Column("iDelimiterOutFile")]
    public int? IDelimiterOutFile { get; set; }

    [Column("iEOLCharOutFile")]
    public int? IEolcharOutFile { get; set; }

    [Column("iCountryCode")]
    public int ICountryCode { get; set; }

    [Column("iNoOfHeaders")]
    public int? INoOfHeaders { get; set; }

    [Column("iNoOFTransactions")]
    public int? INoOftransactions { get; set; }

    [Column("iNoOfFooters")]
    public int? INoOfFooters { get; set; }

    [Column("iMaxNoOfRecords")]
    public int? IMaxNoOfRecords { get; set; }

    [Column("iHashTotalCalc")]
    public int IHashTotalCalc { get; set; }

    [Column("cSeedNumber")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CSeedNumber { get; set; }

    [Column("bAllowTestRun")]
    public bool BAllowTestRun { get; set; }

    [Column("bAskBatchNo")]
    public bool BAskBatchNo { get; set; }

    [Column("iDayDifference")]
    public int IDayDifference { get; set; }

    [Column("iACBServiceType")]
    public int IAcbserviceType { get; set; }

    [Column("bIncrementFileName")]
    public bool BIncrementFileName { get; set; }

    [Column("cUserName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CUserName { get; set; }

    [Column("cPassword")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CPassword { get; set; }

    [Column("cPin")]
    [StringLength(160)]
    [Unicode(false)]
    public string? CPin { get; set; }

    [Column("iEFTSOrderLetterID")]
    public int IEftsorderLetterId { get; set; }

    [Column("_etblEFTSFileLayout_iBranchID")]
    public int? EtblEftsfileLayoutIBranchId { get; set; }

    [Column("_etblEFTSFileLayout_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblEftsfileLayoutDCreatedDate { get; set; }

    [Column("_etblEFTSFileLayout_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblEftsfileLayoutDModifiedDate { get; set; }

    [Column("_etblEFTSFileLayout_iCreatedBranchID")]
    public int? EtblEftsfileLayoutICreatedBranchId { get; set; }

    [Column("_etblEFTSFileLayout_iModifiedBranchID")]
    public int? EtblEftsfileLayoutIModifiedBranchId { get; set; }

    [Column("_etblEFTSFileLayout_iCreatedAgentID")]
    public int? EtblEftsfileLayoutICreatedAgentId { get; set; }

    [Column("_etblEFTSFileLayout_iModifiedAgentID")]
    public int? EtblEftsfileLayoutIModifiedAgentId { get; set; }

    [Column("_etblEFTSFileLayout_iChangeSetID")]
    public int? EtblEftsfileLayoutIChangeSetId { get; set; }

    [Column("iSourceLayoutID")]
    public int? ISourceLayoutId { get; set; }

    [Column("cXSLT")]
    [Unicode(false)]
    public string? CXslt { get; set; }

    [Column("_etblEFTSFileLayout_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblEftsfileLayoutChecksum { get; set; }
}
