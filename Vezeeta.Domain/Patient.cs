using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Domain
{
    public class Patient
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }

        public DateTime DateOfBirth { get; set; }

        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual List<Request>? Requests { get; set; }

    }
}
