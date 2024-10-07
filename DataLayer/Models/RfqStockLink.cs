using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_StockLinks")]
public partial class RfqStockLink
{
    [Key]
    [Column("idStockLinks")]
    public int IdStockLinks { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iDCLink")]
    public int IDclink { get; set; }

    [Column("bItemActive")]
    public bool BItemActive { get; set; }

    [Column("dCreatedDate", TypeName = "datetime")]
    public DateTime? DCreatedDate { get; set; }

    [Column("dModifiedDate", TypeName = "datetime")]
    public DateTime? DModifiedDate { get; set; }

    [Column("cProductReference")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CProductReference { get; set; }

    [Column("cModule")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CModule { get; set; }

    [Column("cSupInvCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSupInvCode { get; set; }

    [Column("iWhseID")]
    public int? IWhseId { get; set; }

    [Column("bDefaultSupplier")]
    public bool BDefaultSupplier { get; set; }

    [Column("bDCOnHold")]
    public bool BDconHold { get; set; }

    [Column("fLastGRVCost")]
    public double? FLastGrvcost { get; set; }

    [Column("fManualCost")]
    public double FManualCost { get; set; }

    [Column("fminOrderQuantity")]
    public double? FminOrderQuantity { get; set; }

    [Column("iBranchID")]
    public int? IBranchId { get; set; }

    [Column("fLeadDays")]
    public double? FLeadDays { get; set; }

    [Column("dLastGRVCostDate", TypeName = "datetime")]
    public DateTime? DLastGrvcostDate { get; set; }
}
