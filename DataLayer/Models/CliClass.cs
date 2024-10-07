using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("CliClass")]
[Index("CliClassDModifiedDate", Name = "idxCliClass_dModifiedDate")]
[Index("CliClassIBranchId", Name = "idxCliClass_iBranchID")]
[Index("CliClassChecksum", Name = "idx_CliClass_CliClass_Checksum")]
[Index("CliClassIChangeSetId", Name = "idx_CliClass_iChangeSetID")]
public partial class CliClass
{
    [Key]
    public int IdCliClass { get; set; }

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

    [Column("CliClass_iBranchID")]
    public int? CliClassIBranchId { get; set; }

    [Column("CliClass_dCreatedDate", TypeName = "datetime")]
    public DateTime? CliClassDCreatedDate { get; set; }

    [Column("CliClass_dModifiedDate", TypeName = "datetime")]
    public DateTime? CliClassDModifiedDate { get; set; }

    [Column("CliClass_iCreatedBranchID")]
    public int? CliClassICreatedBranchId { get; set; }

    [Column("CliClass_iModifiedBranchID")]
    public int? CliClassIModifiedBranchId { get; set; }

    [Column("CliClass_iCreatedAgentID")]
    public int? CliClassICreatedAgentId { get; set; }

    [Column("CliClass_iModifiedAgentID")]
    public int? CliClassIModifiedAgentId { get; set; }

    [Column("CliClass_iChangeSetID")]
    public int? CliClassIChangeSetId { get; set; }

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

    [Column("CliClass_Checksum")]
    [MaxLength(20)]
    public byte[]? CliClassChecksum { get; set; }
}
