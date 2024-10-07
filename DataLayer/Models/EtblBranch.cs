using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblBranch")]
[Index("EtblBranchChecksum", Name = "idx__etblBranch__etblBranch_Checksum")]
[Index("EtblBranchIChangeSetId", Name = "idx__etblBranch_iChangeSetID")]
[Index("EtblBranchDModifiedDate", Name = "idx_etblBranch_dModifiedDate")]
[Index("EtblBranchIBranchId", Name = "idx_etblBranch_iBranchID")]
public partial class EtblBranch
{
    [Key]
    [Column("idBranch")]
    public int IdBranch { get; set; }

    [Column("cBranchCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CBranchCode { get; set; }

    [Column("cBranchDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBranchDescription { get; set; }

    [Column("bBranchActive")]
    public bool BBranchActive { get; set; }

    [Column("_etblBranch_iBranchID")]
    public int? EtblBranchIBranchId { get; set; }

    [Column("_etblBranch_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblBranchDCreatedDate { get; set; }

    [Column("_etblBranch_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblBranchDModifiedDate { get; set; }

    [Column("_etblBranch_iCreatedBranchID")]
    public int? EtblBranchICreatedBranchId { get; set; }

    [Column("_etblBranch_iModifiedBranchID")]
    public int? EtblBranchIModifiedBranchId { get; set; }

    [Column("_etblBranch_iCreatedAgentID")]
    public int? EtblBranchICreatedAgentId { get; set; }

    [Column("_etblBranch_iModifiedAgentID")]
    public int? EtblBranchIModifiedAgentId { get; set; }

    [Column("bSyncEnabled")]
    public bool BSyncEnabled { get; set; }

    [Column("dLastExport", TypeName = "datetime")]
    public DateTime? DLastExport { get; set; }

    [Column("dLastImport", TypeName = "datetime")]
    public DateTime? DLastImport { get; set; }

    [Column("iLastImportSeq")]
    public int? ILastImportSeq { get; set; }

    [Column("iLastExportSeq")]
    public int? ILastExportSeq { get; set; }

    [Column("iLastExportChangeSetID")]
    public int? ILastExportChangeSetId { get; set; }

    [Column("_etblBranch_iChangeSetID")]
    public int? EtblBranchIChangeSetId { get; set; }

    [Column("bIsDCBranch")]
    public bool BIsDcbranch { get; set; }

    [Column("iDCWarehouseID")]
    public int IDcwarehouseId { get; set; }

    [Column("_etblBranch_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblBranchChecksum { get; set; }
}
