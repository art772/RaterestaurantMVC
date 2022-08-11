using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Domain.Model
{
    public class RestaurantType
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
