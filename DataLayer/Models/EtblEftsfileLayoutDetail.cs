using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_etblEFTSFileLayoutDetails")]
[Index("EtblEftsfileLayoutDetailsChecksum", Name = "idx__etblEFTSFileLayoutDetails__etblEFTSFileLayoutDetails_Checksum")]
[Index("EtblEftsfileLayoutDetailsIChangeSetId", Name = "idx__etblEFTSFileLayoutDetails_iChangeSetID")]
[Index("EtblEftsfileLayoutDetailsDModifiedDate", Name = "idx_etblEFTSFileLayoutDetails_dModifiedDate")]
[Index("EtblEftsfileLayoutDetailsIBranchId", Name = "idx_etblEFTSFileLayoutDetails_iBranchID")]
public partial class EtblEftsfileLayoutDetail
{
    [Key]
    [Column("idEFTSLayoutDetails")]
    public int IdEftslayoutDetails { get; set; }

    [Column("iEFTSLayoutID")]
    public int IEftslayoutId { get; set; }

    [Column("cRecordType")]
    [StringLength(50)]
    [Unicode(false)]
    public string CRecordType { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(30)]
    [Unicode(false)]
    public string CDescription { get; set; } = null!;

    [Column("iFieldLength")]
    public int IFieldLength { get; set; }

    [Column("iDecimalPlaces")]
    public int? IDecimalPlaces { get; set; }

    [Column("cFieldFormat")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CFieldFormat { get; set; }

    [Column("iFiller")]
    public int? IFiller { get; set; }

    [Column("bFieldInUse")]
    public bool BFieldInUse { get; set; }

    [Column("cValueType")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CValueType { get; set; }

    [Column("cDefaultValue")]
    [StringLength(120)]
    [Unicode(false)]
    public string? CDefaultValue { get; set; }

    [Column("_etblEFTSFileLayoutDetails_iBranchID")]
    public int? EtblEftsfileLayoutDetailsIBranchId { get; set; }

    [Column("_etblEFTSFileLayoutDetails_dCreatedDate", TypeName = "datetime")]
    public DateTime? EtblEftsfileLayoutDetailsDCreatedDate { get; set; }

    [Column("_etblEFTSFileLayoutDetails_dModifiedDate", TypeName = "datetime")]
    public DateTime? EtblEftsfileLayoutDetailsDModifiedDate { get; set; }

    [Column("_etblEFTSFileLayoutDetails_iCreatedBranchID")]
    public int? EtblEftsfileLayoutDetailsICreatedBranchId { get; set; }

    [Column("_etblEFTSFileLayoutDetails_iModifiedBranchID")]
    public int? EtblEftsfileLayoutDetailsIModifiedBranchId { get; set; }

    [Column("_etblEFTSFileLayoutDetails_iCreatedAgentID")]
    public int? EtblEftsfileLayoutDetailsICreatedAgentId { get; set; }

    [Column("_etblEFTSFileLayoutDetails_iModifiedAgentID")]
    public int? EtblEftsfileLayoutDetailsIModifiedAgentId { get; set; }

    [Column("_etblEFTSFileLayoutDetails_iChangeSetID")]
    public int? EtblEftsfileLayoutDetailsIChangeSetId { get; set; }

    [Column("_etblEFTSFileLayoutDetails_Checksum")]
    [MaxLength(20)]
    public byte[]? EtblEftsfileLayoutDetailsChecksum { get; set; }
}
