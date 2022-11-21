using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HotelSchema_Lab12.Models;

namespace HotelSchema_Lab12.Data
{
    public class TestDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<RoomAmenity> RoomAmenities { get; set; }
        public TestDbContext(DbContextOptions options) : base(options)
        {
            //ModelBuilder.Entity<Hotel>.HasData(new Hotel { City = "Memphis", Country = "USA", ID = 1, Name = "The Andalusian", Phone = "901-555-1999", State = "TN", streetAddress = "2014 Sam Cooper Blvd"});
            //ModelBuilder.Entity<Room>.hasData(new Room { ID = 1, Name = "Presidential Suite", Layout = 2});
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Country = "USA",
                    ID = 1,
                    Name = "The Andalusian",
                    Phone = "901-555-1999",
                    State = "TN",
                    City = "Memphis",
                    streetAddress = "2014 Sam Cooper Blvd"
                }
            );
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Layout = 2,
                    Name = "Presidential Suite"
                }
            );
            modelBuilder.Entity<Amenity>().HasData(
                new Amenity
                {
                    ID = 1,
                    Name = "Hot Tub"
                }
            );

        }
    }
}
