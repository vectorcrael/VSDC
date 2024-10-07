using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPettyCash")]
[Index("RetPettyCashChecksum", Name = "idx__retPettyCash__retPettyCash_Checksum")]
[Index("RetPettyCashDModifiedDate", Name = "idx__retPettyCash__retPettyCash_dModifiedDate")]
[Index("RetPettyCashIBranchId", Name = "idx__retPettyCash__retPettyCash_iBranchID")]
[Index("RetPettyCashIChangeSetId", Name = "idx__retPettyCash__retPettyCash_iChangeSetID")]
public partial class RetPettyCash
{
    [Key]
    [Column("idPettyCash")]
    public int IdPettyCash { get; set; }

    [Column("iPettyCashTypeID")]
    public int? IPettyCashTypeId { get; set; }

    [Column("cComment")]
    [StringLength(128)]
    [Unicode(false)]
    public string? CComment { get; set; }

    [Column("iAdvancedAgentSessionID")]
    public int? IAdvancedAgentSessionId { get; set; }

    [Column("dAdvancedDate", TypeName = "datetime")]
    public DateTime? DAdvancedDate { get; set; }

    [Column("fAdvancedAmount")]
    public double? FAdvancedAmount { get; set; }

    [Column("bProcessed")]
    public bool BProcessed { get; set; }

    [Column("iProcessedAgentSessionID")]
    public int? IProcessedAgentSessionId { get; set; }

    [Column("dProcessedDate", TypeName = "datetime")]
    public DateTime? DProcessedDate { get; set; }

    [Column("fChangeAmount")]
    public double? FChangeAmount { get; set; }

    [Column("_retPettyCash_iBranchID")]
    public int? RetPettyCashIBranchId { get; set; }

    [Column("_retPettyCash_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPettyCashDCreatedDate { get; set; }

    [Column("_retPettyCash_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPettyCashDModifiedDate { get; set; }

    [Column("_retPettyCash_iCreatedBranchID")]
    public int? RetPettyCashICreatedBranchId { get; set; }

    [Column("_retPettyCash_iModifiedBranchID")]
    public int? RetPettyCashIModifiedBranchId { get; set; }

    [Column("_retPettyCash_iCreatedAgentID")]
    public int? RetPettyCashICreatedAgentId { get; set; }

    [Column("_retPettyCash_iModifiedAgentID")]
    public int? RetPettyCashIModifiedAgentId { get; set; }

    [Column("_retPettyCash_iChangeSetID")]
    public int? RetPettyCashIChangeSetId { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("iAdvancedTillID")]
    public int? IAdvancedTillId { get; set; }

    [Column("iProcessedTillID")]
    public int? IProcessedTillId { get; set; }

    [Column("_retPettyCash_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPettyCashChecksum { get; set; }
}
