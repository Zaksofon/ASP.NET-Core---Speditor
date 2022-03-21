using System;
using System.ComponentModel.DataAnnotations;

namespace Speditor.Data.Models
{
    public class Cargo
    {
        public int Id { get; init; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal FreightPrice { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public bool DangerousLoad { get; set; }

        [Required]
        public DateTime LoadingDate { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public int CargoSpaceTypeId { get; init; }
        public CargoSpaceType CargoSpaceType { get; set; }

        [Required]
        public int CargoSpaceDimensionId { get; init; }
        public CargoSpaceDimension CargoSpaceDimension { get; set; }
    }
}
