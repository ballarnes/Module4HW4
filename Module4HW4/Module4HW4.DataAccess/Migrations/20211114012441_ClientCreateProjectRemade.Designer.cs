﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module4HW4.DataAccess;

namespace Module4HW4.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211114012441_ClientCreateProjectRemade")]
    partial class ClientCreateProjectRemade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Age = 30,
                            Email = "t.kovalyova@gmail.com",
                            FirstName = "Tatyana",
                            LastName = "Kovaleva"
                        },
                        new
                        {
                            ClientId = 2,
                            Age = 37,
                            Email = "glebbb30@yahoo.com",
                            FirstName = "Gleb",
                            LastName = "Ivanov"
                        },
                        new
                        {
                            ClientId = 3,
                            Age = 28,
                            Email = "timisaev29@gmail.com",
                            FirstName = "Timur",
                            LastName = "Isaev"
                        },
                        new
                        {
                            ClientId = 4,
                            Age = 41,
                            Email = "lion29481@meta.ua",
                            FirstName = "Lev",
                            LastName = "Novikov"
                        },
                        new
                        {
                            ClientId = 5,
                            Age = 25,
                            Email = "timofey.kryukovv1@outlook.com",
                            FirstName = "Timofey",
                            LastName = "Kryukov"
                        });
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HiredDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1995, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Igor",
                            HiredDate = new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Gorohov",
                            OfficeId = 1,
                            TitleId = 3
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(1997, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivan",
                            HiredDate = new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Gorohov",
                            OfficeId = 1,
                            TitleId = 3
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(1980, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Aleksandr",
                            HiredDate = new DateTime(2016, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Yakubovskiy",
                            OfficeId = 1,
                            TitleId = 2
                        },
                        new
                        {
                            EmployeeId = 4,
                            DateOfBirth = new DateTime(1988, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ekaterina",
                            HiredDate = new DateTime(2018, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Ponomarenko",
                            OfficeId = 1,
                            TitleId = 1
                        },
                        new
                        {
                            EmployeeId = 5,
                            DateOfBirth = new DateTime(1991, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Maria",
                            HiredDate = new DateTime(2018, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Belova",
                            OfficeId = 1,
                            TitleId = 2
                        });
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProject");

                    b.HasData(
                        new
                        {
                            EmployeeProjectId = 1,
                            EmployeeId = 1,
                            ProjectId = 1,
                            Rate = 5000m,
                            StartedDate = new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 2,
                            EmployeeId = 2,
                            ProjectId = 1,
                            Rate = 5000m,
                            StartedDate = new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 3,
                            EmployeeId = 1,
                            ProjectId = 2,
                            Rate = 7000m,
                            StartedDate = new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 4,
                            EmployeeId = 2,
                            ProjectId = 2,
                            Rate = 7000m,
                            StartedDate = new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 5,
                            EmployeeId = 1,
                            ProjectId = 3,
                            Rate = 50000m,
                            StartedDate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 6,
                            EmployeeId = 2,
                            ProjectId = 3,
                            Rate = 50000m,
                            StartedDate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 7,
                            EmployeeId = 3,
                            ProjectId = 3,
                            Rate = 50000m,
                            StartedDate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 8,
                            EmployeeId = 4,
                            ProjectId = 3,
                            Rate = 50000m,
                            StartedDate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 9,
                            EmployeeId = 5,
                            ProjectId = 3,
                            Rate = 50000m,
                            StartedDate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 10,
                            EmployeeId = 1,
                            ProjectId = 4,
                            Rate = 10000m,
                            StartedDate = new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 11,
                            EmployeeId = 2,
                            ProjectId = 5,
                            Rate = 12000m,
                            StartedDate = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 12,
                            EmployeeId = 3,
                            ProjectId = 6,
                            Rate = 23000m,
                            StartedDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 13,
                            EmployeeId = 4,
                            ProjectId = 6,
                            Rate = 23000m,
                            StartedDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 14,
                            EmployeeId = 5,
                            ProjectId = 6,
                            Rate = 23000m,
                            StartedDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OfficeId");

                    b.ToTable("Office");

                    b.HasData(
                        new
                        {
                            OfficeId = 1,
                            Location = "Kyiv",
                            Title = "Main Office"
                        });
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Budget = 5000m,
                            ClientId = 1,
                            Name = "Finui Infotech",
                            StartedDate = new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 2,
                            Budget = 7000m,
                            ClientId = 2,
                            Name = "Mobigradles",
                            StartedDate = new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 3,
                            Budget = 50000m,
                            ClientId = 2,
                            Name = "Metacafe",
                            StartedDate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 4,
                            Budget = 10000m,
                            ClientId = 3,
                            Name = "Binary Bit",
                            StartedDate = new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 5,
                            Budget = 12000m,
                            ClientId = 4,
                            Name = "Hexagon Entertainment",
                            StartedDate = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 6,
                            Budget = 23000m,
                            ClientId = 5,
                            Name = "TWS System",
                            StartedDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TitleId");

                    b.ToTable("Title");

                    b.HasData(
                        new
                        {
                            TitleId = 1,
                            Name = "Junior"
                        },
                        new
                        {
                            TitleId = 2,
                            Name = "Middle"
                        },
                        new
                        {
                            TitleId = 3,
                            Name = "Senior"
                        });
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Employee", b =>
                {
                    b.HasOne("Module4HW4.DataAccess.Entities.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW4.DataAccess.Entities.Title", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.EmployeeProject", b =>
                {
                    b.HasOne("Module4HW4.DataAccess.Entities.Employee", "Employee")
                        .WithMany("EmployeeProject")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW4.DataAccess.Entities.Project", "Project")
                        .WithMany("EmployeeProject")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Project", b =>
                {
                    b.HasOne("Module4HW4.DataAccess.Entities.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeProject");
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Project", b =>
                {
                    b.Navigation("EmployeeProject");
                });

            modelBuilder.Entity("Module4HW4.DataAccess.Entities.Title", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
