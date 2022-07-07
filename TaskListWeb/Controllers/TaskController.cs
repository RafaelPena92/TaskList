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
        public async Task<ActionResult> Save(int id, string title, string description, string author, DateTime date)
        {

            try
            {
                await _taskService.Save(id, title, description, author, date);
                await _UserSession.IncreaseCounter();
                return RedirectToAction("Index", "Task");
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = e.Message;
                return RedirectToAction("Add", "Task");
            }
            


        }

        public IActionResult Add()
        {
            return View("Form");
        }

    
    }
}
