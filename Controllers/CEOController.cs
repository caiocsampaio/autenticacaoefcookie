using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoEFCookie.Controllers
{
    [Authorize(Roles="CEO")]
    public class CEOController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}