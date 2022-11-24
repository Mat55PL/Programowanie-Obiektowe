using System.Diagnostics;
using LABS_CORE.Models;
using LABS_CORE.Models.Person;
using Microsoft.AspNetCore.Mvc;

namespace LABS_CORE.Controllers;

public class PersonController : Controller
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger) //dependecy injection
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //throw new ArgumentNullException(); //test exception
        _logger.LogInformation("Index page says hello");
        var model = new PersonViewModel()
        {
            Persons = new PersonModel().GetPersons()
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}