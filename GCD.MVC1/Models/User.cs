using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GCD.MVC1.Models
{
    public class User : IdentityUser
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
    }
}
