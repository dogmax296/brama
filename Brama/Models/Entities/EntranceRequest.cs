using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;
[Table("entrance_request")]
public class EntranceRequest
{
    [Key]
    [Column("entrance_request_id")]
    public Guid Id { get; set; }
    [Column("entrance_id")]
    public Guid EntranceId { get; set; }
    [Column("phone")]
    public string Phone { get; set; }
    public virtual Entrance Entrance { get; set; }
    public virtual StatusLog? StatusLog { get; set; }
}