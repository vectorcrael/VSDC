using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CurrencyHist")]
[Index("CurrencyHistDModifiedDate", Name = "idxCurrencyHist_dModifiedDate")]
[Index("CurrencyHistIBranchId", Name = "idxCurrencyHist_iBranchID")]
[Index("CurrencyHistChecksum", Name = "idx_CurrencyHist_CurrencyHist_Checksum")]
[Index("CurrencyHistIChangeSetId", Name = "idx_CurrencyHist_iChangeSetID")]
public partial class CurrencyHist
{
    [Key]
    [Column("idCurrencyHist")]
    public int IdCurrencyHist { get; set; }

    [Column("iCurrencyID")]
    public int? ICurrencyId { get; set; }

    [Column("dRateDate", TypeName = "datetime")]
    public DateTime? DRateDate { get; set; }

    [Column("fBuyRate")]
    public double? FBuyRate { get; set; }

    [Column("fSellRate")]
    public double? FSellRate { get; set; }

    [Column("CurrencyHist_iBranchID")]
    public int? CurrencyHistIBranchId { get; set; }

    [Column("CurrencyHist_dCreatedDate", TypeName = "datetime")]
    public DateTime? CurrencyHistDCreatedDate { get; set; }

    [Column("CurrencyHist_dModifiedDate", TypeName = "datetime")]
    public DateTime? CurrencyHistDModifiedDate { get; set; }

    [Column("CurrencyHist_iCreatedBranchID")]
    public int? CurrencyHistICreatedBranchId { get; set; }

    [Column("CurrencyHist_iModifiedBranchID")]
    public int? CurrencyHistIModifiedBranchId { get; set; }

    [Column("CurrencyHist_iCreatedAgentID")]
    public int? CurrencyHistICreatedAgentId { get; set; }

    [Column("CurrencyHist_iModifiedAgentID")]
    public int? CurrencyHistIModifiedAgentId { get; set; }

    [Column("CurrencyHist_iChangeSetID")]
    public int? CurrencyHistIChangeSetId { get; set; }

    [Column("CurrencyHist_Checksum")]
    [MaxLength(20)]
    public byte[]? CurrencyHistChecksum { get; set; }
}
