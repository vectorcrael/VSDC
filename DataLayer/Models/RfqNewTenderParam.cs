using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_NewTenderParams")]
public partial class RfqNewTenderParam
{
    [Key]
    [Column("PK_NewTenderParamID")]
    public int PkNewTenderParamId { get; set; }

    [Column("FK_NewTenderDetailID")]
    public int? FkNewTenderDetailId { get; set; }

    [Column("FK_NewTenderID")]
    public int? FkNewTenderId { get; set; }

    [Column("FK_TenderParamID")]
    public int? FkTenderParamId { get; set; }

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

    [ForeignKey("FkNewTenderDetailId")]
    [InverseProperty("RfqNewTenderParams")]
    public virtual RfqNewTenderDetail? FkNewTenderDetail { get; set; }

    [ForeignKey("FkTenderParamId")]
    [InverseProperty("RfqNewTenderParams")]
    public virtual RfqTenderParameter? FkTenderParam { get; set; }
}
