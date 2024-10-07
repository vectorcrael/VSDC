using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
[Table("RecurRDef")]
[Index("RecurRdefDModifiedDate", Name = "idxRecurRDef_dModifiedDate")]
[Index("RecurRdefIBranchId", Name = "idxRecurRDef_iBranchID")]
[Index("RecurRdefChecksum", Name = "idx_RecurRDef_RecurRDef_Checksum")]
[Index("RecurRdefIChangeSetId", Name = "idx_RecurRDef_iChangeSetID")]
public partial class RecurRdef
{
    [Column("idRecurrDef")]
    public int IdRecurrDef { get; set; }

    [Column("iRRAgentID")]
    public int? IRragentId { get; set; }

    [Column("iDCModule")]
    public int? IDcmodule { get; set; }

    [Column("iPromptOpt")]
    public int? IPromptOpt { get; set; }

    [Column("dLastPrompt", TypeName = "datetime")]
    public DateTime? DLastPrompt { get; set; }

    [Column("bAlwaysLoad")]
    public bool BAlwaysLoad { get; set; }

    [Column("bAutoReference")]
    public bool BAutoReference { get; set; }

    [Column("vReferencePrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? VReferencePrefix { get; set; }

    [Column("iReferenceNext")]
    public int? IReferenceNext { get; set; }

    [Column("iReferencePadLength")]
    public int? IReferencePadLength { get; set; }

    [Column("iPMTrCodesID")]
    public int? IPmtrCodesId { get; set; }

    [Column("RecurRDef_iBranchID")]
    public int? RecurRdefIBranchId { get; set; }

    [Column("RecurRDef_dCreatedDate", TypeName = "datetime")]
    public DateTime? RecurRdefDCreatedDate { get; set; }

    [Column("RecurRDef_dModifiedDate", TypeName = "datetime")]
    public DateTime? RecurRdefDModifiedDate { get; set; }

    [Column("RecurRDef_iCreatedBranchID")]
    public int? RecurRdefICreatedBranchId { get; set; }

    [Column("RecurRDef_iModifiedBranchID")]
    public int? RecurRdefIModifiedBranchId { get; set; }

    [Column("RecurRDef_iCreatedAgentID")]
    public int? RecurRdefICreatedAgentId { get; set; }

    [Column("RecurRDef_iModifiedAgentID")]
    public int? RecurRdefIModifiedAgentId { get; set; }

    [Column("RecurRDef_iChangeSetID")]
    public int? RecurRdefIChangeSetId { get; set; }

    [Column("RecurRDef_Checksum")]
    [MaxLength(20)]
    public byte[]? RecurRdefChecksum { get; set; }
}
