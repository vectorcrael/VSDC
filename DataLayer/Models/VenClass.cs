using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("VenClass")]
[Index("VenClassDModifiedDate", Name = "idxVenClass_dModifiedDate")]
[Index("VenClassIBranchId", Name = "idxVenClass_iBranchID")]
[Index("VenClassChecksum", Name = "idx_VenClass_VenClass_Checksum")]
[Index("VenClassIChangeSetId", Name = "idx_VenClass_iChangeSetID")]
public partial class VenClass
{
    [Key]
    [Column("idVenClass")]
    public int IdVenClass { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? DiscMtrxRow { get; set; }

    [Column("dGroupTimeStamp", TypeName = "datetime")]
    public DateTime? DGroupTimeStamp { get; set; }

    [Column("iAccountsIDControlAcc")]
    public int? IAccountsIdcontrolAcc { get; set; }

    [Column("iAccountsIDProfitAcc")]
    public int? IAccountsIdprofitAcc { get; set; }

    [Column("iAccountsIDLossAcc")]
    public int? IAccountsIdlossAcc { get; set; }

    [Column("iTaxControlAccID")]
    public int? ITaxControlAccId { get; set; }

    [Column("VenClass_iBranchID")]
    public int? VenClassIBranchId { get; set; }

    [Column("VenClass_dCreatedDate", TypeName = "datetime")]
    public DateTime? VenClassDCreatedDate { get; set; }

    [Column("VenClass_dModifiedDate", TypeName = "datetime")]
    public DateTime? VenClassDModifiedDate { get; set; }

    [Column("VenClass_iCreatedBranchID")]
    public int? VenClassICreatedBranchId { get; set; }

    [Column("VenClass_iModifiedBranchID")]
    public int? VenClassIModifiedBranchId { get; set; }

    [Column("VenClass_iCreatedAgentID")]
    public int? VenClassICreatedAgentId { get; set; }

    [Column("VenClass_iModifiedAgentID")]
    public int? VenClassIModifiedAgentId { get; set; }

    [Column("VenClass_iChangeSetID")]
    public int? VenClassIChangeSetId { get; set; }

    [Column("iRevProfitAcc")]
    public int? IRevProfitAcc { get; set; }

    [Column("iRevLossAcc")]
    public int? IRevLossAcc { get; set; }

    [Column("iProvForRevAcc")]
    public int? IProvForRevAcc { get; set; }

    [Column("iInvoiceDocProfileID")]
    public int? IInvoiceDocProfileId { get; set; }

    [Column("iSOInvoiceDocProfileID")]
    public int? ISoinvoiceDocProfileId { get; set; }

    [Column("iCreditNoteDocProfileID")]
    public int? ICreditNoteDocProfileId { get; set; }

    [Column("iJCInvoiceDocProfileID")]
    public int? IJcinvoiceDocProfileId { get; set; }

    [Column("VenClass_Checksum")]
    [MaxLength(20)]
    public byte[]? VenClassChecksum { get; set; }
}
