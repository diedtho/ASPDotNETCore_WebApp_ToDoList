using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPDotNETCore_WebApp_ToDoList.Models;

namespace ASPDotNETCore_WebApp_ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new List<ToDoModel>());
        }
        
        [HttpPost]
        public IActionResult Index(List<ToDoModel> listToDoModel)
        {
            return View(listToDoModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddElement()
        {
            ToDoModel toDoModel = new();
            
            return View(toDoModel);
        }
        
        [HttpPost]
        public IActionResult AddElement(ToDoModel toDoModel)
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}