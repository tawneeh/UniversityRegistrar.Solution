using System;
using System.Collections.Generic;

namespace UniversityTracker.Models
{
  public class Department
{
    public Department()
    {
      this.Students = new HashSet<Object>();
      this.Courses = new HashSet<Object>();
    }

    public int DepartmentId { get; set; }
    public string Name { get; set; }
  
  public ICollection<Object> Students { get; }
  public ICollection<Object> Courses { get; }
}

}

