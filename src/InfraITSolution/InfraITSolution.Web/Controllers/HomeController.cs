using InfraITSolution.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InfraITSolution.Web.Controllers
{
    public class HomeController : Controller
    {
        //logica de acesso
        [AllowAnonymous] 
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                
                return RedirectToAction( "Dashboard","Home");
            }
            return View();
        }

        [Authorize] 
        public IActionResult Dashboard()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
