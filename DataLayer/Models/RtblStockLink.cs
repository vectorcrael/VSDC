using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_rtblStockLinks")]
[Index("RtblStockLinksChecksum", Name = "idx__rtblStockLinks__rtblStockLinks_Checksum")]
[Index("RtblStockLinksIChangeSetId", Name = "idx__rtblStockLinks_iChangeSetID")]
[Index("RtblStockLinksDModifiedDate", Name = "idx_rtblStockLinks_dModifiedDate")]
[Index("RtblStockLinksIBranchId", Name = "idx_rtblStockLinks_iBranchID")]
public partial class RtblStockLink
{
    [Key]
    [Column("idStockLinks")]
    public int IdStockLinks { get; set; }

    [Column("iStockID")]
    public int IStockId { get; set; }

    [Column("iDCLink")]
    public int IDclink { get; set; }

    [Column("bItemActive")]
    public bool BItemActive { get; set; }

    [Column("cProductReference")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CProductReference { get; set; }

    [Column("cModule")]
    [StringLength(2)]
    [Unicode(false)]
    public string CModule { get; set; } = null!;

    [Column("cSupInvCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CSupInvCode { get; set; }

    [Column("iWhseID")]
    public int? IWhseId { get; set; }

    [Column("bDefaultSupplier")]
    public bool BDefaultSupplier { get; set; }

    [Column("bDCOnHold")]
    public bool BDconHold { get; set; }

    [Column("dTimeStamp", TypeName = "datetime")]
    public DateTime? DTimeStamp { get; set; }

    [Column("fLastGRVCost")]
    public double FLastGrvcost { get; set; }

    [Column("dLastGRVCostDate", TypeName = "datetime")]
    public DateTime? DLastGrvcostDate { get; set; }

    [Column("fManualCost")]
    public double FManualCost { get; set; }

    [Column("_rtblStockLinks_iBranchID")]
    public int? RtblStockLinksIBranchId { get; set; }

    [Column("_rtblStockLinks_dCreatedDate", TypeName = "datetime")]
    public DateTime? RtblStockLinksDCreatedDate { get; set; }

    [Column("_rtblStockLinks_dModifiedDate", TypeName = "datetime")]
    public DateTime? RtblStockLinksDModifiedDate { get; set; }

    [Column("_rtblStockLinks_iCreatedBranchID")]
    public int? RtblStockLinksICreatedBranchId { get; set; }

    [Column("_rtblStockLinks_iModifiedBranchID")]
    public int? RtblStockLinksIModifiedBranchId { get; set; }

    [Column("_rtblStockLinks_iCreatedAgentID")]
    public int? RtblStockLinksICreatedAgentId { get; set; }

    [Column("_rtblStockLinks_iModifiedAgentID")]
    public int? RtblStockLinksIModifiedAgentId { get; set; }

    [Column("_rtblStockLinks_iChangeSetID")]
    public int? RtblStockLinksIChangeSetId { get; set; }

    [Column("_rtblStockLinks_fLeadDays")]
    public double? RtblStockLinksFLeadDays { get; set; }

    [Column("fMinOrderQuantity")]
    public double? FMinOrderQuantity { get; set; }

    [Column("_rtblStockLinks_Checksum")]
    [MaxLength(20)]
    public byte[]? RtblStockLinksChecksum { get; set; }

    [Column("iTaxTypeID")]
    public int? ITaxTypeId { get; set; }
}
