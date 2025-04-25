using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;

    [Table("floor")]
    public class Floor
    {
        [Key]
        [Column("floor_id")]
        public Guid Id { get; set; }
        [Column("number")]
        public int Number { get; set; }
        [Column("building_unit_id")]
        public Guid BuildingUnitId { get; set; }
        public virtual BuildingUnit BuildingUnit { get; set; }
        public virtual IEnumerable<Accommodation> Accommodations { get; set; }
    }


