using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvFaglbatch
{
    [Column("idBatch")]
    public int IdBatch { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("dDateRun", TypeName = "datetime")]
    public DateTime DDateRun { get; set; }

    [Column("bPosted")]
    public bool BPosted { get; set; }

    [Column("dBatchDate", TypeName = "smalldatetime")]
    public DateTime? DBatchDate { get; set; }

    [Column("dDate", TypeName = "datetime")]
    public DateTime? DDate { get; set; }

    [Column("fDrAmount")]
    public double? FDrAmount { get; set; }

    [Column("fCrAmount")]
    public double? FCrAmount { get; set; }

    [Column("iGLAccountID")]
    public int? IGlaccountId { get; set; }

    [Column("iAssetTypeID")]
    public int? IAssetTypeId { get; set; }

    [Column("iCostCentreID")]
    public int? ICostCentreId { get; set; }

    [Column("iAssetCount")]
    public int? IAssetCount { get; set; }

    [Column("idBatchGLEntries")]
    public int IdBatchGlentries { get; set; }

    [Column("cGLDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CGldescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CostCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? CostName { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(91)]
    [Unicode(false)]
    public string? Account { get; set; }

    public bool? ActiveAccount { get; set; }

    [Column("cAssetTypeCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetTypeCode { get; set; }

    [Column("cAssetTypeDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CAssetTypeDesc { get; set; }
}
