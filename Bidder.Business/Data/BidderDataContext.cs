using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Bidder.Data.Entities;
using Bidder.Data.Entities.Account;
using Bidder.Data.Model;

namespace Bidder.Business.Data
{
    public class BidderDataContext : DbContext
    {
       
        public BidderDataContext(DbContextOptions<BidderDataContext> options) : base(options)
        {
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Student> Students { get; set; }
        public IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=" + DBConnection.ServerName
                               + ";Database=" + DBConnection.DatabaseName
                               + ";Persist Security Info=True;User ID=" + DBConnection.UserName
                               + ";Password=" + DBConnection.Password
                               + "");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RolePermission>()
                .HasKey(bc => new { bc.RoleId, bc.PermissionId });
            modelBuilder.Entity<RolePermission>()
                .HasOne(bc => bc.Role)
                .WithMany(b => b.RolePermissions)
                .HasForeignKey(bc => bc.RoleId);
            modelBuilder.Entity<RolePermission>()
                .HasOne(bc => bc.Permission)
                .WithMany(c => c.RolePermissions)
                .HasForeignKey(bc => bc.PermissionId);

            // USER ROLES
            modelBuilder.Entity<UserRoles>()
                .HasKey(bc => new { bc.RoleId, bc.UserId });
            modelBuilder.Entity<UserRoles>()
                .HasOne(bc => bc.Role)
                .WithMany(b => b.UserRoles)
                .HasForeignKey(bc => bc.RoleId);
            modelBuilder.Entity<UserRoles>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.UserRoles)
                .HasForeignKey(bc => bc.UserId);   
        }
    }
}