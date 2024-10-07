using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPOSDevices")]
[Index("EtblPosdevicesChecksum", Name = "idx__etblPOSDevices__etblPOSDevices_Checksum")]
[Index("EtblPosdevicesDModifiedDate", Name = "idx__etblPOSDevices__etblPOSDevices_dModifiedDate")]
[Index("EtblPosdevicesIBranchId", Name = "idx__etblPOSDevices__etblPOSDevices_iBranchID")]
[Index("EtblPosdevicesIChangeSetId", Name = "idx__etblPOSDevices__etblPOSDevices_iChangeSetID")]
public partial class EtblPosdevice
{
    [Key]
    [Column("idPOSDevices")]
    public int IdPosdevices { get; set; }

    [Column("cDeviceCode")]
    [StringLength(12)]
    [Unicode(false)]
    public string? CDeviceCode { get; set; }

    [Column("cDeviceDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDeviceDescription { get; set; }

    [Column("iDeviceType")]
    public int? IDeviceType { get; set; }

    [Column("iPortType")]
    public int? IPortType { get; set; }

    [Column("iPortNum")]
    public int? IPortNum { get; set; }

    [Column("iBaudrate")]
    public int? IBaudrate { get; set; }

    [Column("cControlCodes")]
    [StringLength(120)]
    [Unicode(false)]
    public string? CControlCodes { get; set; }

    [Column("iPoleDisplayWidth")]
    public int? IPoleDisplayWidth { get; set; }

    [Column("_etblPOSDevices_iBranchID")]
    public int? EtblPosdevicesIBranchId { get; set; }

    [Column("_etblPOSDevices_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPosdevicesDCreatedDate { get; set; }

    [Column("_etblPOSDevices_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPosdevicesDModifiedDate { get; set; }

    [Column("_etblPOSDevices_iCreatedBranchID")]
    public int? EtblPosdevicesICreatedBranchId { get; set; }

    [Column("_etblPOSDevices_iModifiedBranchID")]
    public int? EtblPosdevicesIModifiedBranchId { get; set; }

    [Column("_etblPOSDevices_iCreatedAgentID")]
    public int? EtblPosdevicesICreatedAgentId { get; set; }

    [Column("_etblPOSDevices_iModifiedAgentID")]
    public int? EtblPosdevicesIModifiedAgentId { get; set; }

    [Column("_etblPOSDevices_iChangeSetID")]
    public int? EtblPosdevicesIChangeSetId { get; set; }

    [Column("iFiscalPrinterId")]
    public int? IFiscalPrinterId { get; set; }

    [Column("cPrinterName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CPrinterName { get; set; }

    [Column("iFiscalPrinterModelsId")]
    public int? IFiscalPrinterModelsId { get; set; }

    [Column("cPrinterCOMName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CPrinterComname { get; set; }

    [Column("_etblPOSDevices_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPosdevicesChecksum { get; set; }
}
