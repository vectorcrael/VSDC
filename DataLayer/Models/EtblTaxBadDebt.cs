using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblTaxBadDebt")]
public partial class EtblTaxBadDebt
{
    [Key]
    [Column("iTaxBadDebtID")]
    public int ITaxBadDebtId { get; set; }

    [Column("iPeriodID")]
    public int? IPeriodId { get; set; }

    [Column("iPostAR")]
    public int IPostAr { get; set; }

    [Column("iPostAP")]
    public int IPostAp { get; set; }

    [Column("iPostGL")]
    public int IPostGl { get; set; }

    public double ReliefAmt { get; set; }

    public double ReliefTaxAmt { get; set; }

    public double RecoveredAmt { get; set; }

    public double RecoveredTaxAmt { get; set; }

    public double RefundAmt { get; set; }

    public double RefundTaxAmt { get; set; }

    public double ReclaimAmt { get; set; }

    public double ReclaimTaxAmt { get; set; }

    [Column("iProcessedTaxPeriodID")]
    public int IProcessedTaxPeriodId { get; set; }

    public double ReliefAmtForeign { get; set; }

    public double ReliefTaxAmtForeign { get; set; }

    public double RecoveredAmtForeign { get; set; }

    public double RecoveredTaxAmtForeign { get; set; }

    public double RefundAmtForeign { get; set; }

    public double RefundTaxAmtForeign { get; set; }

    public double ReclaimAmtForeign { get; set; }

    public double ReclaimTaxAmtForeign { get; set; }

    [Column("iTaxTypeID")]
    public int ITaxTypeId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime TxDate { get; set; }
}
