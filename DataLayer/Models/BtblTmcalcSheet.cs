using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblTMCalcSheet")]
[Index("BtblTmcalcSheetChecksum", Name = "idx__btblTMCalcSheet__btblTMCalcSheet_Checksum")]
[Index("BtblTmcalcSheetIChangeSetId", Name = "idx__btblTMCalcSheet_iChangeSetID")]
[Index("BtblTmcalcSheetDModifiedDate", Name = "idx_btblTMCalcSheet_dModifiedDate")]
[Index("BtblTmcalcSheetIBranchId", Name = "idx_btblTMCalcSheet_iBranchID")]
public partial class BtblTmcalcSheet
{
    [Key]
    [Column("idCalcSheet")]
    public int IdCalcSheet { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("cOperation")]
    [StringLength(1)]
    [Unicode(false)]
    public string COperation { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("bEditable")]
    public bool BEditable { get; set; }

    [Column("iTaxBoxID")]
    public int? ITaxBoxId { get; set; }

    [Column("iTaxBoxDestID")]
    public int ITaxBoxDestId { get; set; }

    [Column("iOrder")]
    public int IOrder { get; set; }

    [Column("fValue")]
    public double? FValue { get; set; }

    [Column("bDirect")]
    public bool BDirect { get; set; }

    [Column("_btblTMCalcSheet_iBranchID")]
    public int? BtblTmcalcSheetIBranchId { get; set; }

    [Column("_btblTMCalcSheet_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblTmcalcSheetDCreatedDate { get; set; }

    [Column("_btblTMCalcSheet_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblTmcalcSheetDModifiedDate { get; set; }

    [Column("_btblTMCalcSheet_iCreatedBranchID")]
    public int? BtblTmcalcSheetICreatedBranchId { get; set; }

    [Column("_btblTMCalcSheet_iModifiedBranchID")]
    public int? BtblTmcalcSheetIModifiedBranchId { get; set; }

    [Column("_btblTMCalcSheet_iCreatedAgentID")]
    public int? BtblTmcalcSheetICreatedAgentId { get; set; }

    [Column("_btblTMCalcSheet_iModifiedAgentID")]
    public int? BtblTmcalcSheetIModifiedAgentId { get; set; }

    [Column("_btblTMCalcSheet_iChangeSetID")]
    public int? BtblTmcalcSheetIChangeSetId { get; set; }

    [Column("fTaxRate")]
    public double? FTaxRate { get; set; }

    [Column("dStartDate", TypeName = "datetime")]
    public DateTime? DStartDate { get; set; }

    [Column("dEndDate", TypeName = "datetime")]
    public DateTime? DEndDate { get; set; }

    [Column("_btblTMCalcSheet_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblTmcalcSheetChecksum { get; set; }
}
