using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblJrBatchDefs")]
[Index("BtblJrBatchDefsChecksum", Name = "idx__btblJrBatchDefs__btblJrBatchDefs_Checksum")]
[Index("BtblJrBatchDefsIChangeSetId", Name = "idx__btblJrBatchDefs_iChangeSetID")]
[Index("BtblJrBatchDefsDModifiedDate", Name = "idx_btblJrBatchDefs_dModifiedDate")]
[Index("BtblJrBatchDefsIBranchId", Name = "idx_btblJrBatchDefs_iBranchID")]
public partial class BtblJrBatchDef
{
    [Key]
    [Column("idBatchDefs")]
    public int IdBatchDefs { get; set; }

    [Column("bAutoNumbers")]
    public bool BAutoNumbers { get; set; }

    [Column("iPadLength")]
    public int? IPadLength { get; set; }

    [Column("cPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CPrefix { get; set; }

    [Column("iInputTaxID")]
    public int? IInputTaxId { get; set; }

    [Column("iInputTaxAccID")]
    public int? IInputTaxAccId { get; set; }

    [Column("iOutputTaxID")]
    public int? IOutputTaxId { get; set; }

    [Column("iOutputTaxAccID")]
    public int? IOutputTaxAccId { get; set; }

    [Column("iTrCodeID")]
    public int? ITrCodeId { get; set; }

    [Column("bBatchRefAutoNumbers")]
    public bool BBatchRefAutoNumbers { get; set; }

    [Column("iBatchRefPadLength")]
    public int? IBatchRefPadLength { get; set; }

    [Column("cBatchRefPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CBatchRefPrefix { get; set; }

    [Column("iNextBatchRefNo")]
    public int? INextBatchRefNo { get; set; }

    [Column("bForceBatchRefNo")]
    public bool BForceBatchRefNo { get; set; }

    [Column("bForceProject")]
    public bool BForceProject { get; set; }

    [Column("iRevBatchID")]
    public int? IRevBatchId { get; set; }

    [Column("_btblJrBatchDefs_iBranchID")]
    public int? BtblJrBatchDefsIBranchId { get; set; }

    [Column("_btblJrBatchDefs_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblJrBatchDefsDCreatedDate { get; set; }

    [Column("_btblJrBatchDefs_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblJrBatchDefsDModifiedDate { get; set; }

    [Column("_btblJrBatchDefs_iCreatedBranchID")]
    public int? BtblJrBatchDefsICreatedBranchId { get; set; }

    [Column("_btblJrBatchDefs_iModifiedBranchID")]
    public int? BtblJrBatchDefsIModifiedBranchId { get; set; }

    [Column("_btblJrBatchDefs_iCreatedAgentID")]
    public int? BtblJrBatchDefsICreatedAgentId { get; set; }

    [Column("_btblJrBatchDefs_iModifiedAgentID")]
    public int? BtblJrBatchDefsIModifiedAgentId { get; set; }

    [Column("_btblJrBatchDefs_iChangeSetID")]
    public int? BtblJrBatchDefsIChangeSetId { get; set; }

    [Column("_btblJrBatchDefs_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblJrBatchDefsChecksum { get; set; }
}
