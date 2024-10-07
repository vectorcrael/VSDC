using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class WvRfqevoRestrictedSupplier
{
    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Location { get; set; } = null!;

    [Column("Registration / id_number")]
    [StringLength(43)]
    public string? RegistrationIdNumber { get; set; }

    [Column("Name_of_Supplier/Person")]
    [StringLength(255)]
    public string NameOfSupplierPerson { get; set; } = null!;

    [Column("num")]
    public int? Num { get; set; }

    [Column("Reason_for_Restriction")]
    [StringLength(255)]
    public string? ReasonForRestriction { get; set; }

    [Column("Reason_for_Removal")]
    [StringLength(100)]
    public string? ReasonForRemoval { get; set; }

    [Column("Authorised_by")]
    [StringLength(100)]
    public string? AuthorisedBy { get; set; }

    [Column("Period_From", TypeName = "datetime")]
    public DateTime? PeriodFrom { get; set; }

    [Column("Period_To", TypeName = "datetime")]
    public DateTime? PeriodTo { get; set; }

    [Column("Still_Blocked")]
    public bool StillBlocked { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string StillBlockedTxt { get; set; } = null!;

    [Column("Date_of_entry", TypeName = "datetime")]
    public DateTime? DateOfEntry { get; set; }

    [Column("Date_of_removal", TypeName = "datetime")]
    public DateTime? DateOfRemoval { get; set; }
}
