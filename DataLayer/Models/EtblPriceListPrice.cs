using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblPriceListPrices")]
[Index("EtblPriceListPricesChecksum", Name = "idx__etblPriceListPrices__etblPriceListPrices_Checksum")]
[Index("EtblPriceListPricesIChangeSetId", Name = "idx__etblPriceListPrices_iChangeSetID")]
[Index("IStockId", "BUseMarkup", Name = "idx__etblPriceListPrices_iStockIDbUseMarkup")]
[Index("EtblPriceListPricesDModifiedDate", Name = "idx_etblPriceListPrices_dModifiedDate")]
[Index("EtblPriceListPricesIBranchId", Name = "idx_etblPriceListPrices_iBranchID")]
public partial class EtblPriceListPrice
{
    [Key]
    [Column("IDPriceListPrices")]
    public long IdpriceListPrices { get; set; }

    [Column("iPriceListNameID")]
    public int IPriceListNameId { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iWarehouseID")]
    public int? IWarehouseId { get; set; }

    [Column("bUseMarkup")]
    public bool BUseMarkup { get; set; }

    [Column("iMarkupOnCost")]
    public int IMarkupOnCost { get; set; }

    [Column("fMarkupRate")]
    public double? FMarkupRate { get; set; }

    [Column("fExclPrice")]
    public double? FExclPrice { get; set; }

    [Column("fInclPrice")]
    public double? FInclPrice { get; set; }

    [Column("dPLPricesTimeStamp", TypeName = "datetime")]
    public DateTime? DPlpricesTimeStamp { get; set; }

    [Column("_etblPriceListPrices_iBranchID")]
    public int? EtblPriceListPricesIBranchId { get; set; }

    [Column("_etblPriceListPrices_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPriceListPricesDCreatedDate { get; set; }

    [Column("_etblPriceListPrices_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPriceListPricesDModifiedDate { get; set; }

    [Column("_etblPriceListPrices_iCreatedBranchID")]
    public int? EtblPriceListPricesICreatedBranchId { get; set; }

    [Column("_etblPriceListPrices_iModifiedBranchID")]
    public int? EtblPriceListPricesIModifiedBranchId { get; set; }

    [Column("_etblPriceListPrices_iCreatedAgentID")]
    public int? EtblPriceListPricesICreatedAgentId { get; set; }

    [Column("_etblPriceListPrices_iModifiedAgentID")]
    public int? EtblPriceListPricesIModifiedAgentId { get; set; }

    [Column("_etblPriceListPrices_iChangeSetID")]
    public int? EtblPriceListPricesIChangeSetId { get; set; }

    [Column("_etblPriceListPrices_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPriceListPricesChecksum { get; set; }
}
