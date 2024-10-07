using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("_etblAllocTemp")]
[Index("TmpAprbatchId", Name = "idx__etblAllocTemp_TmpAPRBatchID")]
[Index("TmpAutoIdx", Name = "idx__etblAllocTemp_TmpAutoIdx")]
[Index("TmpDclink", Name = "idx__etblAllocTemp_TmpDCLink")]
[Index("TmpLineId", Name = "idx__etblAllocTemp_TmpLineID")]
public partial class EtblAllocTemp
{
    public long? TmpAutoIdx { get; set; }

    public int? TmpTxTerm { get; set; }

    [Column("TmpAllocID")]
    public long? TmpAllocId { get; set; }

    public double? TmpAllocAmt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TmpAllocDate { get; set; }

    public double? TmpTotCredits { get; set; }

    public double? TmpTotDebits { get; set; }

    [Column("TmpAllUACredits")]
    public double? TmpAllUacredits { get; set; }

    [Column("TmpAllUADebits")]
    public double? TmpAllUadebits { get; set; }

    [Column("TmpDCLink")]
    public int? TmpDclink { get; set; }

    [Column("TmpPas_Cursor")]
    public int? TmpPasCursor { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? TmpTranModule { get; set; }

    [Column("TmpLinkedID")]
    public long? TmpLinkedId { get; set; }

    [Column("TmpLineID")]
    public int TmpLineId { get; set; }

    [Column("TmpRepID")]
    public int? TmpRepId { get; set; }

    public double? TmpStockAllocAmtExc { get; set; }

    public double? TmpStockCost { get; set; }

    [Column("iTxBranchID")]
    public int? ITxBranchId { get; set; }

    [Column("TmpAPRBatchID")]
    public int TmpAprbatchId { get; set; }
}
