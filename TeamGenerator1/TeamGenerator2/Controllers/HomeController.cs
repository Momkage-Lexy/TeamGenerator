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

    public IActionResult idk(Names n)
    {
        foreach (var name in n.Name)
            {
                Console.WriteLine(name);  // Outputs each name to the console
            }

        return View("Index");
    }
}

//TODO: If I add names and submit form and then try to submit a new form, it doesn't add the first name field to the list, but it works the first time