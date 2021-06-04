using Microsoft.AspNetCore.Mvc;

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
      Dictionary model = new Dictionary<string, List>();
      List<Flavor> flavorList = _db.Flavors.ToList();
      flavorList<Treat> treatList = _db.Treats.ToList();
      model.Add("Flavors", flavorList);
      model.Add("Treats", treatList);
      return View(model);
    }
  }
}