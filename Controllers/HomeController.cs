using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Celsius = 0;
        return View();
    }

    [HttpPost]
    public IActionResult Index(TempModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Celsius = model.CalculateCelsius();
        }
        else
        {
            ViewBag.Celsius = 0;
        }
        return View(model);
    }



    
          public IActionResult Privacy()
    {
        return View();
    }
}