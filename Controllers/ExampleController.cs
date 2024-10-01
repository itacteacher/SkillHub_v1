using Microsoft.AspNetCore.Mvc;

namespace SkillHub.Controllers;

public class ExampleController : Controller
{
    // GET: /Example/
    [HttpGet]
    public IActionResult Index ()
    {
        var exampleList = new[] { "Example1", "Example2", "Example3" };
        
        return View(exampleList);
    }

    [HttpGet("Example/Details/{id}")]
    public IActionResult Details (int id)
    {
        if (id < 1 || id > 3)
        {
            return NotFound();
        }

        var exampleItem = $"Example{id}";
        ViewBag.Id = id;

        return View((object)exampleItem);
    }

    // Метод для возврата текстового содержимого
    public IActionResult GetText ()
    {
        return Content("Hello, World!");
    }

    // Метод для возврата данных в формате JSON
    public IActionResult GetData ()
    {
        var data = new { Name = "John", Age = 30 };
        return Json(data);
    }

    // GET: /Example/Create
    [HttpGet]
    public IActionResult Create ()
    {
        return View();
    }

    // POST: /Example/Create
    [HttpPost]
    public IActionResult Create (string newExample)
    {
        if (string.IsNullOrEmpty(newExample))
        {
            ModelState.AddModelError(string.Empty, "Invalid input");

            return View();
        }

        ViewBag.Message = $"Item '{newExample}' has been created successfully!";
        
        return View();
    }

    // GET: /Example/Edit/5
    [HttpGet("Example/Edit/{id}")]
    public IActionResult Edit (int id)
    {
        if (id < 1 || id > 3)
        {
            return NotFound();
        }

        var exampleItem = $"Example{id}";

        return View((object)exampleItem);
    }

    // POST: /Example/Edit/5
    [HttpPost("Example/Edit/{id}")]
    public IActionResult Edit (int id, string updatedExample)
    {
        if (id < 1 || id > 3 || string.IsNullOrEmpty(updatedExample))
        {
            ModelState.AddModelError(string.Empty, "Invalid input");

            return View((object)$"Example{id}");
        }

        ViewBag.Message = $"Item 'Example{id}' has been updated to '{updatedExample}'";
        
        return View((object)updatedExample);
    }

    // GET: /Example/Delete/5
    [HttpGet("Example/Delete/{id}")]
    public IActionResult Delete (int id)
    {
        if (id < 1 || id > 3)
        {
            return NotFound();
        }

        var exampleItem = $"Example{id}";

        return View((object)exampleItem);
    }

    // POST: /Example/Delete/5
    [HttpPost("Example/Delete/{id}"), ActionName("Delete")]
    public IActionResult DeleteConfirmed (int id)
    {
        if (id < 1 || id > 3)
        {
            return NotFound();
        }

        ViewBag.Message = $"Item 'Example{id}' has been deleted.";

        return RedirectToAction(nameof(Index));
    }
}
