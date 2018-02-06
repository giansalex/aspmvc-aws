using System.Data.Entity;

namespace AwsWebApp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base(Helpers.CreateConnection(), true) { }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}