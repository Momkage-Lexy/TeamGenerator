using System.Diagnostics;
using TeamGenerator2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        Random random = new Random();
        var names = model.NameList; 

        int n = names.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            (names[j], names[i]) = (names[i], names[j]);
        }

        model.NameInput = string.Join("\n", names); 
        return View(model);
    }

}


//TODO: If I add names and submit form and then try to submit a new form, it doesn't add the first name field to the list, but it works the first time
