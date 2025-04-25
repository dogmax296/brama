using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;

    [Table("status")]
    public class Status
    {
        [Key]
        [Column("person_status_id")]
        public Guid Id { get; set;}

        [Column("use_amount")]
        public int UseAmount { get; set;}
        [Column("datetime_active_from")]
        public DateTime ActiveFrom { get; set;}
        [Column("datetime_active_to")]
        public DateTime ActiveTo { get; set;}
        [Column("is_active")]
        public bool isActive { get; set;}
        [Column("accommodation_id")]
        public Guid AccommodationId { get; set;}
        [Column("person_id")]
        public Guid PersonId { get; set;}
        [Column("role_id")]
        public Guid RoleId { get; set;}
        public virtual Accommodation Accommodation { get; set; }
        public virtual Person Person { get; set; }
        public virtual Role Role { get; set; }
        public virtual IEnumerable<StatusLog> GivenStatusLogs { get; set; }
        public virtual IEnumerable<Visit> Visits { get; set; }
    }
