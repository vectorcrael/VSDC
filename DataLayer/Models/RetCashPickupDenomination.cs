using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retCashPickupDenomination")]
[Index("RetCashPickupDenominationChecksum", Name = "idx__retCashPickupDenomination__retCashPickupDenomination_Checksum")]
[Index("RetCashPickupDenominationDModifiedDate", Name = "idx__retCashPickupDenomination__retCashPickupDenomination_dModifiedDate")]
[Index("RetCashPickupDenominationIBranchId", Name = "idx__retCashPickupDenomination__retCashPickupDenomination_iBranchID")]
[Index("RetCashPickupDenominationIChangeSetId", Name = "idx__retCashPickupDenomination__retCashPickupDenomination_iChangeSetID")]
[Index("ICashPickupId", Name = "idx__retCashPickupDenomination_iCashPickupID")]
public partial class RetCashPickupDenomination
{
    [Key]
    [Column("idCashPickupDenomination")]
    public int IdCashPickupDenomination { get; set; }

    [Column("iCashPickupID")]
    public int? ICashPickupId { get; set; }

    [Column("iDenominationID")]
    public int? IDenominationId { get; set; }

    [Column("iCashCount")]
    public int? ICashCount { get; set; }

    [Column("_retCashPickupDenomination_iBranchID")]
    public int? RetCashPickupDenominationIBranchId { get; set; }

    [Column("_retCashPickupDenomination_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetCashPickupDenominationDCreatedDate { get; set; }

    [Column("_retCashPickupDenomination_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetCashPickupDenominationDModifiedDate { get; set; }

    [Column("_retCashPickupDenomination_iCreatedBranchID")]
    public int? RetCashPickupDenominationICreatedBranchId { get; set; }

    [Column("_retCashPickupDenomination_iModifiedBranchID")]
    public int? RetCashPickupDenominationIModifiedBranchId { get; set; }

    [Column("_retCashPickupDenomination_iCreatedAgentID")]
    public int? RetCashPickupDenominationICreatedAgentId { get; set; }

    [Column("_retCashPickupDenomination_iModifiedAgentID")]
    public int? RetCashPickupDenominationIModifiedAgentId { get; set; }

    [Column("_retCashPickupDenomination_iChangeSetID")]
    public int? RetCashPickupDenominationIChangeSetId { get; set; }

    [Column("_retCashPickupDenomination_Checksum")]
    [MaxLength(20)]
    public byte[]? RetCashPickupDenominationChecksum { get; set; }
}
