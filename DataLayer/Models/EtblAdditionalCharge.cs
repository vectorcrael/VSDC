using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAdditionalCharges")]
[Index("EtblAdditionalChargesChecksum", Name = "idx__etblAdditionalCharges__etblAdditionalCharges_Checksum")]
[Index("EtblAdditionalChargesDModifiedDate", Name = "idx__etblAdditionalCharges__etblAdditionalCharges_dModifiedDate")]
[Index("EtblAdditionalChargesIBranchId", Name = "idx__etblAdditionalCharges__etblAdditionalCharges_iBranchID")]
[Index("EtblAdditionalChargesIChangeSetId", Name = "idx__etblAdditionalCharges__etblAdditionalCharges_iChangeSetID")]
public partial class EtblAdditionalCharge
{
    [Key]
    [Column("idAdditionalCharge")]
    public int IdAdditionalCharge { get; set; }

    [Column("cCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CCode { get; set; }

    [Column("cDescription")]
    [StringLength(120)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("bInclusive")]
    public bool BInclusive { get; set; }

    [Column("fMinAmt")]
    public double? FMinAmt { get; set; }

    [Column("fMinPct")]
    public double? FMinPct { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("iAccountLink")]
    public int? IAccountLink { get; set; }

    [Column("_etblAdditionalCharges_iBranchID")]
    public int? EtblAdditionalChargesIBranchId { get; set; }

    [Column("_etblAdditionalCharges_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAdditionalChargesDCreatedDate { get; set; }

    [Column("_etblAdditionalCharges_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAdditionalChargesDModifiedDate { get; set; }

    [Column("_etblAdditionalCharges_iCreatedBranchID")]
    public int? EtblAdditionalChargesICreatedBranchId { get; set; }

    [Column("_etblAdditionalCharges_iModifiedBranchID")]
    public int? EtblAdditionalChargesIModifiedBranchId { get; set; }

    [Column("_etblAdditionalCharges_iCreatedAgentID")]
    public int? EtblAdditionalChargesICreatedAgentId { get; set; }

    [Column("_etblAdditionalCharges_iModifiedAgentID")]
    public int? EtblAdditionalChargesIModifiedAgentId { get; set; }

    [Column("_etblAdditionalCharges_iChangeSetID")]
    public int? EtblAdditionalChargesIChangeSetId { get; set; }

    [Column("_etblAdditionalCharges_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAdditionalChargesChecksum { get; set; }

    [Column("bIsPercent")]
    public bool BIsPercent { get; set; }
}
