using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblMCAgentCriteria")]
[Index("EtblMcagentCriteriaChecksum", Name = "idx__etblMCAgentCriteria__etblMCAgentCriteria_Checksum")]
[Index("EtblMcagentCriteriaIChangeSetId", Name = "idx__etblMCAgentCriteria_iChangeSetID")]
[Index("EtblMcagentCriteriaDModifiedDate", Name = "idx_etblMCAgentCriteria_dModifiedDate")]
[Index("EtblMcagentCriteriaIBranchId", Name = "idx_etblMCAgentCriteria_iBranchID")]
public partial class EtblMcagentCriterion
{
    [Key]
    [Column("idAgentCriteria")]
    public int IdAgentCriteria { get; set; }

    [Column("cAgentCriteriaDesc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CAgentCriteriaDesc { get; set; }

    [Column("cAgent")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgent { get; set; }

    [Column("cModule")]
    [StringLength(40)]
    [Unicode(false)]
    public string CModule { get; set; } = null!;

    [Column("cMonitorValue")]
    [StringLength(100)]
    [Unicode(false)]
    public string CMonitorValue { get; set; } = null!;

    [Column("cOperator")]
    [StringLength(30)]
    [Unicode(false)]
    public string? COperator { get; set; }

    [Column("cResultValue")]
    [StringLength(250)]
    [Unicode(false)]
    public string? CResultValue { get; set; }

    [Column("cOwnResultValue")]
    [StringLength(50)]
    [Unicode(false)]
    public string? COwnResultValue { get; set; }

    [Column("cSQL", TypeName = "text")]
    public string? CSql { get; set; }

    [Column("cFrequencyDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CFrequencyDescription { get; set; }

    [Column("iFrequencyTimeInMin")]
    public int? IFrequencyTimeInMin { get; set; }

    [Column("dFrequencyStartTime", TypeName = "smalldatetime")]
    public DateTime? DFrequencyStartTime { get; set; }

    [Column("dFrequencyEndTime", TypeName = "smalldatetime")]
    public DateTime? DFrequencyEndTime { get; set; }

    [Column("cNotificationFrequency")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CNotificationFrequency { get; set; }

    [Column("bNotifyTrayIcon")]
    public bool BNotifyTrayIcon { get; set; }

    [Column("bNotifyEmail")]
    public bool BNotifyEmail { get; set; }

    [Column("bNotifySMS")]
    public bool BNotifySms { get; set; }

    [Column("bLogNotification")]
    public bool BLogNotification { get; set; }

    [Column("bAddToMyNotifications")]
    public bool BAddToMyNotifications { get; set; }

    [Column("cEmailToAddress", TypeName = "text")]
    public string? CEmailToAddress { get; set; }

    [Column("cEmailFromAddress")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CEmailFromAddress { get; set; }

    [Column("cEmailSubject")]
    [StringLength(120)]
    [Unicode(false)]
    public string? CEmailSubject { get; set; }

    [Column("cEmailMessage", TypeName = "text")]
    public string? CEmailMessage { get; set; }

    [Column("cSMSToAddress", TypeName = "text")]
    public string? CSmstoAddress { get; set; }

    [Column("cSMSMessage", TypeName = "text")]
    public string? CSmsmessage { get; set; }

    [Column("cTrayIconMessage", TypeName = "text")]
    public string? CTrayIconMessage { get; set; }

    [Column("cMyNotificationsMessage", TypeName = "text")]
    public string? CMyNotificationsMessage { get; set; }

    [Column("dLastNotificationDateTime", TypeName = "smalldatetime")]
    public DateTime? DLastNotificationDateTime { get; set; }

    [Column("cProcessing")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CProcessing { get; set; }

    [Column("cEmailCC", TypeName = "text")]
    public string? CEmailCc { get; set; }

    [Column("cEmailBcc", TypeName = "text")]
    public string? CEmailBcc { get; set; }

    [Column("_etblMCAgentCriteria_iBranchID")]
    public int? EtblMcagentCriteriaIBranchId { get; set; }

    [Column("_etblMCAgentCriteria_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblMcagentCriteriaDCreatedDate { get; set; }

    [Column("_etblMCAgentCriteria_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblMcagentCriteriaDModifiedDate { get; set; }

    [Column("_etblMCAgentCriteria_iCreatedBranchID")]
    public int? EtblMcagentCriteriaICreatedBranchId { get; set; }

    [Column("_etblMCAgentCriteria_iModifiedBranchID")]
    public int? EtblMcagentCriteriaIModifiedBranchId { get; set; }

    [Column("_etblMCAgentCriteria_iCreatedAgentID")]
    public int? EtblMcagentCriteriaICreatedAgentId { get; set; }

    [Column("_etblMCAgentCriteria_iModifiedAgentID")]
    public int? EtblMcagentCriteriaIModifiedAgentId { get; set; }

    [Column("_etblMCAgentCriteria_iChangeSetID")]
    public int? EtblMcagentCriteriaIChangeSetId { get; set; }

    [Column("iWarehouseID")]
    public int IWarehouseId { get; set; }

    [Column("_etblMCAgentCriteria_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblMcagentCriteriaChecksum { get; set; }
}
