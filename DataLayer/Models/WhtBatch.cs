using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("WHT_Batch")]
[Index("WhtBatchChecksum", Name = "idx_WHT_Batch_WHT_Batch_Checksum")]
[Index("WhtBatchDModifiedDate", Name = "idx_WHT_Batch_WHT_Batch_dModifiedDate")]
[Index("WhtBatchIBranchId", Name = "idx_WHT_Batch_WHT_Batch_iBranchID")]
[Index("WhtBatchIChangeSetId", Name = "idx_WHT_Batch_WHT_Batch_iChangeSetID")]
public partial class WhtBatch
{
    [Key]
    [Column("idBatch")]
    public int IdBatch { get; set; }

    [Column("batchNumber")]
    [StringLength(30)]
    public string? BatchNumber { get; set; }

    [Column("batchState")]
    [StringLength(2)]
    public string? BatchState { get; set; }

    [Column("fWHTPercentage")]
    public double? FWhtpercentage { get; set; }

    [Column("fWHTAmount")]
    public double? FWhtamount { get; set; }

    [Column("idInvNum")]
    public long? IdInvNum { get; set; }

    [Column("idInvoiceLines")]
    public long? IdInvoiceLines { get; set; }

    [StringLength(18)]
    public string? InvNumber { get; set; }

    public long? AccountId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? InvDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DeliveryDate { get; set; }

    [StringLength(20)]
    public string? OrderNum { get; set; }

    [Column("cAccountName")]
    [StringLength(50)]
    public string? CAccountName { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    public string? CDescription { get; set; }

    [Column("fQtyProcessed")]
    public double? FQtyProcessed { get; set; }

    [Column("fUnitPriceExcl")]
    public double? FUnitPriceExcl { get; set; }

    [Column("fUnitPriceIncl")]
    public double? FUnitPriceIncl { get; set; }

    [Column("fTaxRate")]
    public double? FTaxRate { get; set; }

    [Column("iTaxTypeId")]
    public long? ITaxTypeId { get; set; }

    [Column("ForeignCurrencyID")]
    public int? ForeignCurrencyId { get; set; }

    [Column("fUnitPriceExclForeign")]
    public double? FUnitPriceExclForeign { get; set; }

    [Column("fUnitPriceInclForeign")]
    public double? FUnitPriceInclForeign { get; set; }

    [Column("WHT_Batch_iBranchID")]
    public int? WhtBatchIBranchId { get; set; }

    [Column("WHT_Batch_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhtBatchDCreatedDate { get; set; }

    [Column("WHT_Batch_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhtBatchDModifiedDate { get; set; }

    [Column("WHT_Batch_iCreatedBranchID")]
    public int? WhtBatchICreatedBranchId { get; set; }

    [Column("WHT_Batch_iModifiedBranchID")]
    public int? WhtBatchIModifiedBranchId { get; set; }

    [Column("WHT_Batch_iCreatedAgentID")]
    public int? WhtBatchICreatedAgentId { get; set; }

    [Column("WHT_Batch_iModifiedAgentID")]
    public int? WhtBatchIModifiedAgentId { get; set; }

    [Column("WHT_Batch_iChangeSetID")]
    public int? WhtBatchIChangeSetId { get; set; }

    [Column("WHT_Batch_Checksum")]
    [MaxLength(20)]
    public byte[]? WhtBatchChecksum { get; set; }
}
