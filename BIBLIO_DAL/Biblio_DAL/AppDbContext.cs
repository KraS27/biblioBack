using Biblio_DOMAIN.Entities.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Location>(entity =>
            {
                entity.HasKey(l => l.Id).HasName("Primary");

                entity.ToTable("Locations");

                entity.Property(l => l.Id).HasColumnName("Id");
                entity.Property(l => l.Country).HasColumnName("Country");
                entity.Property(l => l.City).HasColumnName("City");

            });
            builder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id).HasName("Primary");

                entity.ToTable("Users");

                entity.Property(u => u.Id).HasColumnName("Id");
                entity.Property(u => u.UserName).HasColumnName("UserName");
                entity.Property(u => u.SmallDescription).HasColumnName("SmallDescription");
                entity.Property(u => u.LocationId).HasColumnName("LocationId");
                entity.Property(u => u.Followed).HasColumnName("Followed");

                entity.HasOne(u => u.Location)
                .WithMany(l => l.Users)
                .HasForeignKey(u => u.LocationId);

                entity.HasOne(u => u.UserProfile)
                .WithOne(p => p.User)
                .HasForeignKey<User>(u => u.ProfileId);
            });
            builder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(p => p.Id).HasName("Primary");

                entity.ToTable("Profile");

                entity.Property(p => p.AboutMe).HasColumnName("AboutMe");
                entity.Property(p => p.ProfileImg).HasColumnName("ProfileImg");
            });
        }

    }
}
