using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;


using app.Models;
using app.Controllers;

namespace app.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {     
        public IActionResult Index()
        {
            ViewData["Message"] = "Login IN";

            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            ViewData["Message"] = "Logged IN";

            var user = new app.Areas.Identity.Models.loginUser();
            user.UserName = HtmlEncoder.Default.Encode(login);
            user.UserPasswd = HtmlEncoder.Default.Encode(password);
            // ViewData["login"] = HtmlEncoder.Default.Encode(login);
            // ViewData["password"] = HtmlEncoder.Default.Encode(password);
            // // GetDockerImages(dockername).Wait();

            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new app.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
    
}
