using Domain.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infra.Extensions;

namespace Infra.Mapping
{
    public class EmployeeMapping : EntityTypeConfiguration<Employee>
    {
        public override void Map(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(v => v.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(v => v.Department)
                .HasMaxLength(20)
                .IsRequired();

            builder.ToTable("Employees");
        }
    }
}