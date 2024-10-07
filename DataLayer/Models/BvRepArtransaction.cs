using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvRepArtransaction
{
    [Column("idSalesRep")]
    public int IdSalesRep { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Name { get; set; }

    public short? Method { get; set; }

    public double? Target1 { get; set; }

    public double? Commission1 { get; set; }

    public double? Target2 { get; set; }

    public double? Commission2 { get; set; }

    public double? Target3 { get; set; }

    public double? Commission3 { get; set; }

    public double? Target4 { get; set; }

    public double? Commission4 { get; set; }

    public double? Target5 { get; set; }

    public double? Commission5 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Entity { get; set; }

    [Column("Rep_On_Hold")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RepOnHold { get; set; }

    [Column("Bank_Account")]
    [StringLength(40)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Comment1 { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Comment2 { get; set; }

    [Column("SalesRep_iBranchID")]
    public int? SalesRepIBranchId { get; set; }

    [Column("SalesRep_dCreatedDate", TypeName = "datetime")]
    public DateTime? SalesRepDCreatedDate { get; set; }

    [Column("SalesRep_dModifiedDate", TypeName = "datetime")]
    public DateTime? SalesRepDModifiedDate { get; set; }

    [Column("SalesRep_iCreatedBranchID")]
    public int? SalesRepICreatedBranchId { get; set; }

    [Column("SalesRep_iModifiedBranchID")]
    public int? SalesRepIModifiedBranchId { get; set; }

    [Column("SalesRep_iCreatedAgentID")]
    public int? SalesRepICreatedAgentId { get; set; }

    [Column("SalesRep_iModifiedAgentID")]
    public int? SalesRepIModifiedAgentId { get; set; }

    [Column("SalesRep_iChangeSetID")]
    public int? SalesRepIChangeSetId { get; set; }

    [Column("SalesRep_Checksum")]
    [MaxLength(20)]
    public byte[]? SalesRepChecksum { get; set; }

    [Column("ARTxDate", TypeName = "smalldatetime")]
    public DateTime? ArtxDate { get; set; }

    [Column("ARTxID")]
    [StringLength(5)]
    [Unicode(false)]
    public string ArtxId { get; set; } = null!;

    [Column("ARTxCustomerID")]
    public int? ArtxCustomerId { get; set; }

    [Column("ARTxCode")]
    public int? ArtxCode { get; set; }

    [Column("ARTxDebit")]
    public double? ArtxDebit { get; set; }

    [Column("ARTxCredit")]
    public double? ArtxCredit { get; set; }

    [Column("ARTxTaxAmount")]
    public double? ArtxTaxAmount { get; set; }

    [Column("ARTxDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ArtxDescription { get; set; }

    [Column("ARTxReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ArtxReference { get; set; }

    [Column("ARTxOrderNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ArtxOrderNo { get; set; }

    [Column("ARTxAuditNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ArtxAuditNo { get; set; }

    [Column("ARTxTurnover")]
    public double? ArtxTurnover { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? ProjectCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LineProjectName { get; set; }

    public bool? ActiveProject { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? ProjectDescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Customer { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerGroup { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomerGroupDesc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CustomerArea { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CustomerAreaDescr { get; set; }
}
