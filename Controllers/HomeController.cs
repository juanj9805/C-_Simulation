using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using simulacro.Models;
using simulacro.Services;

namespace simulacro.Controllers;

public class HomeController : Controller
{
    private readonly OwnerService _service;

    public HomeController(OwnerService service)
    {
        _service = service;
    }
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> Hi()
    {
        var ser = await _service.GetAll();
        return View(ser);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
