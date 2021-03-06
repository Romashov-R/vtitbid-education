// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vtitbid.Education.ISP19.Wpf.Training.Data;

#nullable disable

namespace Vtitbid.Education.ISP19.Wpf.Training.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220411091944_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CuratorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CuratorId");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Employee", b =>
                {
                    b.HasOne("Vtitbid.Education.ISP19.Wpf.Training.Models.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .IsRequired()
                        .HasConstraintName("FK_Employees_PositionId_Positions_Id");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Group", b =>
                {
                    b.HasOne("Vtitbid.Education.ISP19.Wpf.Training.Models.Employee", "Curator")
                        .WithMany("Groups")
                        .HasForeignKey("CuratorId")
                        .IsRequired()
                        .HasConstraintName("FK_Groups_CuratorId_Employees_Id");

                    b.HasOne("Vtitbid.Education.ISP19.Wpf.Training.Models.Speciality", "Speciality")
                        .WithMany("Groups")
                        .HasForeignKey("SpecialityId")
                        .IsRequired()
                        .HasConstraintName("FK_Groups_SpecialityId_Specialities_Id");

                    b.Navigation("Curator");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Student", b =>
                {
                    b.HasOne("Vtitbid.Education.ISP19.Wpf.Training.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .IsRequired()
                        .HasConstraintName("FK_Students_GroupId_Groups_Id");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Employee", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Position", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Vtitbid.Education.ISP19.Wpf.Training.Models.Speciality", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
