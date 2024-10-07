using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFADepreciationYear")]
[Index("BtblFadepreciationYearChecksum", Name = "idx__btblFADepreciationYear__btblFADepreciationYear_Checksum")]
[Index("BtblFadepreciationYearIChangeSetId", Name = "idx__btblFADepreciationYear_iChangeSetID")]
[Index("BtblFadepreciationYearDModifiedDate", Name = "idx_btblFADepreciationYear_dModifiedDate")]
[Index("BtblFadepreciationYearIBranchId", Name = "idx_btblFADepreciationYear_iBranchID")]
public partial class BtblFadepreciationYear
{
    [Key]
    [Column("idDepreciationYearNo")]
    public int IdDepreciationYearNo { get; set; }

    [Column("iYearNo")]
    public int IYearNo { get; set; }

    [Column("fPercentage")]
    public double FPercentage { get; set; }

    [Column("iDepreciationNo")]
    public int IDepreciationNo { get; set; }

    [Column("_btblFADepreciationYear_iBranchID")]
    public int? BtblFadepreciationYearIBranchId { get; set; }

    [Column("_btblFADepreciationYear_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFadepreciationYearDCreatedDate { get; set; }

    [Column("_btblFADepreciationYear_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFadepreciationYearDModifiedDate { get; set; }

    [Column("_btblFADepreciationYear_iCreatedBranchID")]
    public int? BtblFadepreciationYearICreatedBranchId { get; set; }

    [Column("_btblFADepreciationYear_iModifiedBranchID")]
    public int? BtblFadepreciationYearIModifiedBranchId { get; set; }

    [Column("_btblFADepreciationYear_iCreatedAgentID")]
    public int? BtblFadepreciationYearICreatedAgentId { get; set; }

    [Column("_btblFADepreciationYear_iModifiedAgentID")]
    public int? BtblFadepreciationYearIModifiedAgentId { get; set; }

    [Column("_btblFADepreciationYear_iChangeSetID")]
    public int? BtblFadepreciationYearIChangeSetId { get; set; }

    [Column("_btblFADepreciationYear_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFadepreciationYearChecksum { get; set; }
}
