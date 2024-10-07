using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblCbBatchDefs")]
[Index("BtblCbBatchDefsChecksum", Name = "idx__btblCbBatchDefs__btblCbBatchDefs_Checksum")]
[Index("BtblCbBatchDefsIChangeSetId", Name = "idx__btblCbBatchDefs_iChangeSetID")]
[Index("BtblCbBatchDefsDModifiedDate", Name = "idx_btblCbBatchDefs_dModifiedDate")]
[Index("BtblCbBatchDefsIBranchId", Name = "idx_btblCbBatchDefs_iBranchID")]
public partial class BtblCbBatchDef
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

    [Column("iGLBankAccID")]
    public int? IGlbankAccId { get; set; }

    [Column("iGLARAccID")]
    public int? IGlaraccId { get; set; }

    [Column("iGLAPAccID")]
    public int? IGlapaccId { get; set; }

    [Column("iARDiscTrCodeID")]
    public int? IArdiscTrCodeId { get; set; }

    [Column("iAPDiscTrCodeID")]
    public int? IApdiscTrCodeId { get; set; }

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

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("bForceProject")]
    public bool BForceProject { get; set; }

    [Column("bForceRep")]
    public bool BForceRep { get; set; }

    [Column("_btblCbBatchDefs_iBranchID")]
    public int? BtblCbBatchDefsIBranchId { get; set; }

    [Column("_btblCbBatchDefs_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblCbBatchDefsDCreatedDate { get; set; }

    [Column("_btblCbBatchDefs_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblCbBatchDefsDModifiedDate { get; set; }

    [Column("_btblCbBatchDefs_iCreatedBranchID")]
    public int? BtblCbBatchDefsICreatedBranchId { get; set; }

    [Column("_btblCbBatchDefs_iModifiedBranchID")]
    public int? BtblCbBatchDefsIModifiedBranchId { get; set; }

    [Column("_btblCbBatchDefs_iCreatedAgentID")]
    public int? BtblCbBatchDefsICreatedAgentId { get; set; }

    [Column("_btblCbBatchDefs_iModifiedAgentID")]
    public int? BtblCbBatchDefsIModifiedAgentId { get; set; }

    [Column("_btblCbBatchDefs_iChangeSetID")]
    public int? BtblCbBatchDefsIChangeSetId { get; set; }

    [Column("iEFTSLayoutID")]
    public int? IEftslayoutId { get; set; }

    [Column("cEFTSPathOutFile")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CEftspathOutFile { get; set; }

    [Column("_btblCbBatchDefs_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblCbBatchDefsChecksum { get; set; }
}
