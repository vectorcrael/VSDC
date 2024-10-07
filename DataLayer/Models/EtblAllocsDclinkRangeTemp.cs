using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblAllocsDCLinkRangeTemp")]
public partial class EtblAllocsDclinkRangeTemp
{
    [Key]
    [Column("DCLink")]
    public int Dclink { get; set; }
}
