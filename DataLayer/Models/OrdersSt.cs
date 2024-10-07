using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("OrdersSt")]
[Index("OrdersStDModifiedDate", Name = "idxOrdersSt_dModifiedDate")]
[Index("OrdersStIBranchId", Name = "idxOrdersSt_iBranchID")]
[Index("OrdersStChecksum", Name = "idx_OrdersSt_OrdersSt_Checksum")]
[Index("OrdersStIChangeSetId", Name = "idx_OrdersSt_iChangeSetID")]
public partial class OrdersSt
{
    [Key]
    public int StatusCounter { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? StatusDescrip { get; set; }

    [Column("OrdersSt_iBranchID")]
    public int? OrdersStIBranchId { get; set; }

    [Column("OrdersSt_dCreatedDate", TypeName = "datetime")]
    public DateTime? OrdersStDCreatedDate { get; set; }

    [Column("OrdersSt_dModifiedDate", TypeName = "datetime")]
    public DateTime? OrdersStDModifiedDate { get; set; }

    [Column("OrdersSt_iCreatedBranchID")]
    public int? OrdersStICreatedBranchId { get; set; }

    [Column("OrdersSt_iModifiedBranchID")]
    public int? OrdersStIModifiedBranchId { get; set; }

    [Column("OrdersSt_iCreatedAgentID")]
    public int? OrdersStICreatedAgentId { get; set; }

    [Column("OrdersSt_iModifiedAgentID")]
    public int? OrdersStIModifiedAgentId { get; set; }

    [Column("OrdersSt_iChangeSetID")]
    public int? OrdersStIChangeSetId { get; set; }

    [Column("OrdersSt_Checksum")]
    [MaxLength(20)]
    public byte[]? OrdersStChecksum { get; set; }
}
