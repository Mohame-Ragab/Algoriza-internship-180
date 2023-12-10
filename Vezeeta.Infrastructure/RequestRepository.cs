using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Application.interfaces;
using Vezeeta.Application.services;
using Vezeeta.Context;
using Vezeeta.Domain;
using Vezeeta.Domain.enums;

namespace Vezeeta.Infrastructure
{
    internal class RequestRepository : Repository<Request>, IRequestRepository
    {
        private readonly VezeetaContext context;

        public RequestRepository(VezeetaContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<object> GetAllRequestTypes()
        {
            var allRequests = await GetAllAsync();
            return new {
                AllRequests = allRequests.Count(),
                AllPendingRequests = allRequests.Where(r => r.RequestStatus == RequestStatus.Pending).Count(),
                AllCompletedRequests = allRequests.Where(r => r.RequestStatus == RequestStatus.Completed).Count(),
                AllCanceledRequests = allRequests.Where(r => r.RequestStatus == RequestStatus.Canceled).Count(),
            };
        }
    }
}
