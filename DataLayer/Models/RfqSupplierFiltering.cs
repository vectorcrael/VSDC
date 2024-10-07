using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_SupplierFiltering")]
public partial class RfqSupplierFiltering
{
    [Key]
    [Column("idSupplierUDF")]
    public int IdSupplierUdf { get; set; }

    [Column("iUserDictID")]
    public int IUserDictId { get; set; }

    [Column("cFieldName")]
    [StringLength(50)]
    public string? CFieldName { get; set; }

    [Column("bCriteria")]
    public bool? BCriteria { get; set; }

    [Column("bIsActive")]
    public bool? BIsActive { get; set; }
}
