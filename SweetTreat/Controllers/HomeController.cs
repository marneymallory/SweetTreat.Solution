using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using SweetTreat.Models;

namespace SweetTreat.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetTreatContext _db;
    public HomeController(SweetTreatContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Flavor> flavorList = _db.Flavors.ToList();
      List<Treat> treatList = _db.Treats.ToList();
      model.Add("Flavors", flavorList);
      model.Add("Treats", treatList);
      return View(model);
    }
  }
}