using Microsoft.AspNetCore.Mvc;

namespace test_cs.Controllers;

public class GeneralController : Controller
{
    public IActionResult General()
    {
        return View();
    }
}