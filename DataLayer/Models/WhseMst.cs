using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("WhseMst")]
[Index("WhseMstDModifiedDate", Name = "idxWhseMst_dModifiedDate")]
[Index("WhseMstIBranchId", Name = "idxWhseMst_iBranchID")]
[Index("WhseMstChecksum", Name = "idx_WhseMst_WhseMst_Checksum")]
[Index("WhseMstIChangeSetId", Name = "idx_WhseMst_iChangeSetID")]
public partial class WhseMst
{
    [Key]
    public int WhseLink { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? KnownAs { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PostCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Tel { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Manager { get; set; }

    public int? BankLink { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccNum { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BankAccType { get; set; }

    [Column("EMail")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ModemTel { get; set; }

    public bool DefaultWhse { get; set; }

    public bool AddNewStock { get; set; }

    [Column("dWarehouseTimeStamp", TypeName = "datetime")]
    public DateTime? DWarehouseTimeStamp { get; set; }

    [Column("iWhseTypeID")]
    public int IWhseTypeId { get; set; }

    [Column("bAllowToBuyInto")]
    public bool BAllowToBuyInto { get; set; }

    [Column("bAllowToSellFrom")]
    public bool BAllowToSellFrom { get; set; }

    [Column("WhseMst_iBranchID")]
    public int? WhseMstIBranchId { get; set; }

    [Column("WhseMst_dCreatedDate", TypeName = "datetime")]
    public DateTime? WhseMstDCreatedDate { get; set; }

    [Column("WhseMst_dModifiedDate", TypeName = "datetime")]
    public DateTime? WhseMstDModifiedDate { get; set; }

    [Column("WhseMst_iCreatedBranchID")]
    public int? WhseMstICreatedBranchId { get; set; }

    [Column("WhseMst_iModifiedBranchID")]
    public int? WhseMstIModifiedBranchId { get; set; }

    [Column("WhseMst_iCreatedAgentID")]
    public int? WhseMstICreatedAgentId { get; set; }

    [Column("WhseMst_iModifiedAgentID")]
    public int? WhseMstIModifiedAgentId { get; set; }

    [Column("WhseMst_iChangeSetID")]
    public int? WhseMstIChangeSetId { get; set; }

    [Column("bAllowNegStock")]
    public bool BAllowNegStock { get; set; }

    [Column("cDefaultItemGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CDefaultItemGroup { get; set; }

    [Column("WhseMst_Checksum")]
    [MaxLength(20)]
    public byte[]? WhseMstChecksum { get; set; }
}
