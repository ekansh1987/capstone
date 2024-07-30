using capstone.Model;
using Microsoft.EntityFrameworkCore;

namespace capstone
{
    public class CapstoneDBContext : DbContext
    {
        public CapstoneDBContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<offers> offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<offers>().HasData(new offers
            {
                Id=1,
                ServiceNumber = 3692581470,
                SimNumber = 1472583690963,
                NetData="1 GB/day data & unlimited calls",
                Sms="1000 SMS per day",
                Price=99,
                Validity=28,
                Otherbenifits="VI movies and TV, Netflix subscription free for 1 year"
            }, new offers
            {
                Id = 2,
                ServiceNumber = 3692581470,
                SimNumber = 1472583690963,
                NetData = "1.5 GB/day data & unlimited calls",
                Sms = "2000 SMS per day",
                Price = 299,
                Validity = 28,
                Otherbenifits = "VI movies and TV, Netflix subscription free for 1 year"
            },
            new offers
            {
                Id = 3,
                ServiceNumber = 3692581470,
                SimNumber = 1472583690963,
                NetData = "2 GB/day data & unlimited calls",
                Sms = "1000 SMS per day",
                Price = 399,
                Validity = 45,
                Otherbenifits = "VI movies and TV, Netflix subscription free for 1 year"
            }, new offers
            {
                Id = 4,
                ServiceNumber = 3692581470,
                SimNumber = 1472583690963,
                NetData = "3 GB/day data & unlimited calls",
                Sms = "2000 SMS per day",
                Price = 499,
                Validity = 72,
                Otherbenifits = "VI movies and TV, Netflix subscription free for 1 year"
            },new offers
            {
                Id = 5,
                ServiceNumber = 3692581470,
                SimNumber = 1472583690963,
                NetData = "100 GB/day data & unlimited calls",
                Sms = "10000 SMS per day",
                Price = 2267,
                Validity = 365,
                Otherbenifits = "VI movies and TV, Netflix subscription free for 1 year"
            }
            );
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 1,
                Name="Ekansh Chandra",
                Email="ekansh123@gmail.com",
                Address="Greater Noida",
                DOB="12-11-1989",
                ServiceNumber=3692581470,
                SimNumber=1472583690963,
                FirstName="Ekansh",
                LastName="Chandra",
                AdharNumber="397788000234",
                Simstatus = false
            }, new Customer
            {
                Id = 2,
                Name = "Pankaj Pandey",
                Email = "pankaj123@gmail.com",
                Address = "Ghaziabad",
                DOB = "12-11-1990",
                ServiceNumber = 3692581471,
                SimNumber = 1472583690964,
                FirstName="Pankaj",
                LastName="Pandey",
                AdharNumber = "397788000235",
                Simstatus = false
            },new Customer
            {
                Id = 3,
                Name = "Maulina Sharma",
                Email = "maulina123@gmail.com",
                Address = "Ghaziabad",
                DOB = "12-11-1990",
                ServiceNumber = 3692581472,
                SimNumber = 1472583690965,
                FirstName="Maulina",
                LastName="Sharma",
                AdharNumber = "397788000236",
                Simstatus = false
            },new Customer
            {
                Id = 4,
                Name = "Rajesh Verma",
                Email = "rajesh123@gmail.com",
                Address = "Noida",
                DOB = "12-11-1987",
                ServiceNumber = 3692581473,
                SimNumber = 1472583690966,
                FirstName="Rajesh",
                LastName="Verma",
                AdharNumber = "397788000237",
                Simstatus = false
            },new Customer
            {
                Id = 5,
                Name = "Sarthak Tiwari",
                Email = "sarthak123@gmail.com",
                Address = "Delhi",
                DOB = "12-11-1988",
                ServiceNumber = 3692581474,
                SimNumber = 1472583690967,
                FirstName="Sarthak",
                LastName="Tiwari",
                AdharNumber = "397788000238",
                Simstatus = false
            });
        }
    }
}
