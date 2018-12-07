using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using app.Models;


namespace app.Controllers
{
    [Authorize]
    public class NpmController : Controller
    {

/*        // [System.Web.Services.WebMethod]
        public static string GetUser(string name)       
        {
        
        return name;
        
        } */

        public IActionResult Index()
        {
            ViewData["Message"] = "Validation of Npm packages";

            return View();
        }

        public IActionResult List(string npmname)
        {
            ViewData["Message"] = "Npm packages";
            ViewData["npmname"] = HtmlEncoder.Default.Encode(npmname);
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}
