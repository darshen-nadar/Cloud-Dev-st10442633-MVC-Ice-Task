using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        // GET: HelloWorld

        public string Index()
        {
            return "This is my default action...";
        }

        //GET: /HelloWorld/Welcome//
        //Requires using Systems.Text.Encodings.Web 

        public string Welcome(string name, int numTimes = 1) 
        {
           return HtmlEncoder.Default.Encode($"Hello {name}, numofTimes is {numTimes}");

        }


    }
}
