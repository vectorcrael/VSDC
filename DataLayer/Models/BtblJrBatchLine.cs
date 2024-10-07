using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblJrBatchLines")]
[Index("BtblJrBatchLinesChecksum", Name = "idx__btblJrBatchLines__btblJrBatchLines_Checksum")]
[Index("BtblJrBatchLinesIChangeSetId", Name = "idx__btblJrBatchLines_iChangeSetID")]
[Index("BtblJrBatchLinesDModifiedDate", Name = "idx_btblJrBatchLines_dModifiedDate")]
[Index("BtblJrBatchLinesIBranchId", Name = "idx_btblJrBatchLines_iBranchID")]
public partial class BtblJrBatchLine
{
    [Key]
    [Column("idBatchLines")]
    public int IdBatchLines { get; set; }

    [Column("iBatchesID")]
    public int IBatchesId { get; set; }

    [Column("dTxDate", TypeName = "smalldatetime")]
    public DateTime? DTxDate { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("fDebit")]
    public double? FDebit { get; set; }

    [Column("fCredit")]
    public double? FCredit { get; set; }

    [Column("fTaxAmount")]
    public double? FTaxAmount { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("iTaxAccountID")]
    public int? ITaxAccountId { get; set; }

    [Column("iProjectID")]
    public int? IProjectId { get; set; }

    [Column("bAccrual")]
    public bool? BAccrual { get; set; }

    [Column("_btblJrBatchLines_iBranchID")]
    public int? BtblJrBatchLinesIBranchId { get; set; }

    [Column("_btblJrBatchLines_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblJrBatchLinesDCreatedDate { get; set; }

    [Column("_btblJrBatchLines_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblJrBatchLinesDModifiedDate { get; set; }

    [Column("_btblJrBatchLines_iCreatedBranchID")]
    public int? BtblJrBatchLinesICreatedBranchId { get; set; }

    [Column("_btblJrBatchLines_iModifiedBranchID")]
    public int? BtblJrBatchLinesIModifiedBranchId { get; set; }

    [Column("_btblJrBatchLines_iCreatedAgentID")]
    public int? BtblJrBatchLinesICreatedAgentId { get; set; }

    [Column("_btblJrBatchLines_iModifiedAgentID")]
    public int? BtblJrBatchLinesIModifiedAgentId { get; set; }

    [Column("_btblJrBatchLines_iChangeSetID")]
    public int? BtblJrBatchLinesIChangeSetId { get; set; }

    [Column("_btblJrBatchLines_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblJrBatchLinesChecksum { get; set; }

    [Column("iFCAccCurrencyID")]
    public int IFcaccCurrencyId { get; set; }

    [Column("fExchangeRate")]
    public double FExchangeRate { get; set; }

    [Column("fDebitForeign")]
    public double FDebitForeign { get; set; }

    [Column("fCreditForeign")]
    public double FCreditForeign { get; set; }

    [Column("fTaxAmountForeign")]
    public double FTaxAmountForeign { get; set; }

    [Column("cTaxCompanyName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CTaxCompanyName { get; set; }

    [Column("cTaxCompanyRegistration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxCompanyRegistration { get; set; }

    [Column("cTaxRegistration")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CTaxRegistration { get; set; }
}
