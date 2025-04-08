using Microsoft.AspNetCore.Mvc;
using Receipt_Reimbursement_App.Models;
using System.Diagnostics;

namespace Receipt_Reimbursement_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //view to display success message.
        public IActionResult Success()
        {
            return View();
        }


    }
}
