using Microsoft.AspNetCore.Mvc;
using Places.Models;

namespace Places.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
