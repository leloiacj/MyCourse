using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

















namespace MyCourse.Controllers
{
    // [Route("[controller]")]
    public class CoursesController : Controller
    {

        public IActionResult Index()
        {
            return Content("sono index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono detail e ho ricevuto l'id {id}");
        }
    }
}