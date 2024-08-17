using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
