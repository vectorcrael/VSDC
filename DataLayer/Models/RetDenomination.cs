using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retDenomination")]
[Index("RetDenominationChecksum", Name = "idx__retDenomination__retDenomination_Checksum")]
[Index("RetDenominationIChangeSetId", Name = "idx__retDenomination_iChangeSetID")]
[Index("RetDenominationDModifiedDate", Name = "idx_retDenomination_dModifiedDate")]
[Index("RetDenominationIBranchId", Name = "idx_retDenomination_iBranchID")]
public partial class RetDenomination
{
    [Key]
    [Column("idDenomination")]
    public int IdDenomination { get; set; }

    [Column("cDenominationCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CDenominationCode { get; set; }

    [Column("mMultiple", TypeName = "money")]
    public decimal? MMultiple { get; set; }

    [Column("bIsCoin")]
    public bool? BIsCoin { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_retDenomination_iBranchID")]
    public int? RetDenominationIBranchId { get; set; }

    [Column("_retDenomination_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetDenominationDCreatedDate { get; set; }

    [Column("_retDenomination_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetDenominationDModifiedDate { get; set; }

    [Column("_retDenomination_iCreatedBranchID")]
    public int? RetDenominationICreatedBranchId { get; set; }

    [Column("_retDenomination_iModifiedBranchID")]
    public int? RetDenominationIModifiedBranchId { get; set; }

    [Column("_retDenomination_iCreatedAgentID")]
    public int? RetDenominationICreatedAgentId { get; set; }

    [Column("_retDenomination_iModifiedAgentID")]
    public int? RetDenominationIModifiedAgentId { get; set; }

    [Column("_retDenomination_iChangeSetID")]
    public int? RetDenominationIChangeSetId { get; set; }

    [Column("_retDenomination_Checksum")]
    [MaxLength(20)]
    public byte[]? RetDenominationChecksum { get; set; }
}
