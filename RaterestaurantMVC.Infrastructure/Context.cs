using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RaterestaurantMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = RaterestaurantMVC.Domain.Model.Type;

namespace RaterestaurantMVC.Infrastructure
{
    public class Context : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Opinion> Opinions{ get; set; }
        public DbSet<Reply> Replies{ get; set; }
        public DbSet<Restaurant> Restaurants{ get; set; }
        public DbSet<RestaurantType> RestaurantType { get; set; }
        public DbSet<Type> Types { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /*
             * 1 do 1 
             */

            // Jedna Opinia ma jedną Odpowiedź. Jedna Opowiedź ma jedną Opinię.

            builder.Entity<Opinion>()
                .HasOne(a => a.Reply)
                .WithOne(b => b.Opinion)
                .HasForeignKey<Reply>(a => a.OpinionId);


            /*
             * Wiele do wielu
             */

            // Jedna Restauracja ma wiele Typów. Jeden Typ ma wiele Restauracji.

            builder.Entity<RestaurantType>()
                .HasKey(rt => new { rt.RestaurantId, rt.TypeId });

            builder.Entity<RestaurantType>()
                .HasOne<Restaurant>(rt => rt.Restaurant)
                .WithMany(r => r.RestaurantTypes)
                .HasForeignKey(rt => rt.RestaurantId);

             builder.Entity<RestaurantType>()
                .HasOne<Type>(rt => rt.Type)
                .WithMany(r => r.RestaurantTypes)
                .HasForeignKey(rt => rt.TypeId);

        }
    }
}
