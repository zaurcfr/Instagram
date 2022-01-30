using Instagram.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Entity> Entities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Friendship> Friendships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friendship>().HasKey(i => new { i.TargetUserId, i.DestinationUserId });
            modelBuilder.Entity<Friendship>().HasOne(i => i.TargetUser).WithMany(i => i.Friendships).HasForeignKey(i => i.TargetUserId);
            modelBuilder.Entity<Friendship>().HasOne(i => i.DestinationUser).WithMany(i => i.Friendships).HasForeignKey(i => i.DestinationUserId);
            modelBuilder.Entity<User>().HasMany(i => i.Posts).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<Post>().HasOne(i => i.User).WithMany(i => i.Posts).HasForeignKey(i => i.UserId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
