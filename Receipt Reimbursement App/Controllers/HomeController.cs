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

        public IActionResult Success()
        {
            return View();
        }


    }
}
