using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModels.Opinion
{
    public class NewOpinionVm
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public double Rate { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
    }
}
