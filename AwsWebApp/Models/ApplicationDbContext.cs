using System.Data.Entity;

namespace AwsWebApp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base(Helpers.GetRdsConnectionString()) { }

        public DbSet<Customer> Customer { get; set; }
    }
}