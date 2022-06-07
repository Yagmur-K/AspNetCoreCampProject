using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCampProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
