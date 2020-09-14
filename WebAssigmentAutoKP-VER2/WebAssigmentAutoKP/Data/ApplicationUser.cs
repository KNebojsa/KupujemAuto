using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAssigmentAutoKP.Data
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [StringLength(30)]
        public string Ime { get; set; }
        [Required]
        [StringLength(30)]
        public string Prezime { get; set; }
    }
}
