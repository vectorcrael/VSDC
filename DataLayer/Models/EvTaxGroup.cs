using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class EvTaxGroup
{
    [Column("idTrCodes")]
    public int IdTrCodes { get; set; }

    [Column("iModule")]
    public int IModule { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column("LinkID")]
    public int? LinkId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public bool DebitTrans { get; set; }

    public bool Tax { get; set; }

    public bool Rep { get; set; }

    public int? Account1Link { get; set; }

    public int? Account2Link { get; set; }

    public int? TaxAccountLink { get; set; }

    [Column("GLPrompt")]
    public bool Glprompt { get; set; }

    [Column("TaxTypeID")]
    public int? TaxTypeId { get; set; }

    public bool SplitTr { get; set; }

    [Column("bSalesFilter")]
    public bool BSalesFilter { get; set; }

    [Column("bAllowSubAccTrans")]
    public bool BAllowSubAccTrans { get; set; }

    [Column("bSettlementDisc")]
    public bool BSettlementDisc { get; set; }

    [Column("TrCodes_iBranchID")]
    public int? TrCodesIBranchId { get; set; }

    [Column("TrCodes_dCreatedDate", TypeName = "datetime")]
    public DateTime? TrCodesDCreatedDate { get; set; }

    [Column("TrCodes_dModifiedDate", TypeName = "datetime")]
    public DateTime? TrCodesDModifiedDate { get; set; }

    [Column("TrCodes_iCreatedBranchID")]
    public int? TrCodesICreatedBranchId { get; set; }

    [Column("TrCodes_iModifiedBranchID")]
    public int? TrCodesIModifiedBranchId { get; set; }

    [Column("TrCodes_iCreatedAgentID")]
    public int? TrCodesICreatedAgentId { get; set; }

    [Column("TrCodes_iModifiedAgentID")]
    public int? TrCodesIModifiedAgentId { get; set; }

    [Column("TrCodes_iChangeSetID")]
    public int? TrCodesIChangeSetId { get; set; }

    [Column("iDtTaxGroupID")]
    public int? IDtTaxGroupId { get; set; }

    [Column("iCtTaxGroupID")]
    public int? ICtTaxGroupId { get; set; }

    [Column("iTaxGroupID")]
    public int? ITaxGroupId { get; set; }

    [Column("iMBServiceID")]
    public int IMbserviceId { get; set; }

    [Column("TrCodes_Checksum")]
    [MaxLength(20)]
    public byte[]? TrCodesChecksum { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string Module { get; set; } = null!;
}
