using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvWhseIbt
{
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

    [StringLength(20)]
    [Unicode(false)]
    public string? FromWhCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FromWhName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? FromWhAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? FromWhAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? FromWhAddress3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FromWhPostCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FromWhTel { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FromWhManager { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? FromWhEmail { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FromWhFax { get; set; }

    [Column("FromWhBranchID")]
    public int? FromWhBranchId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ToWhCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ToWhName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ToWhAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ToWhAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? ToWhAddress3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ToWhPostCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ToWhTel { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ToWhManager { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ToWhEmail { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ToWhFax { get; set; }

    [Column("ToWhBranchID")]
    public int? ToWhBranchId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InTransitWhCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InTransitWhName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? InTransitWhAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? InTransitWhAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? InTransitWhAddress3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? InTransitWhPostCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? InTransitWhTel { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? InTransitWhManager { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? InTransitWhEmail { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? InTransitWhFax { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VarianceWhCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VarianceWhName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? VarianceWhAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? VarianceWhAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? VarianceWhAddress3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? VarianceWhPostCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? VarianceWhTel { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? VarianceWhManager { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? VarianceWhEmail { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? VarianceWhFax { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DamagedWhCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DamagedWhName { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DamagedWhAddress1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DamagedWhAddress2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? DamagedWhAddress3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? DamagedWhPostCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? DamagedWhTel { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DamagedWhManager { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? DamagedWhEmail { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? DamagedWhFax { get; set; }

    [Column("IBTStatus")]
    [StringLength(19)]
    [Unicode(false)]
    public string Ibtstatus { get; set; } = null!;

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [Column("cBranchCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CBranchCode { get; set; }

    [Column("cBranchDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBranchDescription { get; set; }
}
