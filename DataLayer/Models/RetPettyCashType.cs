using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retPettyCashType")]
[Index("RetPettyCashTypeChecksum", Name = "idx__retPettyCashType__retPettyCashType_Checksum")]
[Index("RetPettyCashTypeIChangeSetId", Name = "idx__retPettyCashType_iChangeSetID")]
[Index("RetPettyCashTypeDModifiedDate", Name = "idx_retPettyCashType_dModifiedDate")]
[Index("RetPettyCashTypeIBranchId", Name = "idx_retPettyCashType_iBranchID")]
public partial class RetPettyCashType
{
    [Key]
    [Column("idPettyCashType")]
    public int IdPettyCashType { get; set; }

    [Column("cPettyCashTypeCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CPettyCashTypeCode { get; set; }

    [Column("cPettyCashTypeDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CPettyCashTypeDesc { get; set; }

    [Column("bActive")]
    public bool BActive { get; set; }

    [Column("_retPettyCashType_iBranchID")]
    public int? RetPettyCashTypeIBranchId { get; set; }

    [Column("_retPettyCashType_dCreatedDate", TypeName = "datetime")]
    public DateTime? RetPettyCashTypeDCreatedDate { get; set; }

    [Column("_retPettyCashType_dModifiedDate", TypeName = "datetime")]
    public DateTime? RetPettyCashTypeDModifiedDate { get; set; }

    [Column("_retPettyCashType_iCreatedBranchID")]
    public int? RetPettyCashTypeICreatedBranchId { get; set; }

    [Column("_retPettyCashType_iModifiedBranchID")]
    public int? RetPettyCashTypeIModifiedBranchId { get; set; }

    [Column("_retPettyCashType_iCreatedAgentID")]
    public int? RetPettyCashTypeICreatedAgentId { get; set; }

    [Column("_retPettyCashType_iModifiedAgentID")]
    public int? RetPettyCashTypeIModifiedAgentId { get; set; }

    [Column("_retPettyCashType_iChangeSetID")]
    public int? RetPettyCashTypeIChangeSetId { get; set; }

    [Column("iPettyCashLedgerID")]
    public int? IPettyCashLedgerId { get; set; }

    [Column("iPettyCashTaxTypeID")]
    public int? IPettyCashTaxTypeId { get; set; }

    [Column("iPettyCashTaxLedgerID")]
    public int? IPettyCashTaxLedgerId { get; set; }

    [Column("_retPettyCashType_Checksum")]
    [MaxLength(20)]
    public byte[]? RetPettyCashTypeChecksum { get; set; }
}
