using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

using app.Models;
using app.Controllers;



namespace app.Areas.Maven.Controllers
{

    public class MavenController : Controller
    {

/*        // [System.Web.Services.WebMethod]
        public static string GetUser(string name)       
        {
        
        return name;
        
        } */

        public IActionResult Index()
        {
            ViewData["Message"] = "Validation of Docker images";

            return View();
        }

        public IActionResult List(string mavenname)
        {
            ViewData["Message"] = "Mavenpackages";
            ViewData["mavenname"] = HtmlEncoder.Default.Encode(mavenname);
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new app.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}
