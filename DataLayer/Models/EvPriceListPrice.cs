using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvPriceListPrice
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
    public int? IdpriceListName { get; set; }

    [Column("cName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CName { get; set; }

    [Column("cDescription")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("bDefault")]
    public bool? BDefault { get; set; }

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

    public int? CurrencyLink { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? CurrencyCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("cCurrencySymbol")]
    [StringLength(4)]
    [Unicode(false)]
    public string? CCurrencySymbol { get; set; }

    [Column("iOptions")]
    public int? IOptions { get; set; }

    [Column("iPromptAgentID")]
    public int? IPromptAgentId { get; set; }

    [Column("Currency_iBranchID")]
    public int? CurrencyIBranchId { get; set; }

    [Column("Currency_dCreatedDate", TypeName = "datetime")]
    public DateTime? CurrencyDCreatedDate { get; set; }

    [Column("Currency_dModifiedDate", TypeName = "datetime")]
    public DateTime? CurrencyDModifiedDate { get; set; }

    [Column("Currency_iCreatedBranchID")]
    public int? CurrencyICreatedBranchId { get; set; }

    [Column("Currency_iModifiedBranchID")]
    public int? CurrencyIModifiedBranchId { get; set; }

    [Column("Currency_iCreatedAgentID")]
    public int? CurrencyICreatedAgentId { get; set; }

    [Column("Currency_iModifiedAgentID")]
    public int? CurrencyIModifiedAgentId { get; set; }

    [Column("Currency_iChangeSetID")]
    public int? CurrencyIChangeSetId { get; set; }

    [Column("Currency_Checksum")]
    [MaxLength(20)]
    public byte[]? CurrencyChecksum { get; set; }
}
