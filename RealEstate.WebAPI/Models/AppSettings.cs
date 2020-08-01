using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace RealEstate.WebAPI.Models
{
    public class AppSettings
    {
        public string SecretKey { get; set; }
        public string ClientURL { get; set; }
    }
}
