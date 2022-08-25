using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Domain.Model
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public byte[]? ProfilePicture { get; set; }

        // Jeden User może mieć wiele Opinii
        public virtual ICollection<Opinion> ?Opinions { get; set; }

        // Jeden User może mieć wiele Restauracji
        public virtual ICollection<Restaurant>? Restaurants { get; set; }
    }
}
