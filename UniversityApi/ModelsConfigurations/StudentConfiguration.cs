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

        builder.HasData(
            new Student { Id = "97YBS2A", Name = "Sahib", Email = "8bitsodagamer@gmail.com", BirthDate = new DateTime(2000, 09, 21) },
            new Student { Id = "73KJHG5", Name = "Ayla", Email = "ayla2001@example.com", BirthDate = new DateTime(2001, 04, 15) },
            new Student { Id = "24MNBV9", Name = "Togrul", Email = "togrul.dev@example.com", BirthDate = new DateTime(1999, 12, 5) },
            new Student { Id = "11PLKI0", Name = "Leyla", Email = "leyla.art@example.com", BirthDate = new DateTime(2002, 06, 30) },
            new Student { Id = "87QWER3", Name = "Murad", Email = "murad.math@example.com", BirthDate = new DateTime(2000, 02, 11) },
            new Student { Id = "66ZXCV8", Name = "Nigar", Email = "nigar.bio@example.com", BirthDate = new DateTime(2001, 08, 22) },
            new Student { Id = "45ASDF6", Name = "Elvin", Email = "elvin.ai@example.com", BirthDate = new DateTime(1998, 11, 9) }
        );
    }
}