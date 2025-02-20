using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        // GET: HelloWorld

        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome//
        //Requires using Systems.Text.Encodings.Web 

        public IActionResult Welcome(string name, int numTimes = 1) 
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();

        }


    }
}
