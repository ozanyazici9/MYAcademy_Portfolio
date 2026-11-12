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
    public IActionResult CreateProject(Project project, List<int> technologyIds)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Technologies = _context.Technologies.ToList();
            ViewBag.SelectedTechnologyIds = technologyIds;
            return View(project);
        }

        var selectedTechnologies = _context.Technologies.Where(t => technologyIds.Contains(t.TechnologyId)).ToList();

        project.Technologies = selectedTechnologies;

        _context.Projects.Add(project);
        _context.SaveChanges();

        return RedirectToAction("ProjectList");
    }

    [HttpGet]
    public IActionResult UpdateProject(int id)
    {
        var project = _context.Projects.Include(p => p.Category).Include(p => p.Technologies).FirstOrDefault(p => p.ProjectId == id);

        ViewBag.Categories = _context.Categories.ToList();
        ViewBag.Technologies = _context.Technologies.ToList();

        return View(project);
    }

    // Buradaki bind işlemi dto kullanmayıp enttiy üzerinde data annotationlar kullanıldığı için yapılmıştır.
    // Overposting saldırılarına karşı önlem için yapılmıştır. Eğer dto kullanılırsa bind işlemi gerekmez.
    // Porjenin kalanında kullanılmayacak çükü bu küçük bir potföy projesidir.
    [HttpPost]
    public IActionResult UpdateProject(
            [Bind("ProjectId,ProjectName,CategoryId,ImageUrl,GithubUrl,LiveDemoUrl,IsActive,Description")]
            Project project, List<int> technologyIds
        )
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Technologies = _context.Technologies.ToList();
            ViewBag.SelectedTechnologyIds = technologyIds;
            return View(project);
        }

        var existing = _context.Projects
            .Include(p => p.Technologies)
            .FirstOrDefault(p => p.ProjectId == project.ProjectId);

        if (existing == null) return NotFound();

        existing.ProjectName = project.ProjectName;
        existing.CategoryId = project.CategoryId;
        existing.ImageUrl = project.ImageUrl;
        existing.GithubUrl = project.GithubUrl;
        existing.LiveDemoUrl = project.LiveDemoUrl;
        existing.IsActive = project.IsActive;
        existing.Description = project.Description;

        technologyIds ??= new List<int>();

        var selected = _context.Technologies
            .Where(t => technologyIds.Contains(t.TechnologyId))
            .ToList();

        existing.Technologies.Clear();
        foreach (var tech in selected)
        {
            existing.Technologies.Add(tech);
        }

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