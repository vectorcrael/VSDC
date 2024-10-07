using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_Deviations")]
public partial class RfqDeviation
{
    [Key]
    [Column("idDeviation")]
    public int IdDeviation { get; set; }

    [Column("cScreenName")]
    [StringLength(100)]
    public string CScreenName { get; set; } = null!;

    [Column("cType")]
    [StringLength(100)]
    public string CType { get; set; } = null!;

    [Column("iUserID")]
    public int IUserId { get; set; }

    [Column("iRequisitionID")]
    public int IRequisitionId { get; set; }

    [Column("iRFQID")]
    public int? IRfqid { get; set; }

    [Column("EntityID")]
    public int? EntityId { get; set; }

    [Column("dDeviationDate", TypeName = "datetime")]
    public DateTime? DDeviationDate { get; set; }

    [Column("iCommentID")]
    public int? ICommentId { get; set; }

    [Column("cAdditionalComment")]
    [StringLength(1000)]
    public string? CAdditionalComment { get; set; }
}
