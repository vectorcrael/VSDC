using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblSagePayErrorCodes")]
[Index("EtblSagePayErrorCodesChecksum", Name = "idx__etblSagePayErrorCodes__etblSagePayErrorCodes_Checksum")]
[Index("EtblSagePayErrorCodesDModifiedDate", Name = "idx__etblSagePayErrorCodes__etblSagePayErrorCodes_dModifiedDate")]
[Index("EtblSagePayErrorCodesIBranchId", Name = "idx__etblSagePayErrorCodes__etblSagePayErrorCodes_iBranchID")]
[Index("EtblSagePayErrorCodesIChangeSetId", Name = "idx__etblSagePayErrorCodes__etblSagePayErrorCodes_iChangeSetID")]
public partial class EtblSagePayErrorCode
{
    [Key]
    [Column("idSagePayErrorCode")]
    public int IdSagePayErrorCode { get; set; }

    [Column("iServiceID")]
    public int? IServiceId { get; set; }

    [Column("iResponse")]
    public int? IResponse { get; set; }

    [Column("bWebServiceFailure")]
    public bool? BWebServiceFailure { get; set; }

    [Column("cResponse")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CResponse { get; set; }

    [Column("_etblSagePayErrorCodes_iBranchID")]
    public int? EtblSagePayErrorCodesIBranchId { get; set; }

    [Column("_etblSagePayErrorCodes_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayErrorCodesDCreatedDate { get; set; }

    [Column("_etblSagePayErrorCodes_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblSagePayErrorCodesDModifiedDate { get; set; }

    [Column("_etblSagePayErrorCodes_iCreatedBranchID")]
    public int? EtblSagePayErrorCodesICreatedBranchId { get; set; }

    [Column("_etblSagePayErrorCodes_iModifiedBranchID")]
    public int? EtblSagePayErrorCodesIModifiedBranchId { get; set; }

    [Column("_etblSagePayErrorCodes_iCreatedAgentID")]
    public int? EtblSagePayErrorCodesICreatedAgentId { get; set; }

    [Column("_etblSagePayErrorCodes_iModifiedAgentID")]
    public int? EtblSagePayErrorCodesIModifiedAgentId { get; set; }

    [Column("_etblSagePayErrorCodes_iChangeSetID")]
    public int? EtblSagePayErrorCodesIChangeSetId { get; set; }

    [Column("_etblSagePayErrorCodes_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblSagePayErrorCodesChecksum { get; set; }
}
