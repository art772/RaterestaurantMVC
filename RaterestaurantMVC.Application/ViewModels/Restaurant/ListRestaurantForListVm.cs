using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModels.Restaurant
{
    public class ListRestaurantForListVm
    {
        public List<RestaurantForListVm> Restaurants { get; set; }
        public int Count { get; set; }
    }
}
