using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Brama.Models.Entities;

[Table("role")]
public class Role
{
    [Key]
    [Column("person_status_id")]
    public Guid Id { get; set;}
    [Column("name")]
    public string Name { get; set;}
    [Column("priority")]
    public int Priority { get; set;}
    public virtual IEnumerable<Status> Statuses { get; set; }
}