using System.ComponentModel.DataAnnotations;

namespace Speditor.Data.Models
{
    public class CargoSpaceDimension
    {
        public int Id { get; init; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
