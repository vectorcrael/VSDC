using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvNote
{
    [Column("idNotes")]
    public int IdNotes { get; set; }

    [Column("cNOTETBLTableName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CNotetbltableName { get; set; }

    [Column("cTableCode")]
    [StringLength(400)]
    [Unicode(false)]
    public string? CTableCode { get; set; }

    [StringLength(27)]
    [Unicode(false)]
    public string? Module { get; set; }

    [Column("cNOTETBLTableID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CNotetbltableId { get; set; }

    [Column("dNOTETBLCreated", TypeName = "datetime")]
    public DateTime? DNotetblcreated { get; set; }

    [Column("dNOTETBLModified", TypeName = "datetime")]
    public DateTime? DNotetblmodified { get; set; }

    [Column("iNOTETBLAgentID")]
    public int? INotetblagentId { get; set; }

    [Column("cAgentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CAgentName { get; set; }

    [Column("nNOTETBLText", TypeName = "text")]
    public string? NNotetbltext { get; set; }

    [Column("_btblNotes_iBranchID")]
    public int? BtblNotesIBranchId { get; set; }
}
