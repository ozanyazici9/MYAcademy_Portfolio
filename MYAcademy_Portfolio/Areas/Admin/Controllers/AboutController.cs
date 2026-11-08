using Microsoft.AspNetCore.Mvc;
using MYAcademy_Portfolio.Context;

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
}
