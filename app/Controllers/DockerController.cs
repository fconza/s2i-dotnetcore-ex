using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Docker.Models;
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

namespace app.Controllers
{
    public class DockerController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
       
     
        private static async Task<repoUser> GetDockerImages(string name)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            //var stringTask = client.GetStringAsync("https://api.github.com/users/fconza");

            var serializer = new DataContractJsonSerializer(typeof(repoUser));
            //var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var streamTask = client.GetStreamAsync("https://api.github.com/users/fconza");
            var gitUser  = serializer.ReadObject(await streamTask) as repoUser;

            // foreach (var l in logins)
            // {
            //     Console.WriteLine(l.Name);
            //     Console.WriteLine(l.Email);
            // }
            
            return gitUser;

        }
        public IActionResult Index()
        {
            ViewData["Message"] = "Validation of Docker images";

            return View();
        }


        public IActionResult List(string dockername)
        {
            ViewData["Message"] = "Docker images";
            ViewData["dockername"] = HtmlEncoder.Default.Encode(dockername);

            // GetDockerImages(dockername).Wait();

            var gitUser = GetDockerImages(dockername).Result;

            return View(gitUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
    
}
