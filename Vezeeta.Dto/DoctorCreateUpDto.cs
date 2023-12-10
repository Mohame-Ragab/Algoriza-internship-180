using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.enums;

namespace Vezeeta.Dto
{
    public class DoctorCreateUpDto
    {
        //{image,firstName,lastName,email,phone,specialize,gender,dateOfBirth}
        [Required]
        public string Image { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }
        [Required , Range(0,10)]
        public int SpecilzationId { get; set; }

        [Required]
        public Gender Gender { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set;}
    }
}
