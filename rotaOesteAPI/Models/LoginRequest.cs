using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rotaOesteAPI.Models
{
    public class LoginRequest
    {
        #pragma warning disable CS8618
        public string Username { get; set; }
        public string Password { get; set; }
    }
}