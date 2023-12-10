using Microsoft.IdentityModel.Tokens;
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
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        private readonly VezeetaContext context;

        public PatientRepository(VezeetaContext context) : base(context)
        {
            this.context = context;
        }

        public Task<int> Count()
        {
            var NumberOfPatients = context.Patients.Count();
            return Task.FromResult(NumberOfPatients);
        }

        
    }
}
