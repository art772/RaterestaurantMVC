using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Domain.Model
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Jeden Typ może posiadać wiele Restauracji
        public ICollection<RestaurantType> RestaurantTypes { get; set; }
    }
}
