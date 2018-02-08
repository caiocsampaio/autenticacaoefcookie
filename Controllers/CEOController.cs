using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoEFCookie.Controllers
{
    public class CEOController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}