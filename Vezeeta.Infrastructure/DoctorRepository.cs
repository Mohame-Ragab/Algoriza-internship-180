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
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
    {
        private readonly VezeetaContext context;

        public DoctorRepository(VezeetaContext context) : base(context)
        {
            this.context = context;
        }

        public Task<int> Count()
        {
            var NumberOfDoctors = context.Doctors.Count();
            return Task.FromResult(NumberOfDoctors);
        }

        

        public async Task<IEnumerable<Doctor>> Top10Doctors()
        {
            var doctors = await GetAllAsync();

            return doctors.OrderByDescending(d => d.Requests.Count()).Take(10).ToList();
        }
    }
}
