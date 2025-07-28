using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityApi.Models;

namespace UniversityApi.ModelsConfigurations;

public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
{
    public void Configure(EntityTypeBuilder<StudentCourse> builder)
    {
        builder.HasKey(x => new {x.StudentId, x.CourseId});

        builder.HasData(
            new StudentCourse { StudentId = "97YBS2A", CourseId = "70RSTM0" },
            new StudentCourse { StudentId = "73KJHG5", CourseId = "70RSTM0" },
            new StudentCourse { StudentId = "24MNBV9", CourseId = "70RSTM0" },
            new StudentCourse { StudentId = "11PLKI0", CourseId = "56MKT9H" },
            new StudentCourse { StudentId = "87QWER3", CourseId = "56MKT9H" },
            new StudentCourse { StudentId = "66ZXCV8", CourseId = "56MKT9H" },
            new StudentCourse { StudentId = "45ASDF6", CourseId = "33F11G1" },
            new StudentCourse { StudentId = "73KJHG5", CourseId = "33F11G1" },
            new StudentCourse { StudentId = "97YBS2A", CourseId = "33F11G1" }
        );
    }
}