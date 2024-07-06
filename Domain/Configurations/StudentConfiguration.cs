using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(m => m.FullName).IsRequired().HasMaxLength(100);
        }
    }
}

