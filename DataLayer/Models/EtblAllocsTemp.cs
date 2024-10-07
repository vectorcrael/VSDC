using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAllocsTemp")]
[Index("IFromRecId", Name = "idx__etblAllocsTemp_iFromRecID")]
[Index("IToRecId", Name = "idx__etblAllocsTemp_iToRecID")]
public partial class EtblAllocsTemp
{
    [Key]
    [Column("idAllocsTemp")]
    public int IdAllocsTemp { get; set; }

    [Column("iAccountID")]
    public int? IAccountId { get; set; }

    [Column("iFromRecID")]
    public long? IFromRecId { get; set; }

    [Column("iToRecID")]
    public long? IToRecId { get; set; }

    [Column("fAmount")]
    public double? FAmount { get; set; }

    [Column("fAmountForeign")]
    public double? FAmountForeign { get; set; }

    [Column("dFromRecDate", TypeName = "datetime")]
    public DateTime? DFromRecDate { get; set; }

    [Column("dToRecDate", TypeName = "datetime")]
    public DateTime? DToRecDate { get; set; }

    [Column("iPLRecID")]
    public long? IPlrecId { get; set; }
}
