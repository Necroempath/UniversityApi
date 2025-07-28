using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityApi.Models;

namespace UniversityApi.ModelsConfigurations;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(x => x.Id);

        var title = builder.Property(x => x.Title);
        title.IsRequired();
        title.HasMaxLength(50);

        var credit = builder.Property(x => x.Credit);
        credit.IsRequired();
        builder.ToTable(t => t.HasCheckConstraint("CK_Course_Credit_Positive", "[Credit] > 0"));
    }
}