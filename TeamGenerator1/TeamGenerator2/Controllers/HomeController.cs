using System.Diagnostics;
using TeamGenerator2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;

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
        if (!ModelState.IsValid)
        {
            return View("Index", model);  
        }

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


