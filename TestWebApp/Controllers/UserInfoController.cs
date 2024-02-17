using Microsoft.AspNetCore.Mvc;
using TestWebApp.Data;

namespace TestWebApp.Controllers
{
    public class UserInfoController : Controller
    {
        private readonly DbContextClass _context;

        public UserInfoController(DbContextClass context)
        {
            _context = context;
        }

        public IActionResult UserInfo()
        {
           var userInfoData =  _context.userPersonalInformation.ToList();
            return View(userInfoData);
        }
    }
}
