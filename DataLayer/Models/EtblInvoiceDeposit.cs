using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblInvoiceDeposits")]
[Index("EtblInvoiceDepositsChecksum", Name = "idx__etblInvoiceDeposits__etblInvoiceDeposits_Checksum")]
[Index("EtblInvoiceDepositsDModifiedDate", Name = "idx__etblInvoiceDeposits__etblInvoiceDeposits_dModifiedDate")]
[Index("EtblInvoiceDepositsIBranchId", Name = "idx__etblInvoiceDeposits__etblInvoiceDeposits_iBranchID")]
[Index("EtblInvoiceDepositsIChangeSetId", Name = "idx__etblInvoiceDeposits__etblInvoiceDeposits_iChangeSetID")]
[Index("IInvoiceId", Name = "idx__etblInvoiceDeposits_iInvoiceID")]
public partial class EtblInvoiceDeposit
{
    [Key]
    [Column("idInvoiceDeposits")]
    public int IdInvoiceDeposits { get; set; }

    [Column("iInvoiceID")]
    public long? IInvoiceId { get; set; }

    [Column("fDepositAmount")]
    public double? FDepositAmount { get; set; }

    [Column("fUnallocatedAmount")]
    public double? FUnallocatedAmount { get; set; }

    [Column("iPostARID")]
    public long? IPostArid { get; set; }

    [Column("_etblInvoiceDeposits_iBranchID")]
    public int? EtblInvoiceDepositsIBranchId { get; set; }

    [Column("_etblInvoiceDeposits_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblInvoiceDepositsDCreatedDate { get; set; }

    [Column("_etblInvoiceDeposits_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblInvoiceDepositsDModifiedDate { get; set; }

    [Column("_etblInvoiceDeposits_iCreatedBranchID")]
    public int? EtblInvoiceDepositsICreatedBranchId { get; set; }

    [Column("_etblInvoiceDeposits_iModifiedBranchID")]
    public int? EtblInvoiceDepositsIModifiedBranchId { get; set; }

    [Column("_etblInvoiceDeposits_iCreatedAgentID")]
    public int? EtblInvoiceDepositsICreatedAgentId { get; set; }

    [Column("_etblInvoiceDeposits_iModifiedAgentID")]
    public int? EtblInvoiceDepositsIModifiedAgentId { get; set; }

    [Column("_etblInvoiceDeposits_iChangeSetID")]
    public int? EtblInvoiceDepositsIChangeSetId { get; set; }

    [Column("iInvoiceIDOrig")]
    public long? IInvoiceIdorig { get; set; }

    [Column("_etblInvoiceDeposits_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblInvoiceDepositsChecksum { get; set; }
}
