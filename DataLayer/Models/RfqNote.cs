using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_Notes")]
public partial class RfqNote
{
    [Key]
    [Column("iNoteID")]
    public int INoteId { get; set; }

    [Column("iRequisitionID")]
    public int IRequisitionId { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("dDate", TypeName = "datetime")]
    public DateTime DDate { get; set; }

    [Column("cNote")]
    [StringLength(500)]
    public string CNote { get; set; } = null!;

    [Column("bStickyNote")]
    public bool? BStickyNote { get; set; }

    [Column("cFunctionality")]
    [StringLength(50)]
    public string? CFunctionality { get; set; }
}
