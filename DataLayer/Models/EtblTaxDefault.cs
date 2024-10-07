using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblTaxDefaults")]
[Index("EtblTaxDefaultsChecksum", Name = "idx__etblTaxDefaults__etblTaxDefaults_Checksum")]
[Index("EtblTaxDefaultsDModifiedDate", Name = "idx__etblTaxDefaults__etblTaxDefaults_dModifiedDate")]
[Index("EtblTaxDefaultsIBranchId", Name = "idx__etblTaxDefaults__etblTaxDefaults_iBranchID")]
[Index("EtblTaxDefaultsIChangeSetId", Name = "idx__etblTaxDefaults__etblTaxDefaults_iChangeSetID")]
public partial class EtblTaxDefault
{
    [Key]
    [Column("idTaxDefaults")]
    public int IdTaxDefaults { get; set; }

    [Column("cTaxNumber")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CTaxNumber { get; set; }

    [Column("cRegistration")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CRegistration { get; set; }

    [Column("cCustomsCode")]
    [StringLength(8)]
    [Unicode(false)]
    public string? CCustomsCode { get; set; }

    [Column("iTaxDueLedgerAccount")]
    public int? ITaxDueLedgerAccount { get; set; }

    [Column("iPBTStartPeriodID")]
    public int? IPbtstartPeriodId { get; set; }

    [Column("bPrincipalVendor")]
    public bool? BPrincipalVendor { get; set; }

    [Column("bValidateTaxGroups")]
    public bool? BValidateTaxGroups { get; set; }

    [Column("cTaxContactName")]
    [StringLength(90)]
    [Unicode(false)]
    public string? CTaxContactName { get; set; }

    [Column("cTaxContactSurname")]
    [StringLength(53)]
    [Unicode(false)]
    public string? CTaxContactSurname { get; set; }

    [Column("cTaxContactTelephone1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CTaxContactTelephone1 { get; set; }

    [Column("cTaxContactTelephone2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CTaxContactTelephone2 { get; set; }

    [Column("cTaxContactCellular")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CTaxContactCellular { get; set; }

    [Column("cTaxContactFax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CTaxContactFax { get; set; }

    [Column("cTaxContactEmail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CTaxContactEmail { get; set; }

    [Column("bForceClientTaxIdentification")]
    public bool? BForceClientTaxIdentification { get; set; }

    [Column("bForceSupplierTaxIdentification")]
    public bool? BForceSupplierTaxIdentification { get; set; }

    [Column("_etblTaxDefaults_iBranchID")]
    public int? EtblTaxDefaultsIBranchId { get; set; }

    [Column("_etblTaxDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblTaxDefaultsDCreatedDate { get; set; }

    [Column("_etblTaxDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblTaxDefaultsDModifiedDate { get; set; }

    [Column("_etblTaxDefaults_iCreatedBranchID")]
    public int? EtblTaxDefaultsICreatedBranchId { get; set; }

    [Column("_etblTaxDefaults_iModifiedBranchID")]
    public int? EtblTaxDefaultsIModifiedBranchId { get; set; }

    [Column("_etblTaxDefaults_iCreatedAgentID")]
    public int? EtblTaxDefaultsICreatedAgentId { get; set; }

    [Column("_etblTaxDefaults_iModifiedAgentID")]
    public int? EtblTaxDefaultsIModifiedAgentId { get; set; }

    [Column("_etblTaxDefaults_iChangeSetID")]
    public int? EtblTaxDefaultsIChangeSetId { get; set; }

    [Column("bValidateClientTaxIdentification")]
    public bool BValidateClientTaxIdentification { get; set; }

    [Column("bValidateSupplierTaxIdentification")]
    public bool BValidateSupplierTaxIdentification { get; set; }

    [Column("_etblTaxDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblTaxDefaultsChecksum { get; set; }

    [Column("iBadDebtRecovered")]
    public int IBadDebtRecovered { get; set; }

    [Column("iBadDebtRelief")]
    public int IBadDebtRelief { get; set; }

    [Column("iBadDebtRefund")]
    public int IBadDebtRefund { get; set; }

    [Column("iBadDebtReclaim")]
    public int IBadDebtReclaim { get; set; }

    [Column("iIDFTaxCodeID")]
    public int IIdftaxCodeId { get; set; }

    [Column("iIDFTransTypeID")]
    public int IIdftransTypeId { get; set; }

    [Column("bIDFUseAgent")]
    public bool BIdfuseAgent { get; set; }

    [Column("iIDFForAgentTaxCodeID")]
    public int IIdfforAgentTaxCodeId { get; set; }

    [Column("iImportServiceSRPTaxCodeID")]
    public int IImportServiceSrptaxCodeId { get; set; }

    [Column("iImportServiceSRSTaxCodeID")]
    public int IImportServiceSrstaxCodeId { get; set; }

    [Column("bForceTaxDetails")]
    public bool BForceTaxDetails { get; set; }
}
