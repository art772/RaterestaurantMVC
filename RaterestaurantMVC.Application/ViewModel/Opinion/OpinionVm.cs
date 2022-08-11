using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModel.Opinion
{
    public class OpinionVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double Rate { get; set; }
    }
}
