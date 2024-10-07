using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblContractTx")]
[Index("RtblContractTxChecksum", Name = "idx__rtblContractTx__rtblContractTx_Checksum")]
[Index("RtblContractTxIChangeSetId", Name = "idx__rtblContractTx_iChangeSetID")]
[Index("RtblContractTxDModifiedDate", Name = "idx_rtblContractTx_dModifiedDate")]
[Index("RtblContractTxIBranchId", Name = "idx_rtblContractTx_iBranchID")]
public partial class RtblContractTx
{
    [Key]
    [Column("idContractTx")]
    public int IdContractTx { get; set; }

    [Column("dDate", TypeName = "smalldatetime")]
    public DateTime DDate { get; set; }

    [Column("iContractID")]
    public int IContractId { get; set; }

    [Column("iIncidentID")]
    public int IIncidentId { get; set; }

    [Column("fAmount")]
    public double FAmount { get; set; }

    [Column("iDurationMins")]
    public int IDurationMins { get; set; }

    [Column("dTimeStamp", TypeName = "datetime")]
    public DateTime? DTimeStamp { get; set; }

    [Column("cTxInvoice")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CTxInvoice { get; set; }

    [Column("_rtblContractTx_iBranchID")]
    public int? RtblContractTxIBranchId { get; set; }

    [Column("_rtblContractTx_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblContractTxDCreatedDate { get; set; }

    [Column("_rtblContractTx_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblContractTxDModifiedDate { get; set; }

    [Column("_rtblContractTx_iCreatedBranchID")]
    public int? RtblContractTxICreatedBranchId { get; set; }

    [Column("_rtblContractTx_iModifiedBranchID")]
    public int? RtblContractTxIModifiedBranchId { get; set; }

    [Column("_rtblContractTx_iCreatedAgentID")]
    public int? RtblContractTxICreatedAgentId { get; set; }

    [Column("_rtblContractTx_iModifiedAgentID")]
    public int? RtblContractTxIModifiedAgentId { get; set; }

    [Column("_rtblContractTx_iChangeSetID")]
    public int? RtblContractTxIChangeSetId { get; set; }

    [Column("_rtblContractTx_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblContractTxChecksum { get; set; }
}
