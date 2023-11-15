using Microsoft.AspNetCore.Mvc;
using System;

namespace testing.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        public IActionResult addUser()
        {
            return View();
        }


        [HttpPost]
        public IActionResult addUser(string Email, string Name, string Username)
        {
            ViewBag.Email = Email;
            ViewBag.Name = Name;
            ViewBag.Username = Username;
            return View();
        }
        
    }
}
