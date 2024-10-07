using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblTMTaxTotals")]
[Index("BtblTmtaxTotalsChecksum", Name = "idx__btblTMTaxTotals__btblTMTaxTotals_Checksum")]
[Index("BtblTmtaxTotalsIChangeSetId", Name = "idx__btblTMTaxTotals_iChangeSetID")]
[Index("BtblTmtaxTotalsDModifiedDate", Name = "idx_btblTMTaxTotals_dModifiedDate")]
[Index("BtblTmtaxTotalsIBranchId", Name = "idx_btblTMTaxTotals_iBranchID")]
public partial class BtblTmtaxTotal
{
    [Key]
    [Column("idTaxTotals")]
    public int IdTaxTotals { get; set; }

    [Column("fTotal")]
    public double FTotal { get; set; }

    [Column("iTaxPeriodID")]
    public int ITaxPeriodId { get; set; }

    [Column("iTaxBoxID")]
    public int ITaxBoxId { get; set; }

    [Column("_btblTMTaxTotals_iBranchID")]
    public int? BtblTmtaxTotalsIBranchId { get; set; }

    [Column("_btblTMTaxTotals_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblTmtaxTotalsDCreatedDate { get; set; }

    [Column("_btblTMTaxTotals_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblTmtaxTotalsDModifiedDate { get; set; }

    [Column("_btblTMTaxTotals_iCreatedBranchID")]
    public int? BtblTmtaxTotalsICreatedBranchId { get; set; }

    [Column("_btblTMTaxTotals_iModifiedBranchID")]
    public int? BtblTmtaxTotalsIModifiedBranchId { get; set; }

    [Column("_btblTMTaxTotals_iCreatedAgentID")]
    public int? BtblTmtaxTotalsICreatedAgentId { get; set; }

    [Column("_btblTMTaxTotals_iModifiedAgentID")]
    public int? BtblTmtaxTotalsIModifiedAgentId { get; set; }

    [Column("_btblTMTaxTotals_iChangeSetID")]
    public int? BtblTmtaxTotalsIChangeSetId { get; set; }

    [Column("_btblTMTaxTotals_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblTmtaxTotalsChecksum { get; set; }
}
