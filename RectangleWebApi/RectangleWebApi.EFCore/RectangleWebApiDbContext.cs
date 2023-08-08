using Microsoft.EntityFrameworkCore;
using RectangleWebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWebApi.EFCore
{
    public class RectangleWebApiDbContext : DbContext
    {
       // public RectangleWebApiDbContext() => Database.EnsureCreated();

        public DbSet<PointStored> PointStoreds { get; set; }
        public DbSet<RectangleStored> RectangleStoreds { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Rectangle1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seed = new Seed();
            modelBuilder.Entity<RectangleStored>().HasData(seed.GenerateRectangles(200));
        }
    }
}
