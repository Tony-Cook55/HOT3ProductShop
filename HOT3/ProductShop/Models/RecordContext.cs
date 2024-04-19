using Microsoft.EntityFrameworkCore;
using ProductShop.Models.Login;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProductShop.Models
{
    public class RecordContext     : IdentityDbContext<User>
    {

        public RecordContext(DbContextOptions<RecordContext> options) : base(options)
        {
        }


        public DbSet<Record> Records { get; set; }



        public DbSet<Purchase> Purchase { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {





            base.OnModelCreating(modelBuilder);







            modelBuilder.Entity<Record>().HasData(
                new Record
                {
                    RecordId = 1,
                    RecordName = "You've Got A Friend",
                    ArtistName = "Andy William",
                    Price = 15,
                    ImageFileName = "andy_williams__youve_got_a_friend.jpg"
                },
                new Record
                {
                    RecordId = 2,
                    RecordName = "Gentle On My Mind",
                    ArtistName = "Dean Martin",
                    Price = 25,
                    ImageFileName = "dean_martin__gentle_on_my_mind.jpg"
                },
                new Record
                {
                    RecordId = 3,
                    RecordName = "Sinatra's Sinatra",
                    ArtistName = "Frank Sinatra",
                    Price = 30,
                    ImageFileName = "frank_sinatra__sinatras_sinatra.jpg"
                },
                new Record
                {
                    RecordId = 4,
                    RecordName = "Anka",
                    ArtistName = "Paul Anka",
                    Price = 10,
                    ImageFileName = "paul_anka__anka.jpg"
                },
                new Record
                {
                    RecordId = 5,
                    RecordName = "It's Impossible",
                    ArtistName = "Perry Como",
                    Price = 17,
                    ImageFileName = "perry_como__its_impossible.jpg"
                }
            );
        }



    }
}
