using Microsoft.AspNetCore.Mvc;

namespace Claires.Controllers
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