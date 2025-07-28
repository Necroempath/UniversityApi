namespace UniversityApi.Models;

public class StudentCourse
{
    public string StudentId { get; set; }
    public string CourseId { get; set; }
    
    public Student Student { get; set; }
    public Course Course { get; set; }
}