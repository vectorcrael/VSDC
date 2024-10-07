using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_NewQuotationParams")]
public partial class RfqNewQuotationParam
{
    [Key]
    [Column("PK_NewQuotationParamID")]
    public int PkNewQuotationParamId { get; set; }

    [Column("FK_iRequisitionID")]
    public int? FkIRequisitionId { get; set; }

    [Column("FK_QuotationParamID")]
    public int? FkQuotationParamId { get; set; }

    [Column("cParamName")]
    [StringLength(200)]
    public string? CParamName { get; set; }

    public bool? IsMandatory { get; set; }

    [Column("iScore")]
    public int? IScore { get; set; }

    [Column("cComment")]
    [StringLength(500)]
    public string? CComment { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime? DLastModifiedDate { get; set; }

    [Column("cNewComment")]
    [StringLength(500)]
    public string? CNewComment { get; set; }

    [Column("iCriteriaID")]
    public int? ICriteriaId { get; set; }
}
