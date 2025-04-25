using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;

    [Table("entrance")]
    public class Entrance
    {
        [Key]
        [Column("entrance_id")]
        public Guid Id { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("building_unit_id")]
        public Guid? BuildingUnitId { get; set; }
        public virtual BuildingUnit? BuildingUnit { get; set; }
        public virtual IEnumerable<EntranceRequest> EntranceRequests { get; set; }
        public virtual IEnumerable<Visit> Visits { get; set; }
    }

