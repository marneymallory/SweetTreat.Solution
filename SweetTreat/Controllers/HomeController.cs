using Microsoft.AspNetCore.Mvc;

namespace SweetTreat.Controllers
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