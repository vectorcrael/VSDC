using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvoiceLineSN")]
[Index("BtblInvoiceLineSnChecksum", Name = "idx__btblInvoiceLineSN__btblInvoiceLineSN_Checksum")]
[Index("BtblInvoiceLineSnIChangeSetId", Name = "idx__btblInvoiceLineSN_iChangeSetID")]
[Index("BtblInvoiceLineSnDModifiedDate", Name = "idx_btblInvoiceLineSN_dModifiedDate")]
[Index("BtblInvoiceLineSnIBranchId", Name = "idx_btblInvoiceLineSN_iBranchID")]
public partial class BtblInvoiceLineSn
{
    [Key]
    [Column("idInvoiceLineSN")]
    public int IdInvoiceLineSn { get; set; }

    [Column("iSerialInvoiceID")]
    public int ISerialInvoiceId { get; set; }

    [Column("iSerialInvoiceLineID")]
    public long ISerialInvoiceLineId { get; set; }

    [Column("cSerialNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSerialNumber { get; set; }

    [Column("_btblInvoiceLineSN_iBranchID")]
    public int? BtblInvoiceLineSnIBranchId { get; set; }

    [Column("_btblInvoiceLineSN_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceLineSnDCreatedDate { get; set; }

    [Column("_btblInvoiceLineSN_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceLineSnDModifiedDate { get; set; }

    [Column("_btblInvoiceLineSN_iCreatedBranchID")]
    public int? BtblInvoiceLineSnICreatedBranchId { get; set; }

    [Column("_btblInvoiceLineSN_iModifiedBranchID")]
    public int? BtblInvoiceLineSnIModifiedBranchId { get; set; }

    [Column("_btblInvoiceLineSN_iCreatedAgentID")]
    public int? BtblInvoiceLineSnICreatedAgentId { get; set; }

    [Column("_btblInvoiceLineSN_iModifiedAgentID")]
    public int? BtblInvoiceLineSnIModifiedAgentId { get; set; }

    [Column("_btblInvoiceLineSN_iChangeSetID")]
    public int? BtblInvoiceLineSnIChangeSetId { get; set; }

    [Column("_btblInvoiceLineSN_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvoiceLineSnChecksum { get; set; }
}
