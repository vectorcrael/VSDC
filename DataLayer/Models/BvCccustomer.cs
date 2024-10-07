using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public partial class BvCccustomer
{
    [Column("DCLink")]
    public int Dclink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Account { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("Contact_Person")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Telephone2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Fax2 { get; set; }

    public int? AccountTerms { get; set; }

    [Column("Tax_Number")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Registration { get; set; }

    [Column("Credit_Limit")]
    public double? CreditLimit { get; set; }

    [Column("EMail")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? TradeName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TypeofBus { get; set; }

    public double? MonthlyPur { get; set; }

    public bool? Granted { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DateBusStart { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LastCredGrant { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LastCredDate { get; set; }
}
