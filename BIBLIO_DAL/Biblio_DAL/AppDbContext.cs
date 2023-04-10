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
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Follower> Followers { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Location>(entity =>
            {
                entity.HasKey(l => l.Id).HasName("Primary");

                entity.ToTable("Locations");

                entity.Property(l => l.Id).HasColumnName("id");
                entity.Property(l => l.Country).HasColumnName("country");
                entity.Property(l => l.City).HasColumnName("city");

            });
            builder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id).HasName("Primary");

                entity.ToTable("Users");

                entity.Property(u => u.Id).HasColumnName("id");               
                entity.Property(u => u.UserName).HasColumnName("user_name");
                entity.Property(u => u.Email).HasColumnName("email");
                entity.Property(u => u.LocationId).HasColumnName("password");
                entity.Property(u => u.LocationId).HasColumnName("location_id");               

                entity.HasOne(u => u.Location)
                .WithMany(l => l.Users)
                .HasForeignKey(u => u.LocationId);
               
            });
            builder.Entity<Profile>(entity =>
            {
                entity.HasKey(p => p.Id).HasName("Primary");

                entity.ToTable("Profile");

                entity.Property(u => u.Id).HasColumnName("id");
                entity.Property(p => p.Description).HasColumnName("description");
                entity.Property(p => p.ProfileImg).HasColumnName("profile_img");
                entity.Property(p => p.UserId).HasColumnName("user_id");
                entity.Property(p => p.Status).HasColumnName("status");
                entity.Property(p => p.FirstName).HasColumnName("first_name");
                entity.Property(p => p.LastName).HasColumnName("last_name");

                entity.HasOne(p => p.User)
                .WithOne(u => u.UserProfile)
                .HasForeignKey<Profile>(p => p.UserId);
            });
            builder.Entity<Follower>(entity =>
            {
                entity.HasKey(f => f.Id).HasName("Primary");

                entity.ToTable("Followers");

                entity.Property(u => u.Id).HasColumnName("id");
                entity.Property(u => u.Owner).HasColumnName("owner");
                entity.Property(u => u.Subscriber).HasColumnName("subscriber");
                                
            });
        }
    }
}
