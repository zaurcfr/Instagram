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
            modelBuilder.Entity<Friendship>().HasOne(i => i.TargetUser).WithMany(i => i.TargetFriendships).HasForeignKey(i => i.TargetUserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Friendship>().HasOne(i => i.DestinationUser).WithMany(i => i.DestinationFriendships).HasForeignKey(i => i.DestinationUserId).OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<User>().HasMany(i => i.Posts).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<Post>().HasOne(i => i.User).WithMany(i => i.Posts).HasForeignKey(i => i.UserId);

            modelBuilder.Entity<User>().HasMany(i => i.Comments).WithOne(i => i.User).HasForeignKey(i => i.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Comment>().HasOne(i => i.User).WithMany(i => i.Comments).HasForeignKey(i => i.UserId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Post>().HasMany(i => i.Comments).WithOne(i => i.Post).HasForeignKey(i => i.PostId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Comment>().HasOne(i => i.Post).WithMany(i => i.Comments).HasForeignKey(i => i.PostId).OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
}
