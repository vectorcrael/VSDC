using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_UDF")]
public partial class RfqUdf
{
    [Key]
    [Column("idUDF")]
    public int IdUdf { get; set; }

    [Column("iVendorID")]
    public int IVendorId { get; set; }

    [Column("cFieldName")]
    [StringLength(200)]
    public string CFieldName { get; set; } = null!;

    [Column("cValue")]
    public string CValue { get; set; } = null!;

    [Column("dModifiedDate", TypeName = "datetime")]
    public DateTime? DModifiedDate { get; set; }
}
