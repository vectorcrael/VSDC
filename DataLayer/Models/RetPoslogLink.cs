using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPOSLogLinks")]
[Index("RetPoslogLinksChecksum", Name = "idx__retPOSLogLinks__retPOSLogLinks_Checksum")]
[Index("RetPoslogLinksDModifiedDate", Name = "idx__retPOSLogLinks__retPOSLogLinks_dModifiedDate")]
[Index("RetPoslogLinksIBranchId", Name = "idx__retPOSLogLinks__retPOSLogLinks_iBranchID")]
[Index("RetPoslogLinksIChangeSetId", Name = "idx__retPOSLogLinks__retPOSLogLinks_iChangeSetID")]
[Index("IInvNumId", Name = "idx__retPOSLogLinks_iInvNumID")]
[Index("ILogId", Name = "idx__retPOSLogLinks_iLogID")]
public partial class RetPoslogLink
{
    [Key]
    [Column("idPOSLogLinks")]
    public long IdPoslogLinks { get; set; }

    [Column("iInvNumID")]
    public int? IInvNumId { get; set; }

    [Column("iInvLineID")]
    public long? IInvLineId { get; set; }

    [Column("iLogID")]
    public int? ILogId { get; set; }

    [Column("_retPOSLogLinks_iBranchID")]
    public int? RetPoslogLinksIBranchId { get; set; }

    [Column("_retPOSLogLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPoslogLinksDCreatedDate { get; set; }

    [Column("_retPOSLogLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPoslogLinksDModifiedDate { get; set; }

    [Column("_retPOSLogLinks_iCreatedBranchID")]
    public int? RetPoslogLinksICreatedBranchId { get; set; }

    [Column("_retPOSLogLinks_iModifiedBranchID")]
    public int? RetPoslogLinksIModifiedBranchId { get; set; }

    [Column("_retPOSLogLinks_iCreatedAgentID")]
    public int? RetPoslogLinksICreatedAgentId { get; set; }

    [Column("_retPOSLogLinks_iModifiedAgentID")]
    public int? RetPoslogLinksIModifiedAgentId { get; set; }

    [Column("_retPOSLogLinks_iChangeSetID")]
    public int? RetPoslogLinksIChangeSetId { get; set; }

    [Column("_retPOSLogLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPoslogLinksChecksum { get; set; }
}
