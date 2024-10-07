using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblFiscalPrinters")]
[Index("EtblFiscalPrintersChecksum", Name = "idx__etblFiscalPrinters__etblFiscalPrinters_Checksum")]
[Index("EtblFiscalPrintersDModifiedDate", Name = "idx__etblFiscalPrinters__etblFiscalPrinters_dModifiedDate")]
[Index("EtblFiscalPrintersIBranchId", Name = "idx__etblFiscalPrinters__etblFiscalPrinters_iBranchID")]
[Index("EtblFiscalPrintersIChangeSetId", Name = "idx__etblFiscalPrinters__etblFiscalPrinters_iChangeSetID")]
public partial class EtblFiscalPrinter
{
    [Key]
    [Column("iFiscalPrinterId")]
    public int IFiscalPrinterId { get; set; }

    [Column("iPOSDeviceId")]
    public int? IPosdeviceId { get; set; }

    [Column("cIPAddress")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CIpaddress { get; set; }

    [Column("cPortNumber")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CPortNumber { get; set; }

    [Column("cSubnetMask")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CSubnetMask { get; set; }

    [Column("cDefaultGateway")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CDefaultGateway { get; set; }

    [Column("cMACAddress")]
    [StringLength(17)]
    [Unicode(false)]
    public string? CMacaddress { get; set; }

    [Column("iTaxTypeA")]
    public int? ITaxTypeA { get; set; }

    [Column("iTaxTypeB")]
    public int? ITaxTypeB { get; set; }

    [Column("iTaxTypeC")]
    public int? ITaxTypeC { get; set; }

    [Column("iTaxTypeD")]
    public int? ITaxTypeD { get; set; }

    [Column("iTaxTypeE")]
    public int? ITaxTypeE { get; set; }

    [Column("iTaxTypeF")]
    public int? ITaxTypeF { get; set; }

    [Column("_etblFiscalPrinters_iBranchID")]
    public int? EtblFiscalPrintersIBranchId { get; set; }

    [Column("_etblFiscalPrinters_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblFiscalPrintersDCreatedDate { get; set; }

    [Column("_etblFiscalPrinters_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblFiscalPrintersDModifiedDate { get; set; }

    [Column("_etblFiscalPrinters_iCreatedBranchID")]
    public int? EtblFiscalPrintersICreatedBranchId { get; set; }

    [Column("_etblFiscalPrinters_iModifiedBranchID")]
    public int? EtblFiscalPrintersIModifiedBranchId { get; set; }

    [Column("_etblFiscalPrinters_iCreatedAgentID")]
    public int? EtblFiscalPrintersICreatedAgentId { get; set; }

    [Column("_etblFiscalPrinters_iModifiedAgentID")]
    public int? EtblFiscalPrintersIModifiedAgentId { get; set; }

    [Column("_etblFiscalPrinters_iChangeSetID")]
    public int? EtblFiscalPrintersIChangeSetId { get; set; }

    [Column("bDeviceConfigured")]
    public bool? BDeviceConfigured { get; set; }

    [Column("cRegistrationKey")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CRegistrationKey { get; set; }

    [Column("cTINNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTinnumber { get; set; }

    [Column("cMRCNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CMrcnumber { get; set; }

    [Column("_etblFiscalPrinters_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblFiscalPrintersChecksum { get; set; }

    [Column("iTaxTypeG")]
    public int? ITaxTypeG { get; set; }

    [Column("iTaxTypeH")]
    public int? ITaxTypeH { get; set; }
}
