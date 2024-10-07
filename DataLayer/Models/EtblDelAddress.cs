using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblDelAddress")]
[Index("EtblDelAddressChecksum", Name = "idx__etblDelAddress__etblDelAddress_Checksum")]
[Index("EtblDelAddressIChangeSetId", Name = "idx__etblDelAddress_iChangeSetID")]
[Index("EtblDelAddressDModifiedDate", Name = "idx_etblDelAddress_dModifiedDate")]
[Index("EtblDelAddressIBranchId", Name = "idx_etblDelAddress_iBranchID")]
public partial class EtblDelAddress
{
    [Key]
    [Column("idDelAddress")]
    public int IdDelAddress { get; set; }

    [Column("iDelAddressCodeID")]
    public int IDelAddressCodeId { get; set; }

    [Column("iAccountID")]
    public int IAccountId { get; set; }

    [Column("iDCModule")]
    public int IDcmodule { get; set; }

    [Column("cDescription")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("cDelAddress1")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDelAddress1 { get; set; }

    [Column("cDelAddress2")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDelAddress2 { get; set; }

    [Column("cDelAddress3")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDelAddress3 { get; set; }

    [Column("cDelAddress4")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDelAddress4 { get; set; }

    [Column("cDelAddress5")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CDelAddress5 { get; set; }

    [Column("cDelAddressPC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CDelAddressPc { get; set; }

    [Column("cDelContact1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CDelContact1 { get; set; }

    [Column("cDelContact2")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CDelContact2 { get; set; }

    [Column("cDelTelephone1")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CDelTelephone1 { get; set; }

    [Column("cDelTelephone2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CDelTelephone2 { get; set; }

    [Column("cDelCellular")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CDelCellular { get; set; }

    [Column("cDelFax")]
    [StringLength(25)]
    [Unicode(false)]
    public string? CDelFax { get; set; }

    [Column("cEmail")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CEmail { get; set; }

    [Column("bDefault")]
    public bool BDefault { get; set; }

    [Column("iSalesRepID")]
    public int? ISalesRepId { get; set; }

    [Column("iChargeTaxOpt")]
    public int? IChargeTaxOpt { get; set; }

    [Column("dDelAddressTimeStamp", TypeName = "datetime")]
    public DateTime? DDelAddressTimeStamp { get; set; }

    [Column("iDefDeliveryMethodID")]
    public int IDefDeliveryMethodId { get; set; }

    [Column("_etblDelAddress_iBranchID")]
    public int? EtblDelAddressIBranchId { get; set; }

    [Column("_etblDelAddress_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblDelAddressDCreatedDate { get; set; }

    [Column("_etblDelAddress_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblDelAddressDModifiedDate { get; set; }

    [Column("_etblDelAddress_iCreatedBranchID")]
    public int? EtblDelAddressICreatedBranchId { get; set; }

    [Column("_etblDelAddress_iModifiedBranchID")]
    public int? EtblDelAddressIModifiedBranchId { get; set; }

    [Column("_etblDelAddress_iCreatedAgentID")]
    public int? EtblDelAddressICreatedAgentId { get; set; }

    [Column("_etblDelAddress_iModifiedAgentID")]
    public int? EtblDelAddressIModifiedAgentId { get; set; }

    [Column("_etblDelAddress_iChangeSetID")]
    public int? EtblDelAddressIChangeSetId { get; set; }

    [Column("_etblDelAddress_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblDelAddressChecksum { get; set; }
}
