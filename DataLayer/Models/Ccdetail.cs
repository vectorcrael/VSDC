using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CCDetail")]
[Index("CcdetailDModifiedDate", Name = "idxCCDetail_dModifiedDate")]
[Index("CcdetailIBranchId", Name = "idxCCDetail_iBranchID")]
[Index("CcdetailChecksum", Name = "idx_CCDetail_CCDetail_Checksum")]
[Index("CcdetailIChangeSetId", Name = "idx_CCDetail_iChangeSetID")]
public partial class Ccdetail
{
    [Key]
    public int DebtorLink { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? TradeName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TypeofBus { get; set; }

    public double? MonthlyPur { get; set; }

    public bool? Granted { get; set; }

    public short? BankCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankContact { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? BankDate { get; set; }

    public double? BankAmount { get; set; }

    [Column("BankRD")]
    public bool? BankRd { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DateBusStart { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LastCredGrant { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LastCredDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AuditorName { get; set; }

    [Column("CCDetail_iBranchID")]
    public int? CcdetailIBranchId { get; set; }

    [Column("CCDetail_dCreatedDate", TypeName = "datetime")]
    public DateTime? CcdetailDCreatedDate { get; set; }

    [Column("CCDetail_dModifiedDate", TypeName = "datetime")]
    public DateTime? CcdetailDModifiedDate { get; set; }

    [Column("CCDetail_iCreatedBranchID")]
    public int? CcdetailICreatedBranchId { get; set; }

    [Column("CCDetail_iModifiedBranchID")]
    public int? CcdetailIModifiedBranchId { get; set; }

    [Column("CCDetail_iCreatedAgentID")]
    public int? CcdetailICreatedAgentId { get; set; }

    [Column("CCDetail_iModifiedAgentID")]
    public int? CcdetailIModifiedAgentId { get; set; }

    [Column("CCDetail_iChangeSetID")]
    public int? CcdetailIChangeSetId { get; set; }

    [Column("CCDetail_Checksum")]
    [MaxLength(20)]
    public byte[]? CcdetailChecksum { get; set; }
}
