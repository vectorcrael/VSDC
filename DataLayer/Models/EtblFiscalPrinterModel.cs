using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblFiscalPrinterModels")]
[Index("EtblFiscalPrinterModelsChecksum", Name = "idx__etblFiscalPrinterModels__etblFiscalPrinterModels_Checksum")]
[Index("EtblFiscalPrinterModelsDModifiedDate", Name = "idx__etblFiscalPrinterModels__etblFiscalPrinterModels_dModifiedDate")]
[Index("EtblFiscalPrinterModelsIBranchId", Name = "idx__etblFiscalPrinterModels__etblFiscalPrinterModels_iBranchID")]
[Index("EtblFiscalPrinterModelsIChangeSetId", Name = "idx__etblFiscalPrinterModels__etblFiscalPrinterModels_iChangeSetID")]
public partial class EtblFiscalPrinterModel
{
    [Key]
    [Column("iFiscalPrinterModelsId")]
    public int IFiscalPrinterModelsId { get; set; }

    [Column("cPrinterModelName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CPrinterModelName { get; set; }

    [Column("cPrinterModelManufacture")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CPrinterModelManufacture { get; set; }

    [Column("_etblFiscalPrinterModels_iBranchID")]
    public int? EtblFiscalPrinterModelsIBranchId { get; set; }

    [Column("_etblFiscalPrinterModels_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblFiscalPrinterModelsDCreatedDate { get; set; }

    [Column("_etblFiscalPrinterModels_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblFiscalPrinterModelsDModifiedDate { get; set; }

    [Column("_etblFiscalPrinterModels_iCreatedBranchID")]
    public int? EtblFiscalPrinterModelsICreatedBranchId { get; set; }

    [Column("_etblFiscalPrinterModels_iModifiedBranchID")]
    public int? EtblFiscalPrinterModelsIModifiedBranchId { get; set; }

    [Column("_etblFiscalPrinterModels_iCreatedAgentID")]
    public int? EtblFiscalPrinterModelsICreatedAgentId { get; set; }

    [Column("_etblFiscalPrinterModels_iModifiedAgentID")]
    public int? EtblFiscalPrinterModelsIModifiedAgentId { get; set; }

    [Column("_etblFiscalPrinterModels_iChangeSetID")]
    public int? EtblFiscalPrinterModelsIChangeSetId { get; set; }

    [Column("cFiscalDriverName")]
    [StringLength(20)]
    public string? CFiscalDriverName { get; set; }

    [Column("bAllowAlphaNumDoc")]
    public bool BAllowAlphaNumDoc { get; set; }

    [Column("bIsPrinter")]
    public bool BIsPrinter { get; set; }

    [Column("_etblFiscalPrinterModels_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblFiscalPrinterModelsChecksum { get; set; }
}
