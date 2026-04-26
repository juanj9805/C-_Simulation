using Microsoft.AspNetCore.Mvc;
using simulacro.Services;

namespace simulacro.Controllers;

public class VeterinaryController : Controller
{
    private readonly VeterinaryService _service;

    public VeterinaryController(VeterinaryService service)
    {
        _service = service;
    }
    
    public async Task<IActionResult> Index()
    {
        var ser = await _service.GetAll();
        return View(ser);
    }
}