using Microsoft.AspNetCore.Mvc;
using MYAcademy_Portfolio.Context;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Areas.Admin.Controllers;

[Area("Admin")]
public class ExperienceController : Controller
{
    private readonly PortfolioContext _context;

    public ExperienceController(PortfolioContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult ExperienceList()
    {
        var values = _context.Experiences.ToList();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateExperience()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateExperience(Experience experience)
    {
        _context.Experiences.Add(experience);
        _context.SaveChanges();
        return RedirectToAction("ExperienceList");
    }

    public IActionResult DeleteExperience(int id)
    {
        var entity = _context.Experiences.Find(id);
        _context.Experiences.Remove(entity);
        _context.SaveChanges();
        return RedirectToAction("ExperienceList");
    }

    public IActionResult UpdateExperience(int id)
    {
        var entity = _context.Experiences.Find(id);
        return View(entity);
    }

    [HttpPost]
    public IActionResult UpdateExperience(Experience experience)
    {
        _context.Experiences.Update(experience);
        _context.SaveChanges();
        return RedirectToAction("ExperienceList");
    }
}
