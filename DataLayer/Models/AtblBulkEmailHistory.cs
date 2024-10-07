using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Table("_atblBulkEmailHistory")]
public partial class AtblBulkEmailHistory
{
    [Key]
    [Column("idBulkEmailHistory")]
    public int IdBulkEmailHistory { get; set; }

    [Column("iCustomerID")]
    public int ICustomerId { get; set; }

    [Column("iBulkEmailTemplateID")]
    public int IBulkEmailTemplateId { get; set; }

    [Column("cSentToEmailAddress")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CSentToEmailAddress { get; set; }

    [Column("dTimeStamp", TypeName = "datetime")]
    public DateTime DTimeStamp { get; set; }

    [Column("cMessage")]
    [Unicode(false)]
    public string CMessage { get; set; } = null!;
}
