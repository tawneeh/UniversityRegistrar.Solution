using System;
using System.Collections.Generic;

namespace UniversityTracker.Models
{
    public class Major
    {
      public int MajorId { get; set; }
      public int StudentId { get; set; }
      public int DepartmentId { get; set; }
      public Student Student { get; set; }
      public Department Department { get; set; }
    }
}