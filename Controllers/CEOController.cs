using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoEFCookie.Controllers
{
    [Authorize]
    public class CEOController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}