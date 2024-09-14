using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloBitchController : Controller
{

    //
    // GET: /HelloBitch
    public IActionResult Index()
    {
        return View();
    }

    //
    // GET: /HelloBitch/WelcomeBitch
    public IActionResult WelcomeBitch()
    {
        return View("Index");
    }

    //
    // GET: /HelloBitch/WelcomeBitchNamed
    public IActionResult WelcomeBitchNamed(string name, int ID = 1)
    {
        ViewData["Bitch Greeting"] = "Hello " + name; 
        ViewData["Times"] = ID;

        return View();
    }
}