using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("RFQ_WorkflowLink")]
public partial class RfqWorkflowLink
{
    [Key]
    [Column("iWorkflowLinkID")]
    public int IWorkflowLinkId { get; set; }

    [Column("iWorkflowMemberID")]
    public int IWorkflowMemberId { get; set; }

    [Column("iEventID")]
    public int IEventId { get; set; }

    [ForeignKey("IEventId")]
    [InverseProperty("RfqWorkflowLinks")]
    public virtual RfqEvent IEvent { get; set; } = null!;

    [ForeignKey("IWorkflowMemberId")]
    [InverseProperty("RfqWorkflowLinks")]
    public virtual BtblCmworkflowMember IWorkflowMember { get; set; } = null!;
}
