using Microsoft.AspNetCore.Mvc;
using SkillHub.ViewModels;

namespace SkillHub.Controllers;
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
        ViewData["AnoterSubtitle"] = "ASP.NET Core MVC";

        return View(skill);
    }
}
