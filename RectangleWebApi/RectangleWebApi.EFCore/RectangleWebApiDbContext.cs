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
        public RectangleWebApiDbContext() => Database.EnsureCreated();

        public DbSet<PointStored> PointStoreds { get; set; }
        public DbSet<RectangleStored> RectangleStoreds { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RectangleWebApiDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seed = new Seed();
            modelBuilder.Entity<PointStored>().HasKey(p => new { p.PointX, p.PointY });
            modelBuilder.Entity<RectangleStored>().HasData(seed.GenerateRectangles(200));
        }
    }
}
