using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Domain
{
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Doctor>? Doctors { get; set; }
        //public virtual List<Request>? Requests { get; set; }

    }
}
