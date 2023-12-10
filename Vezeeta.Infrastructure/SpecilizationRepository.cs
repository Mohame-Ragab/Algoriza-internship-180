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
    public class SpecilizationRepository : Repository<Specialization>, ISpecilizationRepository
    {
        public SpecilizationRepository(VezeetaContext context) : base(context)
        {
        }

        //public async Task<IEnumerable<Specialization>> Top5Specializations()
        //{
        //   var Specilaizations = await GetAllAsync();
        //    return Specilaizations.OrderByDescending(s => s.Requests.Count()).Take(5).ToList();
        //}
    }
}
