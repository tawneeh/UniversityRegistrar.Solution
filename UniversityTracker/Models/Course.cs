using System.Collections.Generic;

namespace UniversityTracker.Models
{
  public class Course
  {
    public Course()
    {
      this.Students = new HashSet<Enrollment>();
    }
    
    public int CourseId { get; set; }
    public string Name { get; set; }
    public int Number{ get; set; }
    public ICollection<Enrollment> Students { get; }
  }
}