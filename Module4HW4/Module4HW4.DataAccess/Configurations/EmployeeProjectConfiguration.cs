using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HW4.DataAccess.Entities;

namespace Module4HW4.DataAccess.Configurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.Rate).IsRequired();
            builder.Property(e => e.StartedDate).IsRequired();
            builder.Property(e => e.EmployeeId).IsRequired();
            builder.Property(e => e.ProjectId).IsRequired();

            builder.HasOne(e => e.Employee)
                .WithMany(p => p.EmployeeProject)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Project)
                .WithMany(p => p.EmployeeProject)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
