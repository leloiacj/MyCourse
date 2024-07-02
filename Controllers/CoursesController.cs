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
            var courseService = new CourseService();//Il controller crea un oggetto del servizio applicativo che deve utilizzare
            List<CourseViewModel> courses = courseService.GetCourses();//recupero la lista dei corsi 
            return View(courses);//passo l'oggetto contenente la lista dei corsi alla view per mostrare i dati
        }

        //azione che deve recuperare i dati del corso con id = id parametro
        //e popolare la view Detail.cshtml con i dati del corso recuperato
        public IActionResult Detail(int id)
        {
            var courseService = new CourseService();
            CourseDetailViewModel viewModel = courseService.GetCourse(id);
            return View(viewModel);
        }
    }
}