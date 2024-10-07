using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblImportDeclarationLine")]
[Index("EtblImportDeclarationLineChecksum", Name = "idx__etblImportDeclarationLine__etblImportDeclarationLine_Checksum")]
[Index("EtblImportDeclarationLineDModifiedDate", Name = "idx__etblImportDeclarationLine__etblImportDeclarationLine_dModifiedDate")]
[Index("EtblImportDeclarationLineIBranchId", Name = "idx__etblImportDeclarationLine__etblImportDeclarationLine_iBranchID")]
[Index("EtblImportDeclarationLineIChangeSetId", Name = "idx__etblImportDeclarationLine__etblImportDeclarationLine_iChangeSetID")]
public partial class EtblImportDeclarationLine
{
    [Key]
    [Column("idImportDeclarationLine")]
    public int IdImportDeclarationLine { get; set; }

    [Column("iImportDeclarationID")]
    public int IImportDeclarationId { get; set; }

    [Column("iImportDeclItemID")]
    public int IImportDeclItemId { get; set; }

    [Column("fTotalAmount")]
    public double? FTotalAmount { get; set; }

    [Column("fForeignTotalAmount")]
    public double? FForeignTotalAmount { get; set; }

    [Column("fExRate")]
    public double? FExRate { get; set; }

    [Column("cCostItemDesc")]
    [StringLength(50)]
    public string? CCostItemDesc { get; set; }

    [Column("cRemarks")]
    [StringLength(100)]
    public string? CRemarks { get; set; }

    [Column("_etblImportDeclarationLine_iBranchID")]
    public int? EtblImportDeclarationLineIBranchId { get; set; }

    [Column("_etblImportDeclarationLine_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblImportDeclarationLineDCreatedDate { get; set; }

    [Column("_etblImportDeclarationLine_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblImportDeclarationLineDModifiedDate { get; set; }

    [Column("_etblImportDeclarationLine_iCreatedBranchID")]
    public int? EtblImportDeclarationLineICreatedBranchId { get; set; }

    [Column("_etblImportDeclarationLine_iModifiedBranchID")]
    public int? EtblImportDeclarationLineIModifiedBranchId { get; set; }

    [Column("_etblImportDeclarationLine_iCreatedAgentID")]
    public int? EtblImportDeclarationLineICreatedAgentId { get; set; }

    [Column("_etblImportDeclarationLine_iModifiedAgentID")]
    public int? EtblImportDeclarationLineIModifiedAgentId { get; set; }

    [Column("_etblImportDeclarationLine_iChangeSetID")]
    public int? EtblImportDeclarationLineIChangeSetId { get; set; }

    [Column("_etblImportDeclarationLine_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblImportDeclarationLineChecksum { get; set; }

    [Column("iAccountLinkID")]
    public int IAccountLinkId { get; set; }
}
