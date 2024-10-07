using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvPosTillsFull
{
    public int IdTills { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string TillNo { get; set; } = null!;

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("iDeviceIDDisplay")]
    public int? IDeviceIddisplay { get; set; }

    [Column("iDeviceIDDrawer")]
    public int? IDeviceIddrawer { get; set; }

    [Column("iDeviceIDPrinter")]
    public int? IDeviceIdprinter { get; set; }

    [Column("Tills_iBranchID")]
    public int? TillsIBranchId { get; set; }

    [Column("Tills_dCreatedDate", TypeName = "datetime")]
    public DateTime? TillsDCreatedDate { get; set; }

    [Column("Tills_dModifiedDate", TypeName = "datetime")]
    public DateTime? TillsDModifiedDate { get; set; }

    [Column("Tills_iCreatedBranchID")]
    public int? TillsICreatedBranchId { get; set; }

    [Column("Tills_iModifiedBranchID")]
    public int? TillsIModifiedBranchId { get; set; }

    [Column("Tills_iCreatedAgentID")]
    public int? TillsICreatedAgentId { get; set; }

    [Column("Tills_iModifiedAgentID")]
    public int? TillsIModifiedAgentId { get; set; }

    [Column("Tills_iChangeSetID")]
    public int? TillsIChangeSetId { get; set; }

    [Column("iDeviceIDFiscalPrinter")]
    public int? IDeviceIdfiscalPrinter { get; set; }

    [Column("iDeviceIDPinPad")]
    public int? IDeviceIdpinPad { get; set; }

    [Column("cTerminalID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CTerminalId { get; set; }

    [Column("Tills_Checksum")]
    [MaxLength(20)]
    public byte[]? TillsChecksum { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Warehouse { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? DisplayDeviceCode { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? CashDrawerDeviceCode { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? RecPrinterDeviceCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisplayDeviceName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CashDrawerDeviceName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecPrinterDeviceName { get; set; }
}
