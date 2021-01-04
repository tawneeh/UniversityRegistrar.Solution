using System.Collections.Generic;

namespace UniversityTracker.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<Enrollment>();
    }
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string EnrollmentDate { get; set; }
    public virtual ICollection<Enrollment> Courses { get; set; }
  }
}