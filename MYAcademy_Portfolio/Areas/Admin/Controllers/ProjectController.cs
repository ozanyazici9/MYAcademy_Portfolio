using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYAcademy_Portfolio.Context;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Areas.Admin.Controllers;

[Area("Admin")]
public class ProjectController : Controller
{
    private readonly PortfolioContext _context;

    public ProjectController(PortfolioContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult ProjectList()
    {
        var values = _context.Projects.Include(p => p.Category).Include(p => p.Technologies).ToList();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateProject()
    {
        ViewBag.Categories = _context.Categories.ToList();
        ViewBag.Technologies = _context.Technologies.ToList();

        return View();
    }

    [HttpPost]
    public IActionResult CreateProject(Project project)
    {
        _context.Projects.Add(project);
        _context.SaveChanges();

        return RedirectToAction("ProjectList");
    }

    [HttpGet]
    public IActionResult UpdateProject(int id)
    {
        var project = _context.Projects.Find(id);

        ViewBag.Categories = _context.Categories.ToList();
        ViewBag.Technologies = _context.Technologies.ToList();

        return View(project);
    }

    [HttpPost]
    public IActionResult UpdateProject(Project project)
    {
        _context.Projects.Update(project);
        _context.SaveChanges();
        return RedirectToAction("ProjectList");
    }

    public IActionResult DeleteProject(int id)
    {
        var project = _context.Projects.Find(id);
        _context.Projects.Remove(project);
        _context.SaveChanges();

        return RedirectToAction("ProjectList");
    }
}