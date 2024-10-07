using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvTaxGroupTransType
{
    [Column("idTrCodes")]
    public int? IdTrCodes { get; set; }

    [Column("idTaxGroup")]
    public int? IdTaxGroup { get; set; }

    [Column("idTaxGroupTransType")]
    public int IdTaxGroupTransType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("iModule")]
    public int? IModule { get; set; }

    [Column("cModule")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CModule { get; set; }

    [Column("iDtTaxGroupID")]
    public int? IDtTaxGroupId { get; set; }

    [Column("iCtTaxGroupID")]
    public int? ICtTaxGroupId { get; set; }

    [Column("BranchID")]
    public int BranchId { get; set; }
}
