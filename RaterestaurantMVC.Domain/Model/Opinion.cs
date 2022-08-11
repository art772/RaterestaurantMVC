using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Domain.Model
{
    public class Opinion
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double Rate { get; set; }

        // Jedna Opinia może mieć jednego Usera
        [ForeignKey("AppUser")]
        public int UserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        // Jedna Opinia może mieć jedną Restaurację
        public int? RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        // Jedna Opinia może mieć jedną Odpowiedź
        public Reply ?Reply { get; set; }
    }
}
