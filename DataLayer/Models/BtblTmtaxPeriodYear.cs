using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblTMTaxPeriodYear")]
[Index("BtblTmtaxPeriodYearChecksum", Name = "idx__btblTMTaxPeriodYear__btblTMTaxPeriodYear_Checksum")]
[Index("BtblTmtaxPeriodYearDModifiedDate", Name = "idx__btblTMTaxPeriodYear__btblTMTaxPeriodYear_dModifiedDate")]
[Index("BtblTmtaxPeriodYearIBranchId", Name = "idx__btblTMTaxPeriodYear__btblTMTaxPeriodYear_iBranchID")]
[Index("BtblTmtaxPeriodYearIChangeSetId", Name = "idx__btblTMTaxPeriodYear__btblTMTaxPeriodYear_iChangeSetID")]
public partial class BtblTmtaxPeriodYear
{
    [Key]
    [Column("idTaxPeriodYear")]
    public int IdTaxPeriodYear { get; set; }

    [Column("cTaxYearDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string CTaxYearDescription { get; set; } = null!;

    [Column("dTaxYearEndDate", TypeName = "datetime")]
    public DateTime DTaxYearEndDate { get; set; }

    [Column("_btblTMTaxPeriodYear_iBranchID")]
    public int? BtblTmtaxPeriodYearIBranchId { get; set; }

    [Column("_btblTMTaxPeriodYear_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblTmtaxPeriodYearDCreatedDate { get; set; }

    [Column("_btblTMTaxPeriodYear_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblTmtaxPeriodYearDModifiedDate { get; set; }

    [Column("_btblTMTaxPeriodYear_iCreatedBranchID")]
    public int? BtblTmtaxPeriodYearICreatedBranchId { get; set; }

    [Column("_btblTMTaxPeriodYear_iModifiedBranchID")]
    public int? BtblTmtaxPeriodYearIModifiedBranchId { get; set; }

    [Column("_btblTMTaxPeriodYear_iCreatedAgentID")]
    public int? BtblTmtaxPeriodYearICreatedAgentId { get; set; }

    [Column("_btblTMTaxPeriodYear_iModifiedAgentID")]
    public int? BtblTmtaxPeriodYearIModifiedAgentId { get; set; }

    [Column("_btblTMTaxPeriodYear_iChangeSetID")]
    public int? BtblTmtaxPeriodYearIChangeSetId { get; set; }

    [Column("_btblTMTaxPeriodYear_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblTmtaxPeriodYearChecksum { get; set; }

    [Column("iTaxPeriodFrequency")]
    public int ITaxPeriodFrequency { get; set; }
}
