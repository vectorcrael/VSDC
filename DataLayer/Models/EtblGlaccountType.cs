using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLAccountTypes")]
[Index("EtblGlaccountTypesChecksum", Name = "idx__etblGLAccountTypes__etblGLAccountTypes_Checksum")]
[Index("EtblGlaccountTypesDModifiedDate", Name = "idx__etblGLAccountTypes__etblGLAccountTypes_dModifiedDate")]
[Index("EtblGlaccountTypesIBranchId", Name = "idx__etblGLAccountTypes__etblGLAccountTypes_iBranchID")]
[Index("EtblGlaccountTypesIChangeSetId", Name = "idx__etblGLAccountTypes__etblGLAccountTypes_iChangeSetID")]
public partial class EtblGlaccountType
{
    [Column("cAccountTypeDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string CAccountTypeDescription { get; set; } = null!;

    [Key]
    [Column("idGLAccountType")]
    public int IdGlaccountType { get; set; }

    [Column("bIsBalanceSheet")]
    public bool BIsBalanceSheet { get; set; }

    [Column("iReportingGroup")]
    public int IReportingGroup { get; set; }

    [Column("iReportingGroupSort")]
    public int IReportingGroupSort { get; set; }

    [Column("bDualPrinting")]
    public bool BDualPrinting { get; set; }

    [Column("_etblGLAccountTypes_iBranchID")]
    public int? EtblGlaccountTypesIBranchId { get; set; }

    [Column("_etblGLAccountTypes_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlaccountTypesDCreatedDate { get; set; }

    [Column("_etblGLAccountTypes_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlaccountTypesDModifiedDate { get; set; }

    [Column("_etblGLAccountTypes_iCreatedBranchID")]
    public int? EtblGlaccountTypesICreatedBranchId { get; set; }

    [Column("_etblGLAccountTypes_iModifiedBranchID")]
    public int? EtblGlaccountTypesIModifiedBranchId { get; set; }

    [Column("_etblGLAccountTypes_iCreatedAgentID")]
    public int? EtblGlaccountTypesICreatedAgentId { get; set; }

    [Column("_etblGLAccountTypes_iModifiedAgentID")]
    public int? EtblGlaccountTypesIModifiedAgentId { get; set; }

    [Column("_etblGLAccountTypes_iChangeSetID")]
    public int? EtblGlaccountTypesIChangeSetId { get; set; }

    [Column("_etblGLAccountTypes_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlaccountTypesChecksum { get; set; }

    [Column("bIsDebit")]
    public bool BIsDebit { get; set; }
}
