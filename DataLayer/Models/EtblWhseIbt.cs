using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblWhseIBT")]
[Index("EtblWhseIbtChecksum", Name = "idx__etblWhseIBT__etblWhseIBT_Checksum")]
[Index("EtblWhseIbtIChangeSetId", Name = "idx__etblWhseIBT_iChangeSetID")]
[Index("EtblWhseIbtDModifiedDate", Name = "idx_etblWhseIBT_dModifiedDate")]
[Index("EtblWhseIbtIBranchId", Name = "idx_etblWhseIBT_iBranchID")]
public partial class EtblWhseIbt
{
    [Key]
    [Column("IDWhseIBT")]
    public int IdwhseIbt { get; set; }

    [Column("cIBTNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CIbtnumber { get; set; }

    [Column("cIBTDescription")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CIbtdescription { get; set; }

    [Column("iWhseIDFrom")]
    public int? IWhseIdfrom { get; set; }

    [Column("iWhseIDTo")]
    public int? IWhseIdto { get; set; }

    [Column("iWhseIDIntransit")]
    public int? IWhseIdintransit { get; set; }

    [Column("iWhseIDVariance")]
    public int? IWhseIdvariance { get; set; }

    [Column("iWhseIDDamaged")]
    public int? IWhseIddamaged { get; set; }

    [Column("iIBTStatus")]
    public int? IIbtstatus { get; set; }

    [Column("cDelNoteNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDelNoteNumber { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("dDateIssued", TypeName = "datetime")]
    public DateTime? DDateIssued { get; set; }

    [Column("dDateReceived", TypeName = "datetime")]
    public DateTime? DDateReceived { get; set; }

    [Column("cAuditNumberIssued")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumberIssued { get; set; }

    [Column("cAuditNumberReceived")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAuditNumberReceived { get; set; }

    [Column("bUseAddCostPerLine")]
    public bool BUseAddCostPerLine { get; set; }

    [Column("fFixedAddCost")]
    public double FFixedAddCost { get; set; }

    [Column("iAgentIDIssue")]
    public int IAgentIdissue { get; set; }

    [Column("iAgentIDReceive")]
    public int IAgentIdreceive { get; set; }

    [Column("_etblWhseIBT_iBranchID")]
    public int? EtblWhseIbtIBranchId { get; set; }

    [Column("_etblWhseIBT_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblWhseIbtDCreatedDate { get; set; }

    [Column("_etblWhseIBT_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblWhseIbtDModifiedDate { get; set; }

    [Column("_etblWhseIBT_iCreatedBranchID")]
    public int? EtblWhseIbtICreatedBranchId { get; set; }

    [Column("_etblWhseIBT_iModifiedBranchID")]
    public int? EtblWhseIbtIModifiedBranchId { get; set; }

    [Column("_etblWhseIBT_iCreatedAgentID")]
    public int? EtblWhseIbtICreatedAgentId { get; set; }

    [Column("_etblWhseIBT_iModifiedAgentID")]
    public int? EtblWhseIbtIModifiedAgentId { get; set; }

    [Column("_etblWhseIBT_iChangeSetID")]
    public int? EtblWhseIbtIChangeSetId { get; set; }

    [Column("iBranchIDFrom")]
    public int? IBranchIdfrom { get; set; }

    [Column("dDateRequired", TypeName = "datetime")]
    public DateTime? DDateRequired { get; set; }

    [Column("dDateRequested", TypeName = "datetime")]
    public DateTime? DDateRequested { get; set; }

    [Column("dDateApproved", TypeName = "datetime")]
    public DateTime? DDateApproved { get; set; }

    [Column("iLinkedReqID")]
    public int? ILinkedReqId { get; set; }

    [Column("_etblWhseIBT_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblWhseIbtChecksum { get; set; }
}
