using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSystemDefaults")]
[Index("EtblSystemDefaultsChecksum", Name = "idx__etblSystemDefaults__etblSystemDefaults_Checksum")]
public partial class EtblSystemDefault
{
    [Key]
    [Column("idSystemDefaults")]
    public int IdSystemDefaults { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? DefaultAccess { get; set; }

    [StringLength(684)]
    [Unicode(false)]
    public string? Security { get; set; }

    [StringLength(684)]
    [Unicode(false)]
    public string? CheckValue { get; set; }

    public bool SmartFilter { get; set; }

    [Column("SMTPAccount")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Smtpaccount { get; set; }

    [Column("SMTPAuthenticate")]
    public bool Smtpauthenticate { get; set; }

    [Column("SMTPAuthPass")]
    [StringLength(684)]
    [Unicode(false)]
    public string? SmtpauthPass { get; set; }

    [Column("SMTPAuthUser")]
    [StringLength(256)]
    [Unicode(false)]
    public string? SmtpauthUser { get; set; }

    [Column("SMTPFrom")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Smtpfrom { get; set; }

    [Column("SMTPName")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Smtpname { get; set; }

    [Column("SMTPOrg")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Smtporg { get; set; }

    [Column("SMTPPassword")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Smtppassword { get; set; }

    [Column("SMTPPort")]
    public int? Smtpport { get; set; }

    [Column("SMTPReplyTo")]
    [StringLength(256)]
    [Unicode(false)]
    public string? SmtpreplyTo { get; set; }

    [Column("SMTPServer")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Smtpserver { get; set; }

    [Column("SMTPUseGlobalFromAddr")]
    public bool SmtpuseGlobalFromAddr { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? SyncDataFolder { get; set; }

    [Column("SyncDBServerDataFolder")]
    [StringLength(256)]
    [Unicode(false)]
    public string? SyncDbserverDataFolder { get; set; }

    public int? UpdateCheck { get; set; }

    public int? UpdateCheckInterval { get; set; }

    [Column("BICRepository")]
    [StringLength(256)]
    [Unicode(false)]
    public string? Bicrepository { get; set; }

    [Column("BICRptFinancialYear")]
    public int? BicrptFinancialYear { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? HtmlRoot { get; set; }

    [Column("UseSegmentedGL")]
    public bool UseSegmentedGl { get; set; }

    [Column("_etblSystemDefaults_iBranchID")]
    public int? EtblSystemDefaultsIBranchId { get; set; }

    [Column("_etblSystemDefaults_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblSystemDefaultsDCreatedDate { get; set; }

    [Column("_etblSystemDefaults_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblSystemDefaultsDModifiedDate { get; set; }

    [Column("_etblSystemDefaults_iCreatedBranchID")]
    public int? EtblSystemDefaultsICreatedBranchId { get; set; }

    [Column("_etblSystemDefaults_iModifiedBranchID")]
    public int? EtblSystemDefaultsIModifiedBranchId { get; set; }

    [Column("_etblSystemDefaults_iCreatedAgentID")]
    public int? EtblSystemDefaultsICreatedAgentId { get; set; }

    [Column("_etblSystemDefaults_iModifiedAgentID")]
    public int? EtblSystemDefaultsIModifiedAgentId { get; set; }

    [Column("_etblSystemDefaults_iChangeSetID")]
    public int? EtblSystemDefaultsIChangeSetId { get; set; }

    [Column("bUseTLS")]
    public int? BUseTls { get; set; }

    [Column("bDisableRTF")]
    public bool BDisableRtf { get; set; }

    [Column("bUseCOM")]
    public bool? BUseCom { get; set; }

    [Column("bUseMapi")]
    public bool BUseMapi { get; set; }

    [Column("cSMTPBccAddresss")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSmtpbccAddresss { get; set; }

    [Column("bUpdateGLBalances")]
    public bool BUpdateGlbalances { get; set; }

    [Column("iGLRelinkCheckInterval")]
    public int IGlrelinkCheckInterval { get; set; }

    [Column("iPwrNumberChar")]
    public int IPwrNumberChar { get; set; }

    [Column("iPwrLetterChar")]
    public int IPwrLetterChar { get; set; }

    [Column("iPwrSymbolChar")]
    public int IPwrSymbolChar { get; set; }

    [Column("iPwrUppercaseChar")]
    public int IPwrUppercaseChar { get; set; }

    [Column("iPwrLowercaseChar")]
    public int IPwrLowercaseChar { get; set; }

    [Column("iLockOutAttempts")]
    public int ILockOutAttempts { get; set; }

    [Column("iLockOutDuration")]
    public int ILockOutDuration { get; set; }

    [Column("bPwrComplexity")]
    public bool BPwrComplexity { get; set; }

    [Column("bEnableLockOut")]
    public bool BEnableLockOut { get; set; }

    [Column("cFreedomService")]
    [StringLength(250)]
    [Unicode(false)]
    public string? CFreedomService { get; set; }

    [Column("cFailOverService")]
    [StringLength(250)]
    [Unicode(false)]
    public string? CFailOverService { get; set; }

    [Column("bUseLocalService")]
    public bool BUseLocalService { get; set; }

    [Column("iFSSessionTimeOut")]
    public int IFssessionTimeOut { get; set; }

    [Column("bExceptionTrapping")]
    public bool? BExceptionTrapping { get; set; }

    [Column("_etblSystemDefaults_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblSystemDefaultsChecksum { get; set; }

    [Column("bUseOutgoingServerSettings")]
    public bool BUseOutgoingServerSettings { get; set; }

    [Column("iSMTPProvider")]
    public int ISmtpprovider { get; set; }
}
