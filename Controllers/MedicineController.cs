using Microsoft.AspNetCore.Mvc;
using simulacro.Models;
using simulacro.Services;

namespace simulacro.Controllers;

public class MedicineController : Controller
{
    private readonly MedicineService _service;

    public MedicineController(MedicineService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var ser = await _service.GetAll();
        return View(ser);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Medicine medicine)
    {
        if (ModelState.IsValid)
        {
            await _service.Create(medicine);
            return RedirectToAction("Index");
        }

        return View(medicine);
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        return View();
    }

    [HttpPost]
    public async  Task<IActionResult> Update(Medicine medicine)
    {
        await _service.Update(medicine);
        return RedirectToAction("Index");
    }
}