using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Azure.Core;

namespace Brama.Models.Entities;

[Table("status_log")]
public class StatusLog
{
    [Key]
    [Column("status_log_id")]
    public Guid Id { get; set; }
    [Column("date_time_issued")]
    public DateTime DateTimeIssued { get; set; }
    [Column("status_id_from")]
    public Guid StatusIdFrom { get; set; }
    [Column("person_id_to")]
    public Guid PersonIdTo { get; set; }
    [Column("entrance_request_id")]
    public Guid? EntranceRequestId { get; set; }
    public virtual Status StatusFrom { get; set; }
    public virtual Person PersonTo { get; set; }
    public virtual EntranceRequest? EntranceRequest { get; set; }
    
}