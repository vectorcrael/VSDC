using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_NewTenderDetails")]
public partial class RfqNewTenderDetail
{
    [Key]
    [Column("PK_NewTenderDetailID")]
    public int PkNewTenderDetailId { get; set; }

    [Column("FK_NewTenderID")]
    public int FkNewTenderId { get; set; }

    [Column("iModuleID")]
    public int IModuleId { get; set; }

    [Column("iAccountID")]
    public int IAccountId { get; set; }

    [Column("cDescription")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CDescription { get; set; }

    [Column("fQuantity")]
    public double FQuantity { get; set; }

    [Column("fExpectedPrice")]
    public double FExpectedPrice { get; set; }

    [Column("dExpectedDate", TypeName = "datetime")]
    public DateTime? DExpectedDate { get; set; }

    [Column("iProjectID")]
    public int IProjectId { get; set; }

    [Column("iJobID")]
    public int IJobId { get; set; }

    [Column("iIncidentTypeID")]
    public int IIncidentTypeId { get; set; }

    [Column("iEscalateGroupID")]
    public int IEscalateGroupId { get; set; }

    [Column("iAgentID")]
    public int IAgentId { get; set; }

    [Column("cLineNotes")]
    [StringLength(1024)]
    [Unicode(false)]
    public string? CLineNotes { get; set; }

    [Column("iLineStatus")]
    public int ILineStatus { get; set; }

    [Column("iIncidentID")]
    public int? IIncidentId { get; set; }

    [Column("iPOInvoiceID")]
    public int? IPoinvoiceId { get; set; }

    [Column("fActualPrice")]
    public double? FActualPrice { get; set; }

    [Column("fExchangeRate")]
    public double? FExchangeRate { get; set; }

    [Column("fExpectedPriceForeign")]
    public double? FExpectedPriceForeign { get; set; }

    [Column("fActualPriceForeign")]
    public double? FActualPriceForeign { get; set; }

    [Column("dApprovalDate", TypeName = "datetime")]
    public DateTime? DApprovalDate { get; set; }

    [Column("bHasParameters")]
    public bool? BHasParameters { get; set; }

    [Column("dLastModifiedDate", TypeName = "datetime")]
    public DateTime DLastModifiedDate { get; set; }

    [Column("iRequisitionLinesID")]
    public int? IRequisitionLinesId { get; set; }

    [Column("cSector")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CSector { get; set; }

    [ForeignKey("FkNewTenderId")]
    [InverseProperty("RfqNewTenderDetails")]
    public virtual RfqNewTender FkNewTender { get; set; } = null!;

    [InverseProperty("FkNewTenderDetail")]
    public virtual ICollection<RfqNewTenderParam> RfqNewTenderParams { get; set; } = new List<RfqNewTenderParam>();
}
