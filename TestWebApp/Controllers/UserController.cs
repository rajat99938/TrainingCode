using Microsoft.AspNetCore.Mvc;
using TestWebApp.Data;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly DbContextClass _context;

        public UserController(DbContextClass context)
        {
            _context = context;
        }

        public IActionResult UserView()
        {

            //var users = _context.userLoginDetails
            //    .Where(u => u.username.StartsWith("A") && u.Age > 25)
            //    .ToList();
            //var users = _context.userLoginDetails.ToList();
            var users = _context.userLoginDetails.ToList();
            return View(users);
        }

        [HttpPost]
        public IActionResult DeleteUser(int userId)
        {

            // Find the user by ID 
            var user = _context.userLoginDetails.FirstOrDefault(u => u.uid == userId);
            if (user == null)
            {
                // User not found, return appropriate response
                return NotFound();
            }

            // Remove the user from the context
            _context.userLoginDetails.Remove(user);

            // Save changes to the database
            _context.SaveChanges();

            // Redirect back to the user view
            return RedirectToAction("UserView");
        }

        //[HttpPost]
        //public IActionResult AddUser(string username, string password)
        //{
        //    var user = new userLoginDetails_result
        //    {
        //        username = username,
        //        password = password
        //    };
        //    // Add the user to the context
        //    _context.userLoginDetails.Add(user);
        //    // Save changes to the database
        //    _context.SaveChanges();

        //    return RedirectToAction("UserView");
        //}

        [HttpPost]
        public IActionResult AddUser([FromBody] userLoginDetails_result obj)
        {
            // Add the user to the context
            _context.userLoginDetails.Add(obj);
            // Save changes to the database
            _context.SaveChanges();

            return RedirectToAction("UserView");
        }
    }
}
