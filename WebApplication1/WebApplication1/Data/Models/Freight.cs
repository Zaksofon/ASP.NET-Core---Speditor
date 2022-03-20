using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Models
{
    public class Freight
    {
        public int Id { get; init; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public int SenderId { get; set; }
        public Sender Sender { get; set; }

        [Required]
        public int ReceiverId { get; init; }
        public Receiver Receiver { get; set; }

        [Required]
        public DateTime LoadingDate { get; set; } 

        [Required]
        public DateTime DeliveryDate { get; set; }
    }
}
