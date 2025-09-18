using Microsoft.AspNetCore.Mvc;

namespace test_cs.Controllers;

public class UsersController : Controller
{
    
        public IActionResult Index()
        {
            return View();
        }
    
}