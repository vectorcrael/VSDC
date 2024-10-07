using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPettyCashLine")]
[Index("RetPettyCashLineChecksum", Name = "idx__retPettyCashLine__retPettyCashLine_Checksum")]
[Index("RetPettyCashLineDModifiedDate", Name = "idx__retPettyCashLine__retPettyCashLine_dModifiedDate")]
[Index("RetPettyCashLineIBranchId", Name = "idx__retPettyCashLine__retPettyCashLine_iBranchID")]
[Index("RetPettyCashLineIChangeSetId", Name = "idx__retPettyCashLine__retPettyCashLine_iChangeSetID")]
public partial class RetPettyCashLine
{
    [Key]
    [Column("idPettyCashLine")]
    public int IdPettyCashLine { get; set; }

    [Column("iPettyCashID")]
    public int? IPettyCashId { get; set; }

    [Column("cReference")]
    [StringLength(128)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("fExclAmount")]
    public double? FExclAmount { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }

    [Column("fTaxRate")]
    public double? FTaxRate { get; set; }

    [Column("fInclAmount")]
    public double? FInclAmount { get; set; }

    [Column("_retPettyCashLine_iBranchID")]
    public int? RetPettyCashLineIBranchId { get; set; }

    [Column("_retPettyCashLine_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPettyCashLineDCreatedDate { get; set; }

    [Column("_retPettyCashLine_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPettyCashLineDModifiedDate { get; set; }

    [Column("_retPettyCashLine_iCreatedBranchID")]
    public int? RetPettyCashLineICreatedBranchId { get; set; }

    [Column("_retPettyCashLine_iModifiedBranchID")]
    public int? RetPettyCashLineIModifiedBranchId { get; set; }

    [Column("_retPettyCashLine_iCreatedAgentID")]
    public int? RetPettyCashLineICreatedAgentId { get; set; }

    [Column("_retPettyCashLine_iModifiedAgentID")]
    public int? RetPettyCashLineIModifiedAgentId { get; set; }

    [Column("_retPettyCashLine_iChangeSetID")]
    public int? RetPettyCashLineIChangeSetId { get; set; }

    [Column("_retPettyCashLine_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPettyCashLineChecksum { get; set; }
}
