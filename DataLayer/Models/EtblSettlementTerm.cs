using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSettlementTerms")]
[Index("EtblSettlementTermsChecksum", Name = "idx__etblSettlementTerms__etblSettlementTerms_Checksum")]
[Index("EtblSettlementTermsIChangeSetId", Name = "idx__etblSettlementTerms_iChangeSetID")]
[Index("EtblSettlementTermsDModifiedDate", Name = "idx_etblSettlementTerms_dModifiedDate")]
[Index("EtblSettlementTermsIBranchId", Name = "idx_etblSettlementTerms_iBranchID")]
public partial class EtblSettlementTerm
{
    [Key]
    [Column("idSettlementTerms")]
    public int IdSettlementTerms { get; set; }

    [Column("cSettlementCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string CSettlementCode { get; set; } = null!;

    [Column("cSettlementDescription")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CSettlementDescription { get; set; }

    [Column("iPaymentMethod")]
    public int? IPaymentMethod { get; set; }

    [Column("iSettlementDays")]
    public int? ISettlementDays { get; set; }

    [Column("fSettlementDisc")]
    public double FSettlementDisc { get; set; }

    [Column("cInvMessage")]
    [StringLength(255)]
    [Unicode(false)]
    public string? CInvMessage { get; set; }

    [Column("_etblSettlementTerms_iBranchID")]
    public int? EtblSettlementTermsIBranchId { get; set; }

    [Column("_etblSettlementTerms_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblSettlementTermsDCreatedDate { get; set; }

    [Column("_etblSettlementTerms_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblSettlementTermsDModifiedDate { get; set; }

    [Column("_etblSettlementTerms_iCreatedBranchID")]
    public int? EtblSettlementTermsICreatedBranchId { get; set; }

    [Column("_etblSettlementTerms_iModifiedBranchID")]
    public int? EtblSettlementTermsIModifiedBranchId { get; set; }

    [Column("_etblSettlementTerms_iCreatedAgentID")]
    public int? EtblSettlementTermsICreatedAgentId { get; set; }

    [Column("_etblSettlementTerms_iModifiedAgentID")]
    public int? EtblSettlementTermsIModifiedAgentId { get; set; }

    [Column("_etblSettlementTerms_iChangeSetID")]
    public int? EtblSettlementTermsIChangeSetId { get; set; }

    [Column("_etblSettlementTerms_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblSettlementTermsChecksum { get; set; }
}
