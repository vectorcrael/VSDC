using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblFiscalData")]
[Index("EtblFiscalDataChecksum", Name = "idx__etblFiscalData__etblFiscalData_Checksum")]
[Index("EtblFiscalDataDModifiedDate", Name = "idx__etblFiscalData__etblFiscalData_dModifiedDate")]
[Index("EtblFiscalDataIBranchId", Name = "idx__etblFiscalData__etblFiscalData_iBranchID")]
[Index("EtblFiscalDataIChangeSetId", Name = "idx__etblFiscalData__etblFiscalData_iChangeSetID")]
public partial class EtblFiscalDatum
{
    [Key]
    [Column("idFiscalData")]
    public int IdFiscalData { get; set; }

    [Column("cDeviceTPIN")]
    [StringLength(20)]
    public string? CDeviceTpin { get; set; }

    [Column("iTaxAID")]
    public int? ITaxAid { get; set; }

    [Column("fTaxARate")]
    public double? FTaxArate { get; set; }

    [Column("iTaxBID")]
    public int? ITaxBid { get; set; }

    [Column("fTaxBRate")]
    public double? FTaxBrate { get; set; }

    [Column("iTaxCID")]
    public int? ITaxCid { get; set; }

    [Column("fTaxCRate")]
    public double? FTaxCrate { get; set; }

    [Column("iTaxDID")]
    public int? ITaxDid { get; set; }

    [Column("fTaxDRate")]
    public double? FTaxDrate { get; set; }

    [Column("iTaxEID")]
    public int? ITaxEid { get; set; }

    [Column("fTaxERate")]
    public double? FTaxErate { get; set; }

    [Column("iTaxFID")]
    public int? ITaxFid { get; set; }

    [Column("fTaxFRate")]
    public double? FTaxFrate { get; set; }

    [Column("iTaxGID")]
    public int? ITaxGid { get; set; }

    [Column("fTaxGRate")]
    public double? FTaxGrate { get; set; }

    [Column("iTaxHID")]
    public int? ITaxHid { get; set; }

    [Column("fTaxHRate")]
    public double? FTaxHrate { get; set; }

    [Column("cTaxJSON")]
    [StringLength(1000)]
    public string? CTaxJson { get; set; }

    [Column("cTaxpayerName")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CTaxpayerName { get; set; }

    [Column("cTaxpayerAddress")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CTaxpayerAddress { get; set; }

    [Column("cESDSerialNumber")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CEsdserialNumber { get; set; }

    [Column("cSerialNumber")]
    [StringLength(10)]
    public string? CSerialNumber { get; set; }

    [Column("bIsLocked")]
    public bool? BIsLocked { get; set; }

    [Column("_etblFiscalData_iBranchID")]
    public int? EtblFiscalDataIBranchId { get; set; }

    [Column("_etblFiscalData_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblFiscalDataDCreatedDate { get; set; }

    [Column("_etblFiscalData_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblFiscalDataDModifiedDate { get; set; }

    [Column("_etblFiscalData_iCreatedBranchID")]
    public int? EtblFiscalDataICreatedBranchId { get; set; }

    [Column("_etblFiscalData_iModifiedBranchID")]
    public int? EtblFiscalDataIModifiedBranchId { get; set; }

    [Column("_etblFiscalData_iCreatedAgentID")]
    public int? EtblFiscalDataICreatedAgentId { get; set; }

    [Column("_etblFiscalData_iModifiedAgentID")]
    public int? EtblFiscalDataIModifiedAgentId { get; set; }

    [Column("_etblFiscalData_iChangeSetID")]
    public int? EtblFiscalDataIChangeSetId { get; set; }

    [Column("_etblFiscalData_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblFiscalDataChecksum { get; set; }
}
