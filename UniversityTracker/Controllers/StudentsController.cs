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

    public ActionResult Create()
    {
      return View();
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