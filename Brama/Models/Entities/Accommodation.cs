using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;

    [Table("accommodation")]
    public class Accommodation
    {
        [Key]
        [Column("accommodation_id")]
        public Guid Id { get; set; }
        [Column("number")]
        public int Number { get; set; }
        [Column("floor_id")]
        public Guid FloorId { get; set; }
        public virtual Floor Floor { get; set; }
        public virtual IEnumerable<Status> Statuses { get; set; }
    }

