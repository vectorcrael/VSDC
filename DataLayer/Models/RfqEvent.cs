using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_Event")]
public partial class RfqEvent
{
    [Key]
    [Column("iEventID")]
    public int IEventId { get; set; }

    [Column("cEventCode")]
    [StringLength(50)]
    public string CEventCode { get; set; } = null!;

    [Column("cDescription")]
    [StringLength(100)]
    public string? CDescription { get; set; }

    [InverseProperty("IEvent")]
    public virtual ICollection<RfqWorkflowLink> RfqWorkflowLinks { get; set; } = new List<RfqWorkflowLink>();
}
