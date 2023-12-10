using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.enums;

namespace Vezeeta.Domain
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        
        public AccountType AccountType { get; set; }

        public Gender Gender { get; set; }

        //[ForeignKey("Doctor")]
        //public int? DoctorId { get; set; }
        public virtual Doctor? Doctor { get; set; }

        //[ForeignKey("Patient")]
        //public int? PatentId { get; set; }
        public virtual Patient? Patient { get; set; }




    }
}
