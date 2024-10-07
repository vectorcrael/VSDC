using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevPettyCashAdvance
{
    [Column("idPettyCash")]
    public int IdPettyCash { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("cTillCode")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCode { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("dStartTime", TypeName = "datetime")]
    public DateTime? DStartTime { get; set; }

    [Column("idAgentSession")]
    public int? IdAgentSession { get; set; }

    [Column("dAdvancedDate", TypeName = "datetime")]
    public DateTime? DAdvancedDate { get; set; }

    [Column("iPettyCashTypeID")]
    public int? IPettyCashTypeId { get; set; }

    [Column("cPettyCashTypeDesc")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CPettyCashTypeDesc { get; set; }

    [Column("fAdvancedAmount")]
    public double? FAdvancedAmount { get; set; }

    [Column("cComment")]
    [StringLength(128)]
    [Unicode(false)]
    public string? CComment { get; set; }

    [Column("bProcessed")]
    public bool BProcessed { get; set; }

    [Column("_retPettyCash_iBranchID")]
    public int? RetPettyCashIBranchId { get; set; }
}
