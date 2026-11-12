using Microsoft.AspNetCore.Mvc;
using MYAcademy_Portfolio.Context;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Areas.Admin.Controllers;

[Area("Admin")]
public class MessageController : Controller
{
    private readonly PortfolioContext _context;

    public MessageController(PortfolioContext context)
    {
        _context = context;
    }

    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public IActionResult MessageList()
    {
        var values = _context.Messages.ToList();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateMessage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateMessage(Message message)
    {
        if (!ModelState.IsValid)
        {
            return View(message);
        }

        message.SendDate = DateTime.Now;
        message.IsRead = false;
        _context.Messages.Add(message);
        _context.SaveChanges();
        return RedirectToAction("MessageList");
    }

    public IActionResult DeleteMessage(int id)
    {
        var value = _context.Messages.Find(id);
        _context.Messages.Remove(value);
        _context.SaveChanges();
        return RedirectToAction("MessageList");
    }

    [HttpGet]
    public IActionResult UpdateMessage(int id)
    {
        var value = _context.Messages.Find(id);
        return View(value);
    }

    [HttpPost]
    public IActionResult UpdateMessage(Message message)
    {
        if (!ModelState.IsValid)
        {
            return View(message);
        }

        _context.Messages.Update(message);
        _context.SaveChanges();
        return RedirectToAction("MessageList");
    }

    [HttpGet]
    public IActionResult MessageDetail(int id)
    {
        var value = _context.Messages.Find(id);

        if (!value.IsRead)
        {
            value.IsRead = true;
            _context.Messages.Update(value);
            _context.SaveChanges();
        }

        return View(value);
    }

    public IActionResult ChangeIsReadToTrue(int id)
    {
        var value = _context.Messages.Find(id);
        value.IsRead = true;
        _context.Messages.Update(value);
        _context.SaveChanges();
        return RedirectToAction("MessageList");
    }

    public IActionResult ChangeIsReadToFalse(int id)
    {
        var value = _context.Messages.Find(id);
        value.IsRead = false;
        _context.Messages.Update(value);
        _context.SaveChanges();
        return RedirectToAction("MessageList");
    }

}
