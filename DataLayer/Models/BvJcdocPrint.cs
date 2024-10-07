using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvJcdocPrint
{
    [Column("iLineID")]
    public int? ILineId { get; set; }

    [Column("idJCInvoiceLines")]
    public long IdJcinvoiceLines { get; set; }

    [Column("iJCTxLinesID")]
    public long? IJctxLinesId { get; set; }

    [Column("IdJCMaster")]
    public int IdJcmaster { get; set; }

    [Column("JobNumID")]
    public int? JobNumId { get; set; }

    [Column("CustomerID")]
    public int? CustomerId { get; set; }

    [Column("InventoryItemsID")]
    public int? InventoryItemsId { get; set; }
}
