using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Models;

namespace UniversityApi.Controllers;

public class CourseController
{
    private readonly AppDbContext _context = App.Container.GetInstance<AppDbContext>();
    
    public void AddCourse(Course course)
    {
        _context.Add(course);
        _context.SaveChanges();
    }

    public void AssignStudentToCourse(Student student, Course course)
    {
        StudentCourse studentCourse = new() {StudentId = student.Id, CourseId = course.Id };
        _context.StudentCourses.Add(studentCourse);
        _context.SaveChanges();
    }

    public IQueryable<Student> GetStudentsByCourseId(string courseId)
    {
        return _context.StudentCourses.Where(sc => sc.CourseId == courseId)
            .Include(sc => sc.Student).Select(sc => sc.Student);
    }
}