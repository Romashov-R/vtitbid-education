using Microsoft.EntityFrameworkCore;
using Vtitbid.Education.ISP19K.Wpf.Training.Models;

namespace Vtitbid.Education.ISP19K.Wpf.Training.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<Speciality> Specialities { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PC-232-00\SQLExpress;Initial Catalog=19KTraining;User Id=sa;Password=4321193");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.FirstName).HasMaxLength(255);
                entity.Property(p => p.LastName).HasMaxLength(255);
                entity.Property(p => p.MiddleName).HasMaxLength(255);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Person)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(e => e.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(e => e.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(e => e.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_PositionId_Positions_Id");               
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasOne(s => s.Person)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(s => s.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(s => s.Group)
                    .WithMany(g => g.Students)
                    .HasForeignKey(s => s.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_GroupId_Groups_Id");
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Code).HasMaxLength(255);
                entity.Property(s => s.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(s => s.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(g => g.Id);

                entity.HasOne(g => g.Curator)
                    .WithMany(e => e.Groups)
                    .HasForeignKey(g => g.CuratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_CuratorId_Employees_CuratorId");

                entity.HasOne(g => g.Speciality)
                    .WithMany(s => s.Groups)
                    .HasForeignKey(g => g.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_SpecialityId_Specialitites_Id");
            });
        }
    }
}