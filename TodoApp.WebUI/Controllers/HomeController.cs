using Microsoft.AspNetCore.Mvc;
using TodoApp.Business.IServices;
using TodoApp.DTO;

namespace TodoApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _nalogaService;

        public HomeController(ITaskService nalogaService)
        {
            _nalogaService = nalogaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_nalogaService.GetAllTask());
        }

        [HttpPost]
        public IActionResult AddTask(NalogaDto nalogaDto)
        {
            _nalogaService.AddTask(nalogaDto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateTask(NalogaDto nalogaDto)
        {
            _nalogaService.UpdateTask(nalogaDto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteTask(int id) => Ok(_nalogaService.DeleteTaskById(id));
    }
}
