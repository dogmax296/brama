using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;

    [Table("building_unit")]
    public class BuildingUnit
    {
        [Key]
        [Column("building_unit_id")]
        public Guid Id { get; set; }
        [Column("number")]
        public int Number {  get; set; }
        public virtual Building Building { get; set; }
        [Column("building_id")]
        public Guid BuildingId { get; set; }
        public virtual IEnumerable<Floor> Floors { get; set; }
        public virtual IEnumerable<Entrance> Entrances { get; set; }
    }

