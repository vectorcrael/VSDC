using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvoiceMessages")]
[Index("BtblInvoiceMessagesChecksum", Name = "idx__btblInvoiceMessages__btblInvoiceMessages_Checksum")]
[Index("BtblInvoiceMessagesIChangeSetId", Name = "idx__btblInvoiceMessages_iChangeSetID")]
[Index("BtblInvoiceMessagesDModifiedDate", Name = "idx_btblInvoiceMessages_dModifiedDate")]
[Index("BtblInvoiceMessagesIBranchId", Name = "idx_btblInvoiceMessages_iBranchID")]
public partial class BtblInvoiceMessage
{
    [Key]
    [Column("idInvoiceMessages")]
    public int IdInvoiceMessages { get; set; }

    [Column("iType")]
    public int IType { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("cMessage1")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CMessage1 { get; set; }

    [Column("cMessage2")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CMessage2 { get; set; }

    [Column("cMessage3")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CMessage3 { get; set; }

    [Column("_btblInvoiceMessages_iBranchID")]
    public int? BtblInvoiceMessagesIBranchId { get; set; }

    [Column("_btblInvoiceMessages_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceMessagesDCreatedDate { get; set; }

    [Column("_btblInvoiceMessages_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceMessagesDModifiedDate { get; set; }

    [Column("_btblInvoiceMessages_iCreatedBranchID")]
    public int? BtblInvoiceMessagesICreatedBranchId { get; set; }

    [Column("_btblInvoiceMessages_iModifiedBranchID")]
    public int? BtblInvoiceMessagesIModifiedBranchId { get; set; }

    [Column("_btblInvoiceMessages_iCreatedAgentID")]
    public int? BtblInvoiceMessagesICreatedAgentId { get; set; }

    [Column("_btblInvoiceMessages_iModifiedAgentID")]
    public int? BtblInvoiceMessagesIModifiedAgentId { get; set; }

    [Column("_btblInvoiceMessages_iChangeSetID")]
    public int? BtblInvoiceMessagesIChangeSetId { get; set; }

    [Column("bIsExcessInvoice")]
    public bool BIsExcessInvoice { get; set; }

    [Column("_btblInvoiceMessages_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvoiceMessagesChecksum { get; set; }
}
