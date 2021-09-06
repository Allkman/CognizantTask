using Microsoft.EntityFrameworkCore;
using ProgramingCompetition.DAL.InitialData;
using ProgramingCompetition.DAL.Models;
using System;

namespace ProgramingCompetition.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public AppDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassificatorTaskType>().HasData(DataSeed.ClassificatorTaskTypes);

            base.OnModelCreating(modelBuilder); 
        }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<RootObject> RootObjects { get; set; }
    }
}
