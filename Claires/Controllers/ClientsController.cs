using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Claires.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Claires.Controllers
{
  public class ClientsController : Controller
  {
    private readonly ClairesContext _db;
    public ClientsController(ClairesContext db)
    {
      _db = db;
    }
  }
}