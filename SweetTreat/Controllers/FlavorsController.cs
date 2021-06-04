using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WeekFiveTemplate.Models;
using System.Collections.Generic;
using System.Linq;

namespace SweetTreat.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SweetTreatContext _db;

    public FlavorsController(SweetTreatContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }
  }
}