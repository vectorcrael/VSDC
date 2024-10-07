using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAMovementTransaction")]
[Index("BtblFamovementTransactionChecksum", Name = "idx__btblFAMovementTransaction__btblFAMovementTransaction_Checksum")]
[Index("BtblFamovementTransactionIChangeSetId", Name = "idx__btblFAMovementTransaction_iChangeSetID")]
[Index("BtblFamovementTransactionDModifiedDate", Name = "idx_btblFAMovementTransaction_dModifiedDate")]
[Index("BtblFamovementTransactionIBranchId", Name = "idx_btblFAMovementTransaction_iBranchID")]
public partial class BtblFamovementTransaction
{
    [Key]
    [Column("idMovementTransactionNo")]
    public int IdMovementTransactionNo { get; set; }

    [Column("iAssetID")]
    public int IAssetId { get; set; }

    [Column("iTransactionTypeID")]
    public int ITransactionTypeId { get; set; }

    [Column("fNoOfUnits")]
    public double FNoOfUnits { get; set; }

    [Column("fAmount")]
    public double FAmount { get; set; }

    [Column("dMovementDate", TypeName = "smalldatetime")]
    public DateTime DMovementDate { get; set; }

    [Column("cReference")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("iPeopleID")]
    public int? IPeopleId { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

    [Column("iAssetTypeID")]
    public int? IAssetTypeId { get; set; }

    [Column("iCostCentreID")]
    public int? ICostCentreId { get; set; }

    [Column("iLocationID")]
    public int? ILocationId { get; set; }

    [Column("DTStamp", TypeName = "datetime")]
    public DateTime? Dtstamp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column("cDeprTypeInd")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CDeprTypeInd { get; set; }

    [Column("_btblFAMovementTransaction_iBranchID")]
    public int? BtblFamovementTransactionIBranchId { get; set; }

    [Column("_btblFAMovementTransaction_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFamovementTransactionDCreatedDate { get; set; }

    [Column("_btblFAMovementTransaction_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFamovementTransactionDModifiedDate { get; set; }

    [Column("_btblFAMovementTransaction_iCreatedBranchID")]
    public int? BtblFamovementTransactionICreatedBranchId { get; set; }

    [Column("_btblFAMovementTransaction_iModifiedBranchID")]
    public int? BtblFamovementTransactionIModifiedBranchId { get; set; }

    [Column("_btblFAMovementTransaction_iCreatedAgentID")]
    public int? BtblFamovementTransactionICreatedAgentId { get; set; }

    [Column("_btblFAMovementTransaction_iModifiedAgentID")]
    public int? BtblFamovementTransactionIModifiedAgentId { get; set; }

    [Column("_btblFAMovementTransaction_iChangeSetID")]
    public int? BtblFamovementTransactionIChangeSetId { get; set; }

    [Column("_btblFAMovementTransaction_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFamovementTransactionChecksum { get; set; }
}
