using Microsoft.AspNetCore.Mvc;

namespace UniversityTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}