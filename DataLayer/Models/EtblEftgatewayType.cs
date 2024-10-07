using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblEFTGatewayType")]
[Index("EtblEftgatewayTypeChecksum", Name = "idx__etblEFTGatewayType__etblEFTGatewayType_Checksum")]
[Index("EtblEftgatewayTypeDModifiedDate", Name = "idx__etblEFTGatewayType__etblEFTGatewayType_dModifiedDate")]
[Index("EtblEftgatewayTypeIBranchId", Name = "idx__etblEFTGatewayType__etblEFTGatewayType_iBranchID")]
[Index("EtblEftgatewayTypeIChangeSetId", Name = "idx__etblEFTGatewayType__etblEFTGatewayType_iChangeSetID")]
public partial class EtblEftgatewayType
{
    [Key]
    [Column("GatewayID")]
    public int GatewayId { get; set; }

    [Column("cCode")]
    public short? CCode { get; set; }

    [Column("cGatewayName")]
    [StringLength(30)]
    public string? CGatewayName { get; set; }

    [Column("_etblEFTGatewayType_iBranchID")]
    public int? EtblEftgatewayTypeIBranchId { get; set; }

    [Column("_etblEFTGatewayType_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblEftgatewayTypeDCreatedDate { get; set; }

    [Column("_etblEFTGatewayType_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblEftgatewayTypeDModifiedDate { get; set; }

    [Column("_etblEFTGatewayType_iCreatedBranchID")]
    public int? EtblEftgatewayTypeICreatedBranchId { get; set; }

    [Column("_etblEFTGatewayType_iModifiedBranchID")]
    public int? EtblEftgatewayTypeIModifiedBranchId { get; set; }

    [Column("_etblEFTGatewayType_iCreatedAgentID")]
    public int? EtblEftgatewayTypeICreatedAgentId { get; set; }

    [Column("_etblEFTGatewayType_iModifiedAgentID")]
    public int? EtblEftgatewayTypeIModifiedAgentId { get; set; }

    [Column("_etblEFTGatewayType_iChangeSetID")]
    public int? EtblEftgatewayTypeIChangeSetId { get; set; }

    [Column("_etblEFTGatewayType_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblEftgatewayTypeChecksum { get; set; }
}
