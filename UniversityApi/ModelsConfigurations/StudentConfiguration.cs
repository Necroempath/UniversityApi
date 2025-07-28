using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityApi.Models;

namespace UniversityApi.ModelsConfigurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(x => x.Id);

        var name = builder.Property(x => x.Name);
        name.IsRequired();
        name.HasMaxLength(30);
        
        var email = builder.Property(x => x.Email);
        email.IsRequired();
        email.HasMaxLength(50);
        builder.HasIndex(x => x.Email).IsUnique();
        
        var birthDate = builder.Property(x => x.BirthDate);
        birthDate.IsRequired();
        birthDate.HasColumnType("date");
    }
}