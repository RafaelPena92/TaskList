using Domain.Contracts;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace TaskListWeb.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IUserSession _UserSession;
       // public int cont { get; private set; }

        public TaskController(ITaskService taskService, IUserSession userSession)
        {
            _taskService = taskService;
            _UserSession = userSession;
        }

        public async Task <IActionResult> Index()
        {
            List<Note> tasks = await _taskService.GetAll();
            int count = await _UserSession.GetCouter();
            ViewBag.Count = tasks.Count;
            return View(tasks);
        }

        [HttpPost]
        public async Task<ActionResult> Save(int id, string title, string description, string author)
        {
            await _taskService.Save(id, title, description, author);
            await _UserSession.IncreaseCounter();
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View("Form");
        }

    
    }
}
