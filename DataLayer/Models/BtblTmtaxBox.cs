using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblTMTaxBox")]
[Index("BtblTmtaxBoxChecksum", Name = "idx__btblTMTaxBox__btblTMTaxBox_Checksum")]
[Index("BtblTmtaxBoxIChangeSetId", Name = "idx__btblTMTaxBox_iChangeSetID")]
[Index("BtblTmtaxBoxDModifiedDate", Name = "idx_btblTMTaxBox_dModifiedDate")]
[Index("BtblTmtaxBoxIBranchId", Name = "idx_btblTMTaxBox_iBranchID")]
public partial class BtblTmtaxBox
{
    [Key]
    [Column("idTaxBox")]
    public int IdTaxBox { get; set; }

    [Column("cCode")]
    [StringLength(4)]
    [Unicode(false)]
    public string CCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("bTax")]
    public bool BTax { get; set; }

    [Column("bPayroll")]
    public bool BPayroll { get; set; }

    [Column("bWithHolding")]
    public bool BWithHolding { get; set; }

    [Column("iGLSign")]
    public int? IGlsign { get; set; }

    [Column("_btblTMTaxBox_iBranchID")]
    public int? BtblTmtaxBoxIBranchId { get; set; }

    [Column("_btblTMTaxBox_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblTmtaxBoxDCreatedDate { get; set; }

    [Column("_btblTMTaxBox_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblTmtaxBoxDModifiedDate { get; set; }

    [Column("_btblTMTaxBox_iCreatedBranchID")]
    public int? BtblTmtaxBoxICreatedBranchId { get; set; }

    [Column("_btblTMTaxBox_iModifiedBranchID")]
    public int? BtblTmtaxBoxIModifiedBranchId { get; set; }

    [Column("_btblTMTaxBox_iCreatedAgentID")]
    public int? BtblTmtaxBoxICreatedAgentId { get; set; }

    [Column("_btblTMTaxBox_iModifiedAgentID")]
    public int? BtblTmtaxBoxIModifiedAgentId { get; set; }

    [Column("_btblTMTaxBox_iChangeSetID")]
    public int? BtblTmtaxBoxIChangeSetId { get; set; }

    [Column("dStartDate", TypeName = "datetime")]
    public DateTime? DStartDate { get; set; }

    [Column("dEndDate", TypeName = "datetime")]
    public DateTime? DEndDate { get; set; }

    [Column("_btblTMTaxBox_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblTmtaxBoxChecksum { get; set; }
}
