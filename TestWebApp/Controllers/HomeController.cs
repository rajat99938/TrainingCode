using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Models.UserModel());
        }

        [HttpPost]
        public IActionResult Index(Models.UserModel model)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, return the view with validation errors
                return View(model);
            }

            // Validation succeeded, perform further actions (e.g., save to database)
            // For now, we'll just return a success message
            return Content("Registration successful!");
        }

        [HttpGet]
        public IActionResult Compare()
        {
            return View(new Models.RegisterViewModel());
        }

        [HttpPost]
        public IActionResult Compare(Models.RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, return the view with validation errors
                return View(model);
            }

            // Validation succeeded, perform further actions (e.g., save to database)
            // For now, we'll just return a success message
            return Content("Registration successful!");
        }

        [HttpGet]
        public IActionResult Range()
        {
            return View(new Models.RangeModel());
        }

        [HttpPost]
        public IActionResult Range(Models.RangeModel model)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, return the view with validation errors
                return View(model);
            }

            // Validation succeeded, perform further actions (e.g., save to database)
            // For now, we'll just return a success message
            return Content("Registration successful!");
        }

        [HttpGet]
        public IActionResult RegularExpression()
        {
            return View(new Models.RegularExpressionModel());
        }

        [HttpPost]
        public IActionResult RegularExpression(Models.RegularExpressionModel model)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, return the view with validation errors
                return View(model);
            }

            // Validation succeeded, perform further actions (e.g., save to database)
            // For now, we'll just return a success message
            return Content("Registration successful!");
        }

        [HttpGet]
        public IActionResult Custom()
        {
            return View(new Models.CustomeValidationModel());
        }

        [HttpPost]
        public IActionResult Custom(Models.CustomeValidationModel model)
        {
            if (!ModelState.IsValid)
            {
                // If validation fails, return the view with validation errors
                return View(model);
            }

            // Validation succeeded, perform further actions (e.g., save to database)
            // For now, we'll just return a success message
            return Content("Registration successful!");
        }

        [HttpGet]
        public IActionResult GetData()
        {
            // Sample data
            var data = new List<string> { "Item 1", "Item 2", "Item 3" };
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetDataOnClick()
        {
            // Sample data
            var data = new List<string> { "Item 4", "Item 5", "Item 6" };
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetDataView()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetRazorView()
        {
            //var user = new RazorViewModel { Id = 1, Name = "John Doe" };
            //return View(user);

            var model = new RazorViewLoopModel
            {
                Users = new List<string> { "User1", "User2", "User3" }
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}