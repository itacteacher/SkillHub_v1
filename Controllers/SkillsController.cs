using Microsoft.AspNetCore.Mvc;
using SkillHub.Web.Models;

namespace SkillHub.Web.Controllers;
public class SkillsController : Controller
{
    // GET: SkillsController
    public ActionResult Index ()
    {
        var skill = new SkillViewModel
        {
            Id = 1,
            Name = "Programming",
            Description = "Ability to write code and solve programming problems."
        };

        ViewBag.Subtitle = "Programming in C#";
        ViewData["AnotherSubtitle"] = "ASP.NET Core MVC";

        return View(skill);
    }

    // GET: SkillsController/Create
    public ActionResult Create ()
    {
        return View();
    }

    // POST: SkillsController/Create
    [HttpPost]
    public IActionResult Create ([FromForm] SkillViewModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Index");
        }

        return View(model);
    }
}
