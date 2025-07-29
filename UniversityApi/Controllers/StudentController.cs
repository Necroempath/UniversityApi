using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Models;

namespace UniversityApi.Controllers;

public class StudentController
{
   private readonly AppDbContext _context = App.Container.GetInstance<AppDbContext>();

   public IQueryable<Student> GetAll()
   {
      return _context.Students;
   }

   public void AddStudent(Student student)
   {
      _context.Students.Add(student);
      _context.SaveChanges();
   }

   public IQueryable<Course> GetCoursesByStudentId(string studentId)
   {
      return _context.StudentCourses.Where(sc => sc.StudentId == studentId)
         .Include(sc => sc.Course).Select(sc => sc.Course);
   }
}