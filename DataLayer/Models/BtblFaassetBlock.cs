using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAAssetBlock")]
[Index("BtblFaassetBlockChecksum", Name = "idx__btblFAAssetBlock__btblFAAssetBlock_Checksum")]
[Index("BtblFaassetBlockIChangeSetId", Name = "idx__btblFAAssetBlock_iChangeSetID")]
[Index("BtblFaassetBlockDModifiedDate", Name = "idx_btblFAAssetBlock_dModifiedDate")]
[Index("BtblFaassetBlockIBranchId", Name = "idx_btblFAAssetBlock_iBranchID")]
public partial class BtblFaassetBlock
{
    [Key]
    [Column("idAssetBlockNo")]
    public int IdAssetBlockNo { get; set; }

    [Column("dFromDate", TypeName = "smalldatetime")]
    public DateTime? DFromDate { get; set; }

    [Column("dToDate", TypeName = "smalldatetime")]
    public DateTime? DToDate { get; set; }

    [Column("iAssetNo")]
    public int IAssetNo { get; set; }

    [Column("cAssetCode")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CAssetCode { get; set; }

    [Column("dTaxFromDate", TypeName = "smalldatetime")]
    public DateTime? DTaxFromDate { get; set; }

    [Column("dTaxToDate", TypeName = "smalldatetime")]
    public DateTime? DTaxToDate { get; set; }

    [Column("_btblFAAssetBlock_iBranchID")]
    public int? BtblFaassetBlockIBranchId { get; set; }

    [Column("_btblFAAssetBlock_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetBlockDCreatedDate { get; set; }

    [Column("_btblFAAssetBlock_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFaassetBlockDModifiedDate { get; set; }

    [Column("_btblFAAssetBlock_iCreatedBranchID")]
    public int? BtblFaassetBlockICreatedBranchId { get; set; }

    [Column("_btblFAAssetBlock_iModifiedBranchID")]
    public int? BtblFaassetBlockIModifiedBranchId { get; set; }

    [Column("_btblFAAssetBlock_iCreatedAgentID")]
    public int? BtblFaassetBlockICreatedAgentId { get; set; }

    [Column("_btblFAAssetBlock_iModifiedAgentID")]
    public int? BtblFaassetBlockIModifiedAgentId { get; set; }

    [Column("_btblFAAssetBlock_iChangeSetID")]
    public int? BtblFaassetBlockIChangeSetId { get; set; }

    [Column("_btblFAAssetBlock_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFaassetBlockChecksum { get; set; }
}
