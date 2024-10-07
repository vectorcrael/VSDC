using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblTableRelationships")]
public partial class AtblTableRelationship
{
    [Key]
    [Column("idTableRelationship")]
    public int IdTableRelationship { get; set; }

    [Column("cPrimaryTable")]
    [StringLength(256)]
    [Unicode(false)]
    public string CPrimaryTable { get; set; } = null!;

    [Column("cPrimaryColumn")]
    [StringLength(256)]
    [Unicode(false)]
    public string CPrimaryColumn { get; set; } = null!;

    [Column("cForeignTable")]
    [StringLength(256)]
    [Unicode(false)]
    public string CForeignTable { get; set; } = null!;

    [Column("cForeignColumn")]
    [StringLength(256)]
    [Unicode(false)]
    public string CForeignColumn { get; set; } = null!;

    [Column("cCriteriaColumn")]
    [StringLength(1024)]
    [Unicode(false)]
    public string CCriteriaColumn { get; set; } = null!;

    [Column("iCompareType")]
    [StringLength(1024)]
    [Unicode(false)]
    public string ICompareType { get; set; } = null!;

    [Column("cCriteriaValues")]
    [StringLength(1024)]
    [Unicode(false)]
    public string CCriteriaValues { get; set; } = null!;
}
