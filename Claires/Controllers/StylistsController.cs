using Microsoft.AspNetCore.Mvc;
using Claires.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Claires.Controllers
{
  public class StylistsController : Controller
  {
    private readonly ClairesContext _db;
    public StylistsController(ClairesContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(mo)
    }
  }
}