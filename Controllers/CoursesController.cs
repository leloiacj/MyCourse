using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;



namespace MyCourse.Controllers
{
    // [Route("[controller]")]
    public class CoursesController : Controller
    {

        public IActionResult Index()
        {
            var courseService = new CourseService();//Il controller crea un oggetto del servizio aaplicativo che deve utilizzare
            List<CourseViewModel> courses = courseService.GetServices();//recupero la lista dei corsi 
            return View(courses);//passo l'oggetto contenente la lista dei corsi alla view per mostrare i dati
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}