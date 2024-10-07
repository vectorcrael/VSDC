using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_retDocketLock")]
public partial class RetDocketLock
{
    [Key]
    [Column("idDocketLock")]
    public int IdDocketLock { get; set; }

    [Column("iDocketID")]
    public long IDocketId { get; set; }

    [Column("iTillID")]
    public int ITillId { get; set; }
}
