using Microsoft.AspNetCore.Mvc;

namespace InfraITSolution.Web.Models.ViewModels
{
    public class Ticket : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
