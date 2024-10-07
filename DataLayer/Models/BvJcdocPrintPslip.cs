using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvJcdocPrintPslip
{
    [Column("idJCTxLines")]
    public long IdJctxLines { get; set; }

    [Column("IdJCMaster")]
    public int? IdJcmaster { get; set; }

    [Column("InventoryItemsID")]
    public int? InventoryItemsId { get; set; }
}
