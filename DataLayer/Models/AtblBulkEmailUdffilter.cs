using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblBulkEmailUDFFilters")]
public partial class AtblBulkEmailUdffilter
{
    [Key]
    [Column("idBulkEmailUDFFilter")]
    public int IdBulkEmailUdffilter { get; set; }

    [Column("iBulkEmailFilterID")]
    public int IBulkEmailFilterId { get; set; }

    [Column("cUDFTableName")]
    [StringLength(100)]
    [Unicode(false)]
    public string CUdftableName { get; set; } = null!;

    [Column("cUDFFieldName")]
    [StringLength(100)]
    [Unicode(false)]
    public string CUdffieldName { get; set; } = null!;

    [Column("cValue")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CValue { get; set; }

    [Column("cToValue")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CToValue { get; set; }

    [Column("iFieldType")]
    public int IFieldType { get; set; }
}
