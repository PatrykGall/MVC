using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // Wywoływane przez: https://localhost:XXXX/HelloWorld
    public IActionResult Index()
    {
        return View();
    }

    // Wywoływane przez: https://localhost:XXXX/HelloWorld/Welcome
    public string Welcome()
    {
        return "To jest metoda Welcome!";
    }
}