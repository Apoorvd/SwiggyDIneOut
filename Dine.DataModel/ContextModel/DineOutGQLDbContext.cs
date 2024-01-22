using Dine.DataModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.ContextModel
{
    public class DineOutGQLDbContext : DbContext
    {
        public DineOutGQLDbContext(DbContextOptions<DineOutGQLDbContext> options) : base(options) // need ot imply this as this is neccessary to provide database provider and connection string
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<CategoryMenu> CategoryMenu { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OngoingOffers> OngoingOffers { get; set; }
        public DbSet<OfferApp> OfferApp { get; set; }
        public DbSet<OfferBank> OfferBank { get; set; }
        public DbSet<OfferType> OfferType { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<ReservationStatus> ReservationStatus { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Review { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
