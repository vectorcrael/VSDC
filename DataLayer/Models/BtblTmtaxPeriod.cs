using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblTMTaxPeriod")]
[Index("BtblTmtaxPeriodChecksum", Name = "idx__btblTMTaxPeriod__btblTMTaxPeriod_Checksum")]
[Index("BtblTmtaxPeriodIChangeSetId", Name = "idx__btblTMTaxPeriod_iChangeSetID")]
[Index("BtblTmtaxPeriodDModifiedDate", Name = "idx_btblTMTaxPeriod_dModifiedDate")]
[Index("BtblTmtaxPeriodIBranchId", Name = "idx_btblTMTaxPeriod_iBranchID")]
public partial class BtblTmtaxPeriod
{
    [Key]
    [Column("idTaxPeriod")]
    public int IdTaxPeriod { get; set; }

    [Column("dStartDate", TypeName = "smalldatetime")]
    public DateTime DStartDate { get; set; }

    [Column("dEndDate", TypeName = "smalldatetime")]
    public DateTime DEndDate { get; set; }

    [Column("cDescription")]
    [StringLength(80)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("iYear")]
    public int IYear { get; set; }

    [Column("iPeriodNo")]
    public int IPeriodNo { get; set; }

    [Column("bWithHolding")]
    public bool BWithHolding { get; set; }

    [Column("bPayroll")]
    public bool BPayroll { get; set; }

    [Column("bTax")]
    public bool BTax { get; set; }

    [Column("bClosed")]
    public bool BClosed { get; set; }

    [Column("_btblTMTaxPeriod_iBranchID")]
    public int? BtblTmtaxPeriodIBranchId { get; set; }

    [Column("_btblTMTaxPeriod_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblTmtaxPeriodDCreatedDate { get; set; }

    [Column("_btblTMTaxPeriod_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblTmtaxPeriodDModifiedDate { get; set; }

    [Column("_btblTMTaxPeriod_iCreatedBranchID")]
    public int? BtblTmtaxPeriodICreatedBranchId { get; set; }

    [Column("_btblTMTaxPeriod_iModifiedBranchID")]
    public int? BtblTmtaxPeriodIModifiedBranchId { get; set; }

    [Column("_btblTMTaxPeriod_iCreatedAgentID")]
    public int? BtblTmtaxPeriodICreatedAgentId { get; set; }

    [Column("_btblTMTaxPeriod_iModifiedAgentID")]
    public int? BtblTmtaxPeriodIModifiedAgentId { get; set; }

    [Column("_btblTMTaxPeriod_iChangeSetID")]
    public int? BtblTmtaxPeriodIChangeSetId { get; set; }

    [Column("_btblTMTaxPeriod_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblTmtaxPeriodChecksum { get; set; }

    [Column("iTaxYearID")]
    public int ITaxYearId { get; set; }
}
