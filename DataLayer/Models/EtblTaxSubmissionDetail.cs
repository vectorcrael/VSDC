using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblTaxSubmissionDetails")]
[Index("EtblTaxSubmissionDetailsChecksum", Name = "idx__etblTaxSubmissionDetails__etblTaxSubmissionDetails_Checksum")]
[Index("EtblTaxSubmissionDetailsDModifiedDate", Name = "idx__etblTaxSubmissionDetails__etblTaxSubmissionDetails_dModifiedDate")]
[Index("EtblTaxSubmissionDetailsIBranchId", Name = "idx__etblTaxSubmissionDetails__etblTaxSubmissionDetails_iBranchID")]
[Index("EtblTaxSubmissionDetailsIChangeSetId", Name = "idx__etblTaxSubmissionDetails__etblTaxSubmissionDetails_iChangeSetID")]
public partial class EtblTaxSubmissionDetail
{
    [Key]
    [Column("idTaxSubmissionDetails")]
    public int IdTaxSubmissionDetails { get; set; }

    [Column("cTaxCompanyName")]
    [StringLength(150)]
    [Unicode(false)]
    public string CTaxCompanyName { get; set; } = null!;

    [Column("cTaxCompanyRegistrationNo")]
    [StringLength(150)]
    [Unicode(false)]
    public string CTaxCompanyRegistrationNo { get; set; } = null!;

    [Column("cTaxRegistrationNo")]
    [StringLength(150)]
    [Unicode(false)]
    public string CTaxRegistrationNo { get; set; } = null!;

    [Column("iTaxGLPostingID")]
    public long ITaxGlpostingId { get; set; }

    [Column("_etblTaxSubmissionDetails_iBranchID")]
    public int? EtblTaxSubmissionDetailsIBranchId { get; set; }

    [Column("_etblTaxSubmissionDetails_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblTaxSubmissionDetailsDCreatedDate { get; set; }

    [Column("_etblTaxSubmissionDetails_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblTaxSubmissionDetailsDModifiedDate { get; set; }

    [Column("_etblTaxSubmissionDetails_iCreatedBranchID")]
    public int? EtblTaxSubmissionDetailsICreatedBranchId { get; set; }

    [Column("_etblTaxSubmissionDetails_iModifiedBranchID")]
    public int? EtblTaxSubmissionDetailsIModifiedBranchId { get; set; }

    [Column("_etblTaxSubmissionDetails_iCreatedAgentID")]
    public int? EtblTaxSubmissionDetailsICreatedAgentId { get; set; }

    [Column("_etblTaxSubmissionDetails_iModifiedAgentID")]
    public int? EtblTaxSubmissionDetailsIModifiedAgentId { get; set; }

    [Column("_etblTaxSubmissionDetails_iChangeSetID")]
    public int? EtblTaxSubmissionDetailsIChangeSetId { get; set; }

    [Column("_etblTaxSubmissionDetails_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblTaxSubmissionDetailsChecksum { get; set; }
}
