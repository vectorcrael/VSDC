using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblBankDetails")]
[Index("EtblBankDetailsChecksum", Name = "idx__etblBankDetails__etblBankDetails_Checksum")]
[Index("EtblBankDetailsDModifiedDate", Name = "idx__etblBankDetails__etblBankDetails_dModifiedDate")]
[Index("EtblBankDetailsIBranchId", Name = "idx__etblBankDetails__etblBankDetails_iBranchID")]
[Index("EtblBankDetailsIChangeSetId", Name = "idx__etblBankDetails__etblBankDetails_iChangeSetID")]
public partial class EtblBankDetail
{
    [Key]
    [Column("idBankDetail")]
    public int IdBankDetail { get; set; }

    [Column("cBankName")]
    [StringLength(50)]
    [Unicode(false)]
    public string CBankName { get; set; } = null!;

    [Column("cBankAccName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBankAccName { get; set; }

    [Column("cBankCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CBankCode { get; set; }

    [Column("cBankAccNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBankAccNumber { get; set; }

    [Column("cBranchName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBranchName { get; set; }

    [Column("cBranchCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CBranchCode { get; set; }

    [Column("cBankRefNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CBankRefNumber { get; set; }

    [Column("fAccLimit")]
    public double? FAccLimit { get; set; }

    [Column("cEFTSCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEftscode { get; set; }

    [Column("cEFTSName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CEftsname { get; set; }

    [Column("cEFTSReference")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEftsreference { get; set; }

    [Column("iEFTSLayoutID")]
    public int? IEftslayoutId { get; set; }

    [Column("cEFTSFile")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CEftsfile { get; set; }

    [Column("_etblBankDetails_iBranchID")]
    public int? EtblBankDetailsIBranchId { get; set; }

    [Column("_etblBankDetails_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblBankDetailsDCreatedDate { get; set; }

    [Column("_etblBankDetails_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblBankDetailsDModifiedDate { get; set; }

    [Column("_etblBankDetails_iCreatedBranchID")]
    public int? EtblBankDetailsICreatedBranchId { get; set; }

    [Column("_etblBankDetails_iModifiedBranchID")]
    public int? EtblBankDetailsIModifiedBranchId { get; set; }

    [Column("_etblBankDetails_iCreatedAgentID")]
    public int? EtblBankDetailsICreatedAgentId { get; set; }

    [Column("_etblBankDetails_iModifiedAgentID")]
    public int? EtblBankDetailsIModifiedAgentId { get; set; }

    [Column("_etblBankDetails_iChangeSetID")]
    public int? EtblBankDetailsIChangeSetId { get; set; }

    [Column("_etblBankDetails_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblBankDetailsChecksum { get; set; }

    [Column("bEFTSAutoNum")]
    public bool BEftsautoNum { get; set; }

    [Column("cEFTSAutoNumPrefix")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CEftsautoNumPrefix { get; set; }

    [Column("iEFTSAutoNumPadLength")]
    public int IEftsautoNumPadLength { get; set; }

    [Column("cEFTSAutoFile")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CEftsautoFile { get; set; }
}
