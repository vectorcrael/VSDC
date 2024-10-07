using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAAssetType")]
[Index("BtblFaassetTypeChecksum", Name = "idx__btblFAAssetType__btblFAAssetType_Checksum")]
[Index("BtblFaassetTypeIChangeSetId", Name = "idx__btblFAAssetType_iChangeSetID")]
[Index("BtblFaassetTypeDModifiedDate", Name = "idx_btblFAAssetType_dModifiedDate")]
[Index("BtblFaassetTypeIBranchId", Name = "idx_btblFAAssetType_iBranchID")]
public partial class BtblFaassetType
{
    [Key]
    [Column("idAssetTypeNo")]
    public int IdAssetTypeNo { get; set; }

    [Column("cAssetTypeCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string CAssetTypeCode { get; set; } = null!;

    [Column("cAssetTypeDesc")]
    [StringLength(80)]
    [Unicode(false)]
    public string CAssetTypeDesc { get; set; } = null!;

    [Column("iDepreciationNo")]
    public int IDepreciationNo { get; set; }

    [Column("iTaxDepreciationNo")]
    public int ITaxDepreciationNo { get; set; }

    [Column("fRevaluationIndex")]
    public double FRevaluationIndex { get; set; }

    [Column("fInsuranceIndex")]
    public double FInsuranceIndex { get; set; }

    [Column("iGLAccountNo")]
    public int? IGlaccountNo { get; set; }

    [Column("fInsuranceCostFactor")]
    public double FInsuranceCostFactor { get; set; }

    [Column("fResidualFactor")]
    public double FResidualFactor { get; set; }

    [Column("iCreditGLAccountID")]
    public int? ICreditGlaccountId { get; set; }

    [Column("iAssetGLAccountID")]
    public int? IAssetGlaccountId { get; set; }

    [Column("_btblFAAssetType_iBranchID")]
    public int? BtblFaassetTypeIBranchId { get; set; }

    [Column("_btblFAAssetType_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetTypeDCreatedDate { get; set; }

    [Column("_btblFAAssetType_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetTypeDModifiedDate { get; set; }

    [Column("_btblFAAssetType_iCreatedBranchID")]
    public int? BtblFaassetTypeICreatedBranchId { get; set; }

    [Column("_btblFAAssetType_iModifiedBranchID")]
    public int? BtblFaassetTypeIModifiedBranchId { get; set; }

    [Column("_btblFAAssetType_iCreatedAgentID")]
    public int? BtblFaassetTypeICreatedAgentId { get; set; }

    [Column("_btblFAAssetType_iModifiedAgentID")]
    public int? BtblFaassetTypeIModifiedAgentId { get; set; }

    [Column("_btblFAAssetType_iChangeSetID")]
    public int? BtblFaassetTypeIChangeSetId { get; set; }

    [Column("_btblFAAssetType_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaassetTypeChecksum { get; set; }
}
