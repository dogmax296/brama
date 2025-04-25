using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;

    [Table("visit")]
    public class Visit
    {
        [Key]
        [Column("visit_id")]
        public Guid Id { get; set; }
        [Column("date_time_visited")]
        public DateTime DateTimeVisited { get; set; }
        [Column("entrance_id")]
        public Guid EntranceId { get; set; }
        [Column("status_id")]
        public Guid StatusId { get; set; }
        public virtual Entrance Entrance { get; set; }
        public virtual Status Status { get; set; }
        
        
    }

