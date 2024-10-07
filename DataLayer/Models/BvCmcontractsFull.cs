using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCmcontractsFull
{
    [Column("idContracts")]
    public int IdContracts { get; set; }

    [Column("cContractNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CContractNumber { get; set; }

    [Column("iDebtorID")]
    public int IDebtorId { get; set; }

    [Column("cContractName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CContractName { get; set; } = null!;

    [Column("cContractReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CContractReference { get; set; }

    [Column("dCreated", TypeName = "datetime")]
    public DateTime? DCreated { get; set; }

    [Column("dStartDate", TypeName = "smalldatetime")]
    public DateTime DStartDate { get; set; }

    [Column("dEndDate", TypeName = "smalldatetime")]
    public DateTime DEndDate { get; set; }

    [Column("iBillType")]
    public int IBillType { get; set; }

    [Column("iTimeUnit")]
    public int ITimeUnit { get; set; }

    [Column("fAmount")]
    public double FAmount { get; set; }

    [Column("bBlock")]
    public bool BBlock { get; set; }

    [Column("iIncidentTypeID")]
    public int? IIncidentTypeId { get; set; }

    [Column("bAllowOverride")]
    public bool BAllowOverride { get; set; }

    [Column("cInvoice")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CInvoice { get; set; }

    [Column("iUnitsUsed")]
    public int IUnitsUsed { get; set; }

    [Column("iRecurrTransID")]
    public int? IRecurrTransId { get; set; }

    [Column("bExtendEndDate")]
    public bool BExtendEndDate { get; set; }

    [Column("_rtblContracts_iBranchID")]
    public int? RtblContractsIBranchId { get; set; }

    [Column("_rtblContracts_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblContractsDCreatedDate { get; set; }

    [Column("_rtblContracts_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblContractsDModifiedDate { get; set; }

    [Column("_rtblContracts_iCreatedBranchID")]
    public int? RtblContractsICreatedBranchId { get; set; }

    [Column("_rtblContracts_iModifiedBranchID")]
    public int? RtblContractsIModifiedBranchId { get; set; }

    [Column("_rtblContracts_iCreatedAgentID")]
    public int? RtblContractsICreatedAgentId { get; set; }

    [Column("_rtblContracts_iModifiedAgentID")]
    public int? RtblContractsIModifiedAgentId { get; set; }

    [Column("_rtblContracts_iChangeSetID")]
    public int? RtblContractsIChangeSetId { get; set; }

    [Column("_rtblContracts_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblContractsChecksum { get; set; }

    [Column("cDebtorAcc")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CDebtorAcc { get; set; }

    [Column("cDebtorName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CDebtorName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IncidentTypeDesc { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? BillTypeDescription { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? BillTypeDetail { get; set; }

    public bool? ContractActive { get; set; }
}
