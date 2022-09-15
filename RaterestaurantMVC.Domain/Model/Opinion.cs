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
        public string Content { get; set; }
        public double Rate { get; set; }

        //Jedna Opinia może mieć jednego Usera
        [ForeignKey("ApplicationUser")]
        public int UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        // Jedna Opinia może mieć jedną Restaurację
        public int? RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        // Jedna Opinia może mieć jedną Odpowiedź
        public Reply? Reply { get; set; }
    }
}
