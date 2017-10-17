using System;
using Microsoft.EntityFrameworkCore;
using DeepThoughtsLib.Entities;

namespace DeepThoughtsLib
{
    public class DeepContext : DbContext
    {
        public DeepContext(DbContextOptions<DeepContext> options) : base(options)
        {
            
        }

        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<Collocutor> Collocutors { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Phrase>().ToTable("Phrase");
            modelBuilder.Entity<Collocutor>().ToTable("Collocutor");
            modelBuilder.Entity<Profile>().ToTable("Profile");
        }
        */
    }
}
