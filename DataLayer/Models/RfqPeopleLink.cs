using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_PeopleLinks")]
public partial class RfqPeopleLink
{
    [Key]
    [Column("iPeopleLinks")]
    public int IPeopleLinks { get; set; }

    [Column("iPeopleID")]
    public int? IPeopleId { get; set; }

    [Column("iDebtorID")]
    public int? IDebtorId { get; set; }

    [Column("dCreatedDate", TypeName = "datetime")]
    public DateTime? DCreatedDate { get; set; }

    [Column("dModifiedDate", TypeName = "datetime")]
    public DateTime? DModifiedDate { get; set; }
}
