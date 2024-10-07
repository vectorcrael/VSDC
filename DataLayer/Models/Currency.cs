using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("Currency")]
[Index("CurrencyDModifiedDate", Name = "idxCurrency_dModifiedDate")]
[Index("CurrencyIBranchId", Name = "idxCurrency_iBranchID")]
[Index("CurrencyChecksum", Name = "idx_Currency_Currency_Checksum")]
[Index("CurrencyIChangeSetId", Name = "idx_Currency_iChangeSetID")]
public partial class Currency
{
    [Key]
    public int CurrencyLink { get; set; }

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
