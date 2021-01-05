using System;
using System.Collections.Generic;

namespace UniversityTracker.Models
{
  public class Curriculum
  {
    public int CurriculumId {get; set;}
    public int CourseId {get; set;}
    public int DepartmentId {get; set;}
    public Course Course {get; set; }
    public Department Department {get; set; }
  }
}