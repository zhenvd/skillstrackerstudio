using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            //string html = "<h1> Skills Tracker </h1>";
            return View();
        }
        [HttpGet]
        public IActionResult form()
        {
            //string language = Language();
            string form = @"
                    <form method='post'>
                    <label for='start'>Start date:</label>
                    <input type = 'date' id = 'start' name = 'date'>
                    <br>
                    <label for='C#'>C#:</label><br>
                    <select name ='csharp' id='C#'>
                        <option value='learning basics'>Learning Basics</option>
                        <option value='making apps'>Making Apps</option>
                        <option value='master coder'>Master Coder</option>
                    </select><br>
                    <label for='JavaScript'>JavaScript</label><br>
                    <select name ='javascript' id='JavaScript'>
                        <option value='learning basics'>Learning Basics</option>
                        <option value='making apps'>Making Apps</option>
                        <option value='master coder'>Master Coder</option>
                    </select><br>
                    <label for='Python'>Python</label><br>
                    <select name ='python' id='Python'>
                        <option value='learning basics'>Learning Basics</option>
                        <option value='making apps'>Making Apps</option>
                        <option value='master coder'>Master Coder</option>
                    </select><br>
                    <input type='submit' value = 'Submit' />
                    </form>
                    ";
            string html = form;
            return Content(html, "text/html");
        }
        [HttpPost]
        [Route("/skills/form/")]
        public IActionResult SkillsForm(string date, string csharp, string javascript, string python)
        {
            //string thedate = "<h1>+ date + </h1>";
            //string csh = "<h1>csharp</h1>";
            //string js = "<h1>javascript</h1>";
            //string py = "<h1>python</h1>";
            string html = "<h1>"+ date + "</h1>" +
                "<ol>" +
                "<li> C#: " + csharp + "</li>" +
                "<li> JavaScript: " + javascript + "</li>" +
                "<li> Python: " + python + "</li>"+ "</ol>";
            //string output = "C#: " + csh + "\nJS: " + js + "\nPython: " + py;
            return Content(html, "text/html");
        }
    }
}
