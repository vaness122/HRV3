using Microsoft.AspNetCore.Mvc;

namespace HR.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
