using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModel.Opinion
{
    public class ListOpinionForListVm
    {
        public List<OpinionVm> Opinions { get; set; }
        public int Count { get; set; }
    }
}
