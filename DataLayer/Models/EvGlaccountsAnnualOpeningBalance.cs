using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvGlaccountsAnnualOpeningBalance
{
    public int AccountLink { get; set; }

    [Column("Master_Sub_Account")]
    [StringLength(91)]
    [Unicode(false)]
    public string? MasterSubAccount { get; set; }

    [Column("iAccountType")]
    public int IAccountType { get; set; }

    [Column("cAccountTypeDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAccountTypeDescription { get; set; }

    [Column("idYear")]
    public int IdYear { get; set; }

    [Column("cYearDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CYearDescription { get; set; } = null!;

    [Column("ActualTxBranchID")]
    public int ActualTxBranchId { get; set; }

    public double AccumActual { get; set; }
}
