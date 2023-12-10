using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain;

namespace Vezeeta.Application.interfaces
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        Task<int> Count();
        
        Task<IEnumerable<Doctor>> Top10Doctors();
    }
}
