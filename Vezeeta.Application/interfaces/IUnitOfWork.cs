using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain;

namespace Vezeeta.Application.interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDoctorRepository Doctors { get; }
        IPatientRepository Patients { get; }
        IRequestRepository Requests { get; }
        ISpecilizationRepository Specilizations { get; }
        IRepository<Appointment> Appointments { get; }
        IRepository<Time> Times { get; }
        IRepository<Discount> Discounts { get; }
        
        int Complete();
    }
}
