using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_ParameterUDF")]
public partial class RfqParameterUdf
{
    [Key]
    [Column("idRfqParamUdf")]
    public int IdRfqParamUdf { get; set; }

    [Column("fkParameterCriteriaId")]
    public int? FkParameterCriteriaId { get; set; }

    [Column("iUserDictId")]
    public int? IUserDictId { get; set; }

    [Column("cFieldName")]
    [StringLength(50)]
    public string? CFieldName { get; set; }

    [Column("fWeightage")]
    public double? FWeightage { get; set; }

    [Column("bWeightage")]
    public bool? BWeightage { get; set; }
}
