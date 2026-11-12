using Microsoft.AspNetCore.Mvc;
using MYAcademy_Portfolio.Context;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Areas.Admin.Controllers;

[Area("Admin")]
public class AboutController : Controller
{
    private readonly PortfolioContext _context;

    public AboutController(PortfolioContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult AboutList()
    {
        var values = _context.Abouts.ToList();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateAbout()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateAbout(About about)
    {
        if (!ModelState.IsValid)
        {
            return View(about);
        }

        _context.Abouts.Add(about);
        _context.SaveChanges();
        return RedirectToAction("AboutList");
    }

    [HttpGet]
    public IActionResult UpdateAbout(int id)
    {
        var values = _context.Abouts.Find(id);
        if (values == null)
        {
            return NotFound();
        }
        return View(values);
    }

    [HttpPost]
    public IActionResult UpdateAbout(About about)
    {
        if (!ModelState.IsValid)
        {
            return View(about);
        }
        _context.Abouts.Update(about);
        _context.SaveChanges();
        return RedirectToAction("AboutList");
    }

    public IActionResult DeleteAbout(int id)
    {
        var entity = _context.Abouts.Find(id);
        if (entity == null)
        {
            return NotFound();
        }
        _context.Abouts.Remove(entity);
        _context.SaveChanges();
        return RedirectToAction("AboutList");
    }
}
