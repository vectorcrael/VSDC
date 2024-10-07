using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retCashPickup")]
[Index("RetCashPickupChecksum", Name = "idx__retCashPickup__retCashPickup_Checksum")]
[Index("RetCashPickupDModifiedDate", Name = "idx__retCashPickup__retCashPickup_dModifiedDate")]
[Index("RetCashPickupIBranchId", Name = "idx__retCashPickup__retCashPickup_iBranchID")]
[Index("RetCashPickupIChangeSetId", Name = "idx__retCashPickup__retCashPickup_iChangeSetID")]
[Index("IAgentSessionId", Name = "idx__retCashPickup_iAgentSessionID")]
public partial class RetCashPickup
{
    [Key]
    [Column("idCashPickup")]
    public int IdCashPickup { get; set; }

    [Column("iAgentSessionID")]
    public int? IAgentSessionId { get; set; }

    [Column("iTillID")]
    public int? ITillId { get; set; }

    [Column("dPickupDate", TypeName = "datetime")]
    public DateTime? DPickupDate { get; set; }

    [Column("cCashPickupReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CCashPickupReference { get; set; }

    [Column("fPickupAmount")]
    public double? FPickupAmount { get; set; }

    [Column("_retCashPickup_iBranchID")]
    public int? RetCashPickupIBranchId { get; set; }

    [Column("_retCashPickup_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetCashPickupDCreatedDate { get; set; }

    [Column("_retCashPickup_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetCashPickupDModifiedDate { get; set; }

    [Column("_retCashPickup_iCreatedBranchID")]
    public int? RetCashPickupICreatedBranchId { get; set; }

    [Column("_retCashPickup_iModifiedBranchID")]
    public int? RetCashPickupIModifiedBranchId { get; set; }

    [Column("_retCashPickup_iCreatedAgentID")]
    public int? RetCashPickupICreatedAgentId { get; set; }

    [Column("_retCashPickup_iModifiedAgentID")]
    public int? RetCashPickupIModifiedAgentId { get; set; }

    [Column("_retCashPickup_iChangeSetID")]
    public int? RetCashPickupIChangeSetId { get; set; }

    [Column("_retCashPickup_Checksum")]
    [MaxLength(20)]
    public byte[]? RetCashPickupChecksum { get; set; }
}
