using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblPOSXZTable")]
[Index("BtblPosxztableChecksum", Name = "idx__btblPOSXZTable__btblPOSXZTable_Checksum")]
[Index("BtblPosxztableIChangeSetId", Name = "idx__btblPOSXZTable_iChangeSetID")]
[Index("BtblPosxztableDModifiedDate", Name = "idx_btblPOSXZTable_dModifiedDate")]
[Index("BtblPosxztableIBranchId", Name = "idx_btblPOSXZTable_iBranchID")]
public partial class BtblPosxztable
{
    [Key]
    [Column("IDPOSXZTable")]
    public int Idposxztable { get; set; }

    [Column("dTranDate", TypeName = "datetime")]
    public DateTime? DTranDate { get; set; }

    [Column("iTillTxType")]
    public int? ITillTxType { get; set; }

    [Column("iTillsID")]
    public int? ITillsId { get; set; }

    [Column("iAgentsID")]
    public int? IAgentsId { get; set; }

    [Column("iTrCodesID")]
    public int? ITrCodesId { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("cXZAuditNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CXzauditNumber { get; set; }

    [Column("fAmtTendered")]
    public double? FAmtTendered { get; set; }

    [Column("fTranAmount")]
    public double? FTranAmount { get; set; }

    [Column("fChange")]
    public double? FChange { get; set; }

    [Column("_btblPOSXZTable_iBranchID")]
    public int? BtblPosxztableIBranchId { get; set; }

    [Column("_btblPOSXZTable_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblPosxztableDCreatedDate { get; set; }

    [Column("_btblPOSXZTable_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblPosxztableDModifiedDate { get; set; }

    [Column("_btblPOSXZTable_iCreatedBranchID")]
    public int? BtblPosxztableICreatedBranchId { get; set; }

    [Column("_btblPOSXZTable_iModifiedBranchID")]
    public int? BtblPosxztableIModifiedBranchId { get; set; }

    [Column("_btblPOSXZTable_iCreatedAgentID")]
    public int? BtblPosxztableICreatedAgentId { get; set; }

    [Column("_btblPOSXZTable_iModifiedAgentID")]
    public int? BtblPosxztableIModifiedAgentId { get; set; }

    [Column("_btblPOSXZTable_iChangeSetID")]
    public int? BtblPosxztableIChangeSetId { get; set; }

    [Column("_btblPOSXZTable_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblPosxztableChecksum { get; set; }
}
