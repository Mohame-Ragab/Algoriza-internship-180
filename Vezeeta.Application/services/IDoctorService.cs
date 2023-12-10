using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Dto;

namespace Vezeeta.Application.services
{
    public interface IDoctorService
    {
        //Task<DoctorLogCheckModel> DoctorLogin(DoctorLoginDto doctorLoginDto);
        Task<object> DoctorBookigns(string id, DateTime? dateTime, int page = 1, int pageSize = 5);

        Task<bool> ConfirmBookigns(int id);
        Task<bool> AddAppointmentTime(string id, AppointTimeCreateDto appointTimeCreateDto);
        Task<bool> UpdateTime(int id, DateTime time);
        Task<bool> DeleteTime(int id);
    }
}
