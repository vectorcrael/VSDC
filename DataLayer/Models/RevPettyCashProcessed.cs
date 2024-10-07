using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class RevPettyCashProcessed
{
    [Column("idPettyCash")]
    public int IdPettyCash { get; set; }

    [Column("cAgentNameAdvanced")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentNameAdvanced { get; set; }

    [Column("cTillCodeAdvanced")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCodeAdvanced { get; set; }

    [Column("cReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CReference { get; set; }

    [Column("dTradingDateAdvanced", TypeName = "datetime")]
    public DateTime? DTradingDateAdvanced { get; set; }

    [Column("idAgentSessionAdvanced")]
    public int? IdAgentSessionAdvanced { get; set; }

    [Column("dAdvancedDate", TypeName = "datetime")]
    public DateTime? DAdvancedDate { get; set; }

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

    [Column("iPettyCashTypeID")]
    public int? IPettyCashTypeId { get; set; }

    [Column("_retPettyCash_iBranchID")]
    public int? RetPettyCashIBranchId { get; set; }

    [Column("cAgentNameProcessed")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentNameProcessed { get; set; }

    [Column("cTillCodeProcessed")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CTillCodeProcessed { get; set; }

    [Column("dTradingDateProcessed", TypeName = "datetime")]
    public DateTime? DTradingDateProcessed { get; set; }

    [Column("idAgentSessionProcessed")]
    public int? IdAgentSessionProcessed { get; set; }

    [Column("dProcessedDate", TypeName = "datetime")]
    public DateTime? DProcessedDate { get; set; }

    [Column("fProcessedAmount")]
    public double? FProcessedAmount { get; set; }

    [Column("fChangeAmount")]
    public double? FChangeAmount { get; set; }
}
