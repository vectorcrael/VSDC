using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblBulkEmailFilters")]
public partial class AtblBulkEmailFilter
{
    [Key]
    [Column("idBulkEmailFilter")]
    public int IdBulkEmailFilter { get; set; }

    [Column("cEmailFilterName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CEmailFilterName { get; set; } = null!;

    [Column("iFromCustomer")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IFromCustomer { get; set; }

    [Column("iToCustomer")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IToCustomer { get; set; }

    [Column("cCustomerGroups")]
    [Unicode(false)]
    public string? CCustomerGroups { get; set; }

    [Column("cAreas")]
    [Unicode(false)]
    public string? CAreas { get; set; }

    [Column("cSalesReps")]
    [Unicode(false)]
    public string? CSalesReps { get; set; }

    [Column("cCurrencies")]
    [Unicode(false)]
    public string? CCurrencies { get; set; }

    [Column("cCustomerField")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CCustomerField { get; set; }
}
