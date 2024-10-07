using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvPriceListPricesFull
{
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

    [Column("IDPriceListName")]
    public int IdpriceListName { get; set; }

    [Column("cName")]
    [StringLength(30)]
    [Unicode(false)]
    public string CName { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bDefault")]
    public bool BDefault { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("dPLNameTimeStamp", TypeName = "datetime")]
    public DateTime? DPlnameTimeStamp { get; set; }

    [Column("_etblPriceListName_iBranchID")]
    public int? EtblPriceListNameIBranchId { get; set; }

    [Column("_etblPriceListName_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblPriceListNameDCreatedDate { get; set; }

    [Column("_etblPriceListName_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblPriceListNameDModifiedDate { get; set; }

    [Column("_etblPriceListName_iCreatedBranchID")]
    public int? EtblPriceListNameICreatedBranchId { get; set; }

    [Column("_etblPriceListName_iModifiedBranchID")]
    public int? EtblPriceListNameIModifiedBranchId { get; set; }

    [Column("_etblPriceListName_iCreatedAgentID")]
    public int? EtblPriceListNameICreatedAgentId { get; set; }

    [Column("_etblPriceListName_iModifiedAgentID")]
    public int? EtblPriceListNameIModifiedAgentId { get; set; }

    [Column("_etblPriceListName_iChangeSetID")]
    public int? EtblPriceListNameIChangeSetId { get; set; }

    [Column("_etblPriceListName_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblPriceListNameChecksum { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [Column("ItemDescription_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ItemDescription1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WarehouseCode { get; set; }
}
