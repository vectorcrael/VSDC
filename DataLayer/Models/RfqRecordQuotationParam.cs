using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_RecordQuotationParams")]
public partial class RfqRecordQuotationParam
{
    [Key]
    [Column("PK_RecordQuotationParamID")]
    public int PkRecordQuotationParamId { get; set; }

    [Column("FK_iRequisitionID")]
    public int? FkIRequisitionId { get; set; }

    [Column("FK_iSupplierID")]
    public int? FkISupplierId { get; set; }

    [Column("FK_QuotationParamID")]
    public int? FkQuotationParamId { get; set; }

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
}
