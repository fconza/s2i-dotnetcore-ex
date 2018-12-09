using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace app.Areas.Docker.Models
{
    
    [DataContract(Name="gitUser")]
    public class repoUser
    {
        [DataMember(Name="login")]
        public string Name {get; set;}
        [DataMember(Name="email")]
        public string Email {get; set;}
        
        [DataMember(Name="avatar_url")]
        public string Avatar {get;set;}

    }
}