using System.Diagnostics;
using Homework1.Models;
using Microsoft.AspNetCore.Mvc;
using TeamGenerator2.Models;

namespace TeamGenerator2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(Names n)
    {
        Debug.WriteLine(n.ToString());
        return View();
    }
}
