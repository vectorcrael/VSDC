using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCmcontractTxFull
{
    [Column("IncidentID")]
    public int IncidentId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InternalReference { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? YourReference { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? IncidentCatDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IncidentTypeDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IncidentLastModifiedDateStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IncidentCreatedDate { get; set; }

    [Column("IncidentStatusID")]
    public int IncidentStatusId { get; set; }

    [Column("CustomerID")]
    public int CustomerId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? CustomerTelephone { get; set; }

    [StringLength(1024)]
    [Unicode(false)]
    public string? IncidentOutline { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ContractName { get; set; } = null!;

    [Column("iBillType")]
    public int IBillType { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? BillTypeDescription { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? BillTypeDetail { get; set; }

    [Column("iTimeUnit")]
    public int ITimeUnit { get; set; }

    [Column("cContractReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CContractReference { get; set; }

    public int IdContracts { get; set; }

    [Column("dDate", TypeName = "smalldatetime")]
    public DateTime DDate { get; set; }

    [Column("iDurationMins")]
    public int IDurationMins { get; set; }

    [Column("fAmount")]
    public double FAmount { get; set; }

    public int? UnitsToBill { get; set; }

    public double BillingUnitAmount { get; set; }

    public double? BillingAmount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TimeMinutes { get; set; }

    [Column("_rtblContracts_iBranchID")]
    public int? RtblContractsIBranchId { get; set; }

    [Column("iIncidentTypeID")]
    public int IIncidentTypeId { get; set; }
}
