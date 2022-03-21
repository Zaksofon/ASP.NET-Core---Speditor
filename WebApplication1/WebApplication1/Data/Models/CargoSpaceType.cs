using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Speditor.Data.Models
{
    public class CargoSpaceType
    {
        public int Id { get; init; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
