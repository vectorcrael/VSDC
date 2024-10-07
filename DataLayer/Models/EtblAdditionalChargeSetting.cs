using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAdditionalChargeSettings")]
[Index("EtblAdditionalChargeSettingsChecksum", Name = "idx__etblAdditionalChargeSettings__etblAdditionalChargeSettings_Checksum")]
[Index("EtblAdditionalChargeSettingsDModifiedDate", Name = "idx__etblAdditionalChargeSettings__etblAdditionalChargeSettings_dModifiedDate")]
[Index("EtblAdditionalChargeSettingsIBranchId", Name = "idx__etblAdditionalChargeSettings__etblAdditionalChargeSettings_iBranchID")]
[Index("EtblAdditionalChargeSettingsIChangeSetId", Name = "idx__etblAdditionalChargeSettings__etblAdditionalChargeSettings_iChangeSetID")]
public partial class EtblAdditionalChargeSetting
{
    [Key]
    [Column("idAdditionalChargeSettings")]
    public int IdAdditionalChargeSettings { get; set; }

    [Column("bDefault")]
    public bool BDefault { get; set; }

    [Column("bForce")]
    public bool BForce { get; set; }

    [Column("iAdditionalChargeID")]
    public int? IAdditionalChargeId { get; set; }

    [Column("iSettingTypeID")]
    public int? ISettingTypeId { get; set; }

    [Column("_etblAdditionalChargeSettings_iBranchID")]
    public int? EtblAdditionalChargeSettingsIBranchId { get; set; }

    [Column("_etblAdditionalChargeSettings_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblAdditionalChargeSettingsDCreatedDate { get; set; }

    [Column("_etblAdditionalChargeSettings_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblAdditionalChargeSettingsDModifiedDate { get; set; }

    [Column("_etblAdditionalChargeSettings_iCreatedBranchID")]
    public int? EtblAdditionalChargeSettingsICreatedBranchId { get; set; }

    [Column("_etblAdditionalChargeSettings_iModifiedBranchID")]
    public int? EtblAdditionalChargeSettingsIModifiedBranchId { get; set; }

    [Column("_etblAdditionalChargeSettings_iCreatedAgentID")]
    public int? EtblAdditionalChargeSettingsICreatedAgentId { get; set; }

    [Column("_etblAdditionalChargeSettings_iModifiedAgentID")]
    public int? EtblAdditionalChargeSettingsIModifiedAgentId { get; set; }

    [Column("_etblAdditionalChargeSettings_iChangeSetID")]
    public int? EtblAdditionalChargeSettingsIChangeSetId { get; set; }

    [Column("_etblAdditionalChargeSettings_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblAdditionalChargeSettingsChecksum { get; set; }

    [Column("bInvoiceCharge")]
    public bool BInvoiceCharge { get; set; }

    [Column("bReturnCharge")]
    public bool BReturnCharge { get; set; }
}
