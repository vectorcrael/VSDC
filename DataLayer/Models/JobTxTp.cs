using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("JobTxTp")]
[Index("JobTxTpDModifiedDate", Name = "idxJobTxTp_dModifiedDate")]
[Index("JobTxTpIBranchId", Name = "idxJobTxTp_iBranchID")]
[Index("JobTxTpChecksum", Name = "idx_JobTxTp_JobTxTp_Checksum")]
[Index("JobTxTpIChangeSetId", Name = "idx_JobTxTp_iChangeSetID")]
public partial class JobTxTp
{
    [Key]
    [Column("idJobTxTp")]
    public int IdJobTxTp { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TxType { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Source { get; set; }

    public double? OverheadPercent { get; set; }

    [Column("M1WIPLink")]
    public int? M1wiplink { get; set; }

    [Column("M1RecoveryLink")]
    public int? M1recoveryLink { get; set; }

    [Column("M1StockLink")]
    public int? M1stockLink { get; set; }

    [Column("M1CreditorLink")]
    public int? M1creditorLink { get; set; }

    [Column("M1TaxLink")]
    public int? M1taxLink { get; set; }

    [Column("M1SalesLink")]
    public int? M1salesLink { get; set; }

    [Column("M1COSLink")]
    public int? M1coslink { get; set; }

    [Column("M1DebtorLink")]
    public int? M1debtorLink { get; set; }

    [Column("M2WIPLink")]
    public int? M2wiplink { get; set; }

    [Column("M2RecoveryLink")]
    public int? M2recoveryLink { get; set; }

    [Column("M2StockLink")]
    public int? M2stockLink { get; set; }

    [Column("M2CreditorLink")]
    public int? M2creditorLink { get; set; }

    [Column("M2TaxLink")]
    public int? M2taxLink { get; set; }

    [Column("M2SalesLink")]
    public int? M2salesLink { get; set; }

    [Column("M2COSLink")]
    public int? M2coslink { get; set; }

    [Column("M2DebtorLink")]
    public int? M2debtorLink { get; set; }

    [Column("iTaxTypeIDInv")]
    public int? ITaxTypeIdinv { get; set; }

    [Column("iTaxTypeIDGrv")]
    public int? ITaxTypeIdgrv { get; set; }

    [Column("bSalesFilter")]
    public bool BSalesFilter { get; set; }

    [Column("JobTxTp_iBranchID")]
    public int? JobTxTpIBranchId { get; set; }

    [Column("JobTxTp_dCreatedDate", TypeName = "datetime")]
    public DateTime? JobTxTpDCreatedDate { get; set; }

    [Column("JobTxTp_dModifiedDate", TypeName = "datetime")]
    public DateTime? JobTxTpDModifiedDate { get; set; }

    [Column("JobTxTp_iCreatedBranchID")]
    public int? JobTxTpICreatedBranchId { get; set; }

    [Column("JobTxTp_iModifiedBranchID")]
    public int? JobTxTpIModifiedBranchId { get; set; }

    [Column("JobTxTp_iCreatedAgentID")]
    public int? JobTxTpICreatedAgentId { get; set; }

    [Column("JobTxTp_iModifiedAgentID")]
    public int? JobTxTpIModifiedAgentId { get; set; }

    [Column("JobTxTp_iChangeSetID")]
    public int? JobTxTpIChangeSetId { get; set; }

    [Column("iSellingTaxGroupID")]
    public int? ISellingTaxGroupId { get; set; }

    [Column("iCostTaxGroupID")]
    public int? ICostTaxGroupId { get; set; }

    [Column("JobTxTp_Checksum")]
    [MaxLength(20)]
    public byte[]? JobTxTpChecksum { get; set; }
}
