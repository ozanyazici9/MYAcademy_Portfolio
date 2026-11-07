using Microsoft.AspNetCore.Mvc;
using MYAcademy_Portfolio.Context;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Areas.Admin.Controllers;

[Area("Admin")]
public class HeroSectionController : Controller
{
    private readonly PortfolioContext _context;

    public HeroSectionController(PortfolioContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult HeroSectionList()
    {
        var values = _context.HeroSections.ToList();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateHeroSection()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateHeroSection(HeroSection heroSection)
    {
        _context.HeroSections.Add(heroSection);
        _context.SaveChanges();
        return RedirectToAction("HeroSectionList");
    }

    [HttpPost]
    public IActionResult UpdateHeroSection(HeroSection heroSection)
    {
        _context.HeroSections.Update(heroSection);
        _context.SaveChanges();
        return RedirectToAction("HeroSectionList");
    }


    public IActionResult UpdateHeroSection(int id)
    {
        var entity = _context.HeroSections.Find(id);
        return View(entity);
    }

    public IActionResult DeleteHeroSection(int id)
    {
        var entity = _context.HeroSections.Find(id);
        _context.HeroSections.Remove(entity);
        _context.SaveChanges();
        return RedirectToAction("HeroSectionList");
    }
}
