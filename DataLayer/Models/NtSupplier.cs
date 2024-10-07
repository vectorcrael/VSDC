using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("NT_Suppliers")]
public partial class NtSupplier
{
    [Key]
    [Column("NTSupID")]
    public int NtsupId { get; set; }

    [Column("num")]
    public int? Num { get; set; }

    [Column("Name_of_Supplier/Person")]
    [StringLength(255)]
    public string NameOfSupplierPerson { get; set; } = null!;

    [StringLength(20)]
    public string? Registration { get; set; }

    [Column("id_number")]
    [StringLength(20)]
    public string? IdNumber { get; set; }

    [Column("Reason_for_Restriction")]
    [StringLength(255)]
    public string? ReasonForRestriction { get; set; }

    [Column("Period_From", TypeName = "datetime")]
    public DateTime? PeriodFrom { get; set; }

    [Column("Period_To", TypeName = "datetime")]
    public DateTime? PeriodTo { get; set; }

    [Column("Authorised_by")]
    [StringLength(100)]
    public string? AuthorisedBy { get; set; }

    [Column("Still_Blocked")]
    public bool StillBlocked { get; set; }

    [Column("Reason_for_Removal")]
    [StringLength(100)]
    public string? ReasonForRemoval { get; set; }

    [Column("Date_of_entry", TypeName = "datetime")]
    public DateTime? DateOfEntry { get; set; }

    [Column("Date_of_removal", TypeName = "datetime")]
    public DateTime? DateOfRemoval { get; set; }

    [Column("NT_Suppliers_iBranchID")]
    public int? NtSuppliersIBranchId { get; set; }

    [Column("NT_Suppliers_dCreatedDate", TypeName = "datetime")]
    public DateTime? NtSuppliersDCreatedDate { get; set; }

    [Column("NT_Suppliers_dModifiedDate", TypeName = "datetime")]
    public DateTime? NtSuppliersDModifiedDate { get; set; }

    [Column("NT_Suppliers_iCreatedBranchID")]
    public int? NtSuppliersICreatedBranchId { get; set; }

    [Column("NT_Suppliers_iModifiedBranchID")]
    public int? NtSuppliersIModifiedBranchId { get; set; }

    [Column("NT_Suppliers_iCreatedAgentID")]
    public int? NtSuppliersICreatedAgentId { get; set; }

    [Column("NT_Suppliers_iModifiedAgentID")]
    public int? NtSuppliersIModifiedAgentId { get; set; }

    [Column("NT_Suppliers_iChangeSetID")]
    public int? NtSuppliersIChangeSetId { get; set; }

    [Column("NT_Suppliers_Checksum")]
    [MaxLength(20)]
    public byte[]? NtSuppliersChecksum { get; set; }
}
