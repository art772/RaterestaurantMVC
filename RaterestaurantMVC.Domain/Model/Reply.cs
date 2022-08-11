using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Domain.Model
{
    public class Reply
    {
        public int Id { get; set; }
        public string Content { get; set; }

        // Jedna odpowiedź może mieć jedną opinię
        public int OpinionId { get; set; }
        public Opinion Opinion { get; set; }
    }
}
