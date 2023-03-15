using Microsoft.AspNetCore.Mvc;

namespace DoctorOffice.Controllers
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