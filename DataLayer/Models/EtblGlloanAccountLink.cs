using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblGLLoanAccountLinks")]
[Index("EtblGlloanAccountLinksChecksum", Name = "idx__etblGLLoanAccountLinks__etblGLLoanAccountLinks_Checksum")]
[Index("EtblGlloanAccountLinksDModifiedDate", Name = "idx__etblGLLoanAccountLinks__etblGLLoanAccountLinks_dModifiedDate")]
[Index("EtblGlloanAccountLinksIBranchId", Name = "idx__etblGLLoanAccountLinks__etblGLLoanAccountLinks_iBranchID")]
[Index("EtblGlloanAccountLinksIChangeSetId", Name = "idx__etblGLLoanAccountLinks__etblGLLoanAccountLinks_iChangeSetID")]
public partial class EtblGlloanAccountLink
{
    [Key]
    [Column("idGLLoanAccountLinks")]
    public int IdGlloanAccountLinks { get; set; }

    [Column("iABLoanAccountID")]
    public int? IAbloanAccountId { get; set; }

    [Column("iBranchLoanAccountID")]
    public int? IBranchLoanAccountId { get; set; }

    [Column("_etblGLLoanAccountLinks_iBranchID")]
    public int? EtblGlloanAccountLinksIBranchId { get; set; }

    [Column("_etblGLLoanAccountLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblGlloanAccountLinksDCreatedDate { get; set; }

    [Column("_etblGLLoanAccountLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblGlloanAccountLinksDModifiedDate { get; set; }

    [Column("_etblGLLoanAccountLinks_iCreatedBranchID")]
    public int? EtblGlloanAccountLinksICreatedBranchId { get; set; }

    [Column("_etblGLLoanAccountLinks_iModifiedBranchID")]
    public int? EtblGlloanAccountLinksIModifiedBranchId { get; set; }

    [Column("_etblGLLoanAccountLinks_iCreatedAgentID")]
    public int? EtblGlloanAccountLinksICreatedAgentId { get; set; }

    [Column("_etblGLLoanAccountLinks_iModifiedAgentID")]
    public int? EtblGlloanAccountLinksIModifiedAgentId { get; set; }

    [Column("_etblGLLoanAccountLinks_iChangeSetID")]
    public int? EtblGlloanAccountLinksIChangeSetId { get; set; }

    [Column("_etblGLLoanAccountLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblGlloanAccountLinksChecksum { get; set; }
}
