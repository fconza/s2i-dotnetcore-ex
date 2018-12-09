using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace app.Areas.Identity.Models
{
    
    public class loginUser
    {

        public string UserName {get; set;}
        public string UserPasswd {get; set;}

    }
}