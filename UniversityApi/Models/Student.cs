namespace UniversityApi.Models;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    
    public ICollection<Student> StudentCourses { get; set; }
}