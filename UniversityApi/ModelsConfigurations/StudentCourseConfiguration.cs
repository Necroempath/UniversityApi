using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityApi.Models;

namespace UniversityApi.ModelsConfigurations;

public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
{
    public void Configure(EntityTypeBuilder<StudentCourse> builder)
    {
        builder.HasKey(x => new {x.StudentId, x.CourseId});
    }
}