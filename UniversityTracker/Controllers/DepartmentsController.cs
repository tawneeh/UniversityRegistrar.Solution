using Microsoft.AspNetCore.Mvc;
using UniversityTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UniversityTracker.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly UniversityTrackerContext _db;
    public DepartmentsController(UniversityTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Departments.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}