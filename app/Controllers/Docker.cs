using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;


namespace app.Controllers
{
    public class DockerController : Controller
    {

       // [System.Web.Services.WebMethod]
        public static bool GetUser(string name)       
        {
        
        return DateTime.IsLeapYear(year);
        
        }




        public IActionResult Docker()
        {
            ViewData["Message"] = "Validation of Docker images";


            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}
