using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brama.Models.Entities;

    [Table("building")]
    public class Building
    {
        [Key]
        [Column("building_id")]
        public Guid Id { get; set; }
        [Column("street")]
        public string Street {  get; set; }
        [Column("number")]
        public string Number {  get; set; }
        [Column("letter")]
        public string Letter {  get; set; }
        public virtual IEnumerable<BuildingUnit> BuildingUnits { get; set; }
    }
