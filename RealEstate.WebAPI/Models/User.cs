using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RealEstate.WebAPI.Models
{
    public class User : IdentityUser
    {
        [Column(TypeName = "nvarchar(150)")]
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
