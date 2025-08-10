using SportsMgmtApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SportsMgmtApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly SportsdbContext _context;
        public LoginController(SportsdbContext context)
        {
            _context = context;

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                TempData["ErrorMessage"] = "Username and password are required.";
                return View();
            }

            var user = _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (user != null)
            {
                TempData["SuccessMessage"] = "Login successful.";    
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = "Invalid username or password.";
                return View();
            }
        }
        
    }
}