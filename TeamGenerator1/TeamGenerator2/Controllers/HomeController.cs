using System.Diagnostics;
using Homework1.Models;
using Microsoft.AspNetCore.Mvc;
using TeamGenerator2.Models;

namespace TeamGenerator2.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Groups(Names model)
    {
        return View(model);
    }

}

//TODO: If I add names and submit form and then try to submit a new form, it doesn't add the first name field to the list, but it works the first time