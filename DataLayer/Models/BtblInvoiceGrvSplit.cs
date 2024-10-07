using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblInvoiceGrvSplit")]
[Index("BtblInvoiceGrvSplitChecksum", Name = "idx__btblInvoiceGrvSplit__btblInvoiceGrvSplit_Checksum")]
[Index("BtblInvoiceGrvSplitIChangeSetId", Name = "idx__btblInvoiceGrvSplit_iChangeSetID")]
[Index("BtblInvoiceGrvSplitDModifiedDate", Name = "idx_btblInvoiceGrvSplit_dModifiedDate")]
[Index("BtblInvoiceGrvSplitIBranchId", Name = "idx_btblInvoiceGrvSplit_iBranchID")]
public partial class BtblInvoiceGrvSplit
{
    [Key]
    [Column("idInvoiceGrvSplit")]
    public int IdInvoiceGrvSplit { get; set; }

    [Column("iGrvSplitInvoiceID")]
    public long IGrvSplitInvoiceId { get; set; }

    [Column("iGrvSplitVendorID")]
    public int IGrvSplitVendorId { get; set; }

    [Column("cGRVSplitReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CGrvsplitReference { get; set; }

    [Column("cGrvSplitDescription")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CGrvSplitDescription { get; set; }

    [Column("fGrvSplitAmount")]
    public double? FGrvSplitAmount { get; set; }

    [Column("iGrvSplitTaxTypeID")]
    public int? IGrvSplitTaxTypeId { get; set; }

    [Column("fGrvSplitTaxAmnt")]
    public double? FGrvSplitTaxAmnt { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("fForexRate")]
    public double? FForexRate { get; set; }

    [Column("fForexAmount")]
    public double? FForexAmount { get; set; }

    [Column("_btblInvoiceGrvSplit_iBranchID")]
    public int? BtblInvoiceGrvSplitIBranchId { get; set; }

    [Column("_btblInvoiceGrvSplit_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceGrvSplitDCreatedDate { get; set; }

    [Column("_btblInvoiceGrvSplit_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblInvoiceGrvSplitDModifiedDate { get; set; }

    [Column("_btblInvoiceGrvSplit_iCreatedBranchID")]
    public int? BtblInvoiceGrvSplitICreatedBranchId { get; set; }

    [Column("_btblInvoiceGrvSplit_iModifiedBranchID")]
    public int? BtblInvoiceGrvSplitIModifiedBranchId { get; set; }

    [Column("_btblInvoiceGrvSplit_iCreatedAgentID")]
    public int? BtblInvoiceGrvSplitICreatedAgentId { get; set; }

    [Column("_btblInvoiceGrvSplit_iModifiedAgentID")]
    public int? BtblInvoiceGrvSplitIModifiedAgentId { get; set; }

    [Column("_btblInvoiceGrvSplit_iChangeSetID")]
    public int? BtblInvoiceGrvSplitIChangeSetId { get; set; }

    [Column("fForexTaxAmount")]
    public double FForexTaxAmount { get; set; }

    [Column("_btblInvoiceGrvSplit_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblInvoiceGrvSplitChecksum { get; set; }
}
