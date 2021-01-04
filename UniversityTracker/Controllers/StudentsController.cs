using Microsoft.AspNetCore.Mvc;
using UniversityTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UniversityTracker.Controllers
{

  public class StudentsController : Controller
  {
    private readonly UniversityTrackerContext _db;
    public StudentsController(UniversityTrackerContext db)
    {
      _db = db; 
    }

    public ActionResult Index()
    {
      List<Student> model = _db.Students.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    public ActionResult Details (int id)
    {
        var thisStudent = _db.Students
          .Include(student => student.Courses)
          .ThenInclude(join => join.Course)
          .FirstOrDefault(student => student.StudentId == id);
        return View(thisStudent);
    }

    [HttpPost]
    public ActionResult Create (Student student)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}