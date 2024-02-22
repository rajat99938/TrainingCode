using Microsoft.AspNetCore.Mvc;
using TestWebApp.Data;
using TestWebApp.Models;

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

        [HttpPost]
        public IActionResult AddUserInfo([FromBody] UserPersonalInformationModel obj)
        {
            try
            {
                _context.userPersonalInformation.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("UserInfo");
            }
            catch(Exception e)
            {
                throw new Exception();
            }
         
        }

        [HttpPost]
        public IActionResult DeleteUserInfo([FromBody] UserPersonalInformationModel obj)
        {
            try
            {
                _context.userPersonalInformation.Remove(obj);
                _context.SaveChanges();
                return RedirectToAction("UserInfo");
            }
            catch (Exception e)
            {
                throw new Exception();
            }

        }

        [HttpPost]
        public IActionResult UpdateUserInfo([FromBody] UserPersonalInformationModel obj)
        {
            try
            {
                _context.userPersonalInformation.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("UserInfo");
            }
            catch (Exception e)
            {
                throw new Exception();
            }

        }
    }
}
