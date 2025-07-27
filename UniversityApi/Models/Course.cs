namespace UniversityApi.Models;

public class Course
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int Credit { get; set; }
    
    public ICollection<Student> StudentCourses { get; set; }
}