using Microsoft.EntityFrameworkCore;
using Vtitbid.Education.ISP19.Wpf.Training.Models;

namespace Vtitbid.Education.ISP19.Wpf.Training.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Speciality> Specialities { get; set; }

        public DatabaseContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLExpress;Initial Catalog=19Training;User Id=sa;Password=4321193");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speciality>().HasKey(s => s.Id);
            modelBuilder.Entity<Position>().HasKey(p => p.Id);

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.HasOne(s => s.Group)
                    .WithMany(g => g.Students)
                    .HasForeignKey(s => s.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_GroupId_Groups_Id");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(e => e.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_PositionId_Positions_Id");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(g => g.Id);
                entity.HasOne(g => g.Curator)
                    .WithMany(e => e.Groups)
                    .HasForeignKey(g => g.CuratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_CuratorId_Employees_Id");
                entity.HasOne(g => g.Speciality)
                    .WithMany(s => s.Groups)
                    .HasForeignKey(g => g.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_SpecialityId_Specialities_Id");
            });
        }
    }
}