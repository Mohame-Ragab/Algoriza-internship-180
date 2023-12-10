using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Application.interfaces;
using Vezeeta.Application.services;
using Vezeeta.Context;
using Vezeeta.Domain;

namespace Vezeeta.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VezeetaContext _context;

        public UnitOfWork(VezeetaContext context)
        {
            _context = context;

            Doctors = new DoctorRepository(_context);
            Patients = new PatientRepository(_context);
            Requests = new RequestRepository(_context);
            Specilizations= new SpecilizationRepository(_context);
            Discounts = new Repository<Discount>(_context);
            Appointments = new Repository<Appointment>(_context);
            Times = new Repository<Time>(_context);
        }
        public IDoctorRepository Doctors { get; private set; }

        public IPatientRepository Patients { get; private set; }

        public IRequestRepository Requests { get; private set; }

        public ISpecilizationRepository Specilizations { get; private set; }

        public IRepository<Appointment> Appointments { get; private set; }

        public IRepository<Time> Times { get; private set; }

        public IRepository<Discount> Discounts { get; private set; }

        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
