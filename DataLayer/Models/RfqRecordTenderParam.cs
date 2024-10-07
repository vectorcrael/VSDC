using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_RecordTenderParams")]
public partial class RfqRecordTenderParam
{
    [Key]
    [Column("PK_RecordTenderParamID")]
    public int PkRecordTenderParamId { get; set; }

    [Column("FK_RecordTenderID")]
    public int? FkRecordTenderId { get; set; }

    [Column("FK_RecordTenderDetailID")]
    public int? FkRecordTenderDetailId { get; set; }

    [Column("FK_TenderParamID")]
    public int? FkTenderParamId { get; set; }

    [Column("cParamName")]
    [StringLength(200)]
    public string? CParamName { get; set; }

    [Column("iScore")]
    public int IScore { get; set; }

    [Column("iUserScore")]
    public int? IUserScore { get; set; }

    [Column("iPercent")]
    public double? IPercent { get; set; }

    [Column("cComment")]
    [StringLength(500)]
    public string? CComment { get; set; }

    public bool? IsMandatory { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [ForeignKey("FkRecordTenderDetailId")]
    [InverseProperty("RfqRecordTenderParams")]
    public virtual RfqRecordTenderDetail? FkRecordTenderDetail { get; set; }

    [ForeignKey("FkTenderParamId")]
    [InverseProperty("RfqRecordTenderParams")]
    public virtual RfqTenderParameter? FkTenderParam { get; set; }
}
