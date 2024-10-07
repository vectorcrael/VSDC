using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblMCAgentNotifications")]
[Index("EtblMcagentNotificationsChecksum", Name = "idx__etblMCAgentNotifications__etblMCAgentNotifications_Checksum")]
[Index("EtblMcagentNotificationsIChangeSetId", Name = "idx__etblMCAgentNotifications_iChangeSetID")]
[Index("EtblMcagentNotificationsDModifiedDate", Name = "idx_etblMCAgentNotifications_dModifiedDate")]
[Index("EtblMcagentNotificationsIBranchId", Name = "idx_etblMCAgentNotifications_iBranchID")]
public partial class EtblMcagentNotification
{
    [Key]
    [Column("idAgentNotification")]
    public int IdAgentNotification { get; set; }

    [Column("cAgent")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgent { get; set; }

    [Column("AgentCriteriaID")]
    public int AgentCriteriaId { get; set; }

    [Column("cNotificationDesc")]
    [StringLength(50)]
    [Unicode(false)]
    public string CNotificationDesc { get; set; } = null!;

    [Column("cNotificationMessage")]
    [StringLength(1024)]
    [Unicode(false)]
    public string CNotificationMessage { get; set; } = null!;

    [Column("dNotificationDate", TypeName = "smalldatetime")]
    public DateTime DNotificationDate { get; set; }

    [Column("bAcknowledged")]
    public bool BAcknowledged { get; set; }

    [Column("bProcessed")]
    public bool BProcessed { get; set; }

    [Column("cProcessActions")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CProcessActions { get; set; }

    [Column("_etblMCAgentNotifications_iBranchID")]
    public int? EtblMcagentNotificationsIBranchId { get; set; }

    [Column("_etblMCAgentNotifications_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblMcagentNotificationsDCreatedDate { get; set; }

    [Column("_etblMCAgentNotifications_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblMcagentNotificationsDModifiedDate { get; set; }

    [Column("_etblMCAgentNotifications_iCreatedBranchID")]
    public int? EtblMcagentNotificationsICreatedBranchId { get; set; }

    [Column("_etblMCAgentNotifications_iModifiedBranchID")]
    public int? EtblMcagentNotificationsIModifiedBranchId { get; set; }

    [Column("_etblMCAgentNotifications_iCreatedAgentID")]
    public int? EtblMcagentNotificationsICreatedAgentId { get; set; }

    [Column("_etblMCAgentNotifications_iModifiedAgentID")]
    public int? EtblMcagentNotificationsIModifiedAgentId { get; set; }

    [Column("_etblMCAgentNotifications_iChangeSetID")]
    public int? EtblMcagentNotificationsIChangeSetId { get; set; }

    [Column("_etblMCAgentNotifications_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblMcagentNotificationsChecksum { get; set; }
}
