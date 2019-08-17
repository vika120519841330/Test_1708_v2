using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TEST_170819.Configuration;
using TEST_170819.Models;

namespace TEST_170819.Context
{
    public class MyContext : DbContext
    {
        public DbSet<FixRequest> FixRequests { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }
        public MyContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<FixRequest>(new FixRequestsConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}