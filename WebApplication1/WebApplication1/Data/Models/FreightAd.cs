using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Speditor.Data.Models
{
    public class FreightAd
    {
        public int Id { get; init; }

        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public int CargoId { get; init; }
        public Cargo Cargo { get; set; }

        [Required]
        public int CarrierId { get; init; }
        public Carrier Carrier { get; set; }

        [Required]
        public int GoodsOwnerId { get; init; }
        public GoodsOwner GoodsOwner { get; set; }

        [Required]
        public int ReceiverId { get; init; }
        public Receiver Receiver { get; set; }
    }
}
