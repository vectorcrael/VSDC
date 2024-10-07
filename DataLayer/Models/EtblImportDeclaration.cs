using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblImportDeclaration")]
[Index("EtblImportDeclarationChecksum", Name = "idx__etblImportDeclaration__etblImportDeclaration_Checksum")]
[Index("EtblImportDeclarationDModifiedDate", Name = "idx__etblImportDeclaration__etblImportDeclaration_dModifiedDate")]
[Index("EtblImportDeclarationIBranchId", Name = "idx__etblImportDeclaration__etblImportDeclaration_iBranchID")]
[Index("EtblImportDeclarationIChangeSetId", Name = "idx__etblImportDeclaration__etblImportDeclaration_iChangeSetID")]
public partial class EtblImportDeclaration
{
    [Key]
    [Column("idImportDeclaration")]
    public int IdImportDeclaration { get; set; }

    [Column("cImportDeclarationNo")]
    [StringLength(50)]
    public string CImportDeclarationNo { get; set; } = null!;

    [Column("cImportDeclarationShipNo")]
    [StringLength(50)]
    public string CImportDeclarationShipNo { get; set; } = null!;

    [Column("dImpDate", TypeName = "datetime")]
    public DateTime DImpDate { get; set; }

    [Column("iVendorID")]
    public int IVendorId { get; set; }

    [Column("iCurrencyID")]
    public int ICurrencyId { get; set; }

    [Column("cPurchDescr")]
    [StringLength(100)]
    public string? CPurchDescr { get; set; }

    [Column("cInvList", TypeName = "text")]
    public string CInvList { get; set; } = null!;

    [Column("fTotalAmount")]
    public double? FTotalAmount { get; set; }

    [Column("fForeignTotalAmount")]
    public double? FForeignTotalAmount { get; set; }

    [Column("fExRate")]
    public double? FExRate { get; set; }

    [Column("fGSTAmount")]
    public double? FGstamount { get; set; }

    [Column("iTaxCodeID")]
    public int ITaxCodeId { get; set; }

    [Column("iTaxRate")]
    public double? ITaxRate { get; set; }

    [Column("fTaxAmount")]
    public double? FTaxAmount { get; set; }

    [Column("iDocStatus")]
    public int? IDocStatus { get; set; }

    [Column("_etblImportDeclaration_iBranchID")]
    public int? EtblImportDeclarationIBranchId { get; set; }

    [Column("_etblImportDeclaration_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblImportDeclarationDCreatedDate { get; set; }

    [Column("_etblImportDeclaration_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblImportDeclarationDModifiedDate { get; set; }

    [Column("_etblImportDeclaration_iCreatedBranchID")]
    public int? EtblImportDeclarationICreatedBranchId { get; set; }

    [Column("_etblImportDeclaration_iModifiedBranchID")]
    public int? EtblImportDeclarationIModifiedBranchId { get; set; }

    [Column("_etblImportDeclaration_iCreatedAgentID")]
    public int? EtblImportDeclarationICreatedAgentId { get; set; }

    [Column("_etblImportDeclaration_iModifiedAgentID")]
    public int? EtblImportDeclarationIModifiedAgentId { get; set; }

    [Column("_etblImportDeclaration_iChangeSetID")]
    public int? EtblImportDeclarationIChangeSetId { get; set; }

    [Column("_etblImportDeclaration_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblImportDeclarationChecksum { get; set; }

    [Column("cAuditNumber")]
    [StringLength(50)]
    public string? CAuditNumber { get; set; }

    [Column("iForAgentID")]
    public int IForAgentId { get; set; }

    [Column("cReversalReason")]
    [StringLength(100)]
    public string? CReversalReason { get; set; }

    [Column("dReversalDate", TypeName = "datetime")]
    public DateTime? DReversalDate { get; set; }

    [Column("cReversalAuditNumber")]
    [StringLength(50)]
    public string? CReversalAuditNumber { get; set; }

    [Column("iInvNumID")]
    public long IInvNumId { get; set; }
}
