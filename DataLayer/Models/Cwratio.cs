using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CWRatio")]
[Index("CwratioDModifiedDate", Name = "idxCWRatio_dModifiedDate")]
[Index("CwratioIBranchId", Name = "idxCWRatio_iBranchID")]
[Index("CwratioChecksum", Name = "idx_CWRatio_CWRatio_Checksum")]
[Index("CwratioIChangeSetId", Name = "idx_CWRatio_iChangeSetID")]
public partial class Cwratio
{
    [Key]
    [Column("idCwRatio")]
    public int IdCwRatio { get; set; }

    [Column("CWNextMstAccount")]
    public int? CwnextMstAccount { get; set; }

    [Column("CWRatio_iBranchID")]
    public int? CwratioIBranchId { get; set; }

    [Column("CWRatio_dCreatedDate", TypeName = "datetime")]
    public DateTime? CwratioDCreatedDate { get; set; }

    [Column("CWRatio_dModifiedDate", TypeName = "datetime")]
    public DateTime? CwratioDModifiedDate { get; set; }

    [Column("CWRatio_iCreatedBranchID")]
    public int? CwratioICreatedBranchId { get; set; }

    [Column("CWRatio_iModifiedBranchID")]
    public int? CwratioIModifiedBranchId { get; set; }

    [Column("CWRatio_iCreatedAgentID")]
    public int? CwratioICreatedAgentId { get; set; }

    [Column("CWRatio_iModifiedAgentID")]
    public int? CwratioIModifiedAgentId { get; set; }

    [Column("CWRatio_iChangeSetID")]
    public int? CwratioIChangeSetId { get; set; }

    [Column("iCWRatioAccountType")]
    public int ICwratioAccountType { get; set; }

    [Column("CWRatio_Checksum")]
    [MaxLength(20)]
    public byte[]? CwratioChecksum { get; set; }
}
