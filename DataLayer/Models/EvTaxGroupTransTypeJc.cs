using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvTaxGroupTransTypeJc
{
    [Column("idJobTxTp")]
    public int? IdJobTxTp { get; set; }

    [Column("idTaxGroup")]
    public int? IdTaxGroup { get; set; }

    [Column("idTaxGroupTransType")]
    public int IdTaxGroupTransType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TxType { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("cModule")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CModule { get; set; }

    [Column("iSellingTaxGroupID")]
    public int? ISellingTaxGroupId { get; set; }

    [Column("iCostTaxGroupID")]
    public int? ICostTaxGroupId { get; set; }

    [Column("BranchID")]
    public int BranchId { get; set; }
}
