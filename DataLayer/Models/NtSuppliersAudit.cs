using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("NT_Suppliers_Audit")]
public partial class NtSuppliersAudit
{
    [Key]
    [Column("iNTSupAuditID")]
    public int INtsupAuditId { get; set; }

    [Column("NTSupID")]
    public int NtsupId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PeriodFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PeriodTo { get; set; }

    public bool? StillBlocked { get; set; }

    [Column("NT_SupplierAudit_dModifiedDate", TypeName = "datetime")]
    public DateTime NtSupplierAuditDModifiedDate { get; set; }

    [Column("NT_SupplierAudit_iModifiedby")]
    public int? NtSupplierAuditIModifiedby { get; set; }
}
