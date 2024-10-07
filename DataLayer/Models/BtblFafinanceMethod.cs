using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_btblFAFinanceMethod")]
[Index("BtblFafinanceMethodChecksum", Name = "idx__btblFAFinanceMethod__btblFAFinanceMethod_Checksum")]
[Index("BtblFafinanceMethodIChangeSetId", Name = "idx__btblFAFinanceMethod_iChangeSetID")]
[Index("BtblFafinanceMethodDModifiedDate", Name = "idx_btblFAFinanceMethod_dModifiedDate")]
[Index("BtblFafinanceMethodIBranchId", Name = "idx_btblFAFinanceMethod_iBranchID")]
public partial class BtblFafinanceMethod
{
    [Key]
    [Column("idFinMethod")]
    public int IdFinMethod { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("_btblFAFinanceMethod_iBranchID")]
    public int? BtblFafinanceMethodIBranchId { get; set; }

    [Column("_btblFAFinanceMethod_dCreatedDate", TypeName = "datetime")]
    public DateTime? BtblFafinanceMethodDCreatedDate { get; set; }

    [Column("_btblFAFinanceMethod_dModifiedDate", TypeName = "datetime")]
    public DateTime? BtblFafinanceMethodDModifiedDate { get; set; }

    [Column("_btblFAFinanceMethod_iCreatedBranchID")]
    public int? BtblFafinanceMethodICreatedBranchId { get; set; }

    [Column("_btblFAFinanceMethod_iModifiedBranchID")]
    public int? BtblFafinanceMethodIModifiedBranchId { get; set; }

    [Column("_btblFAFinanceMethod_iCreatedAgentID")]
    public int? BtblFafinanceMethodICreatedAgentId { get; set; }

    [Column("_btblFAFinanceMethod_iModifiedAgentID")]
    public int? BtblFafinanceMethodIModifiedAgentId { get; set; }

    [Column("_btblFAFinanceMethod_iChangeSetID")]
    public int? BtblFafinanceMethodIChangeSetId { get; set; }

    [Column("_btblFAFinanceMethod_Checksum")]
    [MaxLength(20)]
    public byte[]? BtblFafinanceMethodChecksum { get; set; }
}
