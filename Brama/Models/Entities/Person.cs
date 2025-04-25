using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;

    [Table("person")]
    public class Person
    {
        [Key]
        [Column("person_id")]
        public Guid Id { get; set; }
        [Column("name")]
        public string? Name {  get; set; }
        [Column("surname")]
        public string? Surname { get; set; }
        [Column("patronic")]
        public string? Patronic { get; set; }
        [Column("phone")]
        public string? Phone { get; set; }
        [Column("username")]
        public string? Username { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("is_active")]
        public bool IsActive { get; set; }
        public virtual IEnumerable<Status> Statuses { get; set; }
        public virtual IEnumerable<StatusLog> RecievedStatusLogs { get; set; }
    }

