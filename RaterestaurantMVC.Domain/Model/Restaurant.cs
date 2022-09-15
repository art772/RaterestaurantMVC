using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Domain.Model
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string? FlatNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumberFirst { get; set; }
        public string? PhoneNumberSecond { get; set; }
        public int? RateCount { get; set; }
        public int? RateSum { get; set; }
        public double? AvgRate { get; set; }
        public byte[]? RestaurantPicture { get; set; }


        // Jedna Restauracja może mieć jednego Usera (Restauratora)
        [ForeignKey("ApplicationUser")]
        public int UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        // Jedna Restauracja może mieć wiele Opinii
        public virtual ICollection<Opinion> Opinions { get; set; }

        // Jedna Restauracja może mieć wiele Typów 
        public ICollection<RestaurantType> RestaurantTypes { get; set; }
    }
}
