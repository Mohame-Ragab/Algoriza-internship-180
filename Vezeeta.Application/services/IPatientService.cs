using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Dto;

namespace Vezeeta.Application.services
{
    public interface IPatientService
    {
        Task<PatientVerfyModel> RegisterPatient(PatientCrtUpDto patientCrtUpDto);
        Task<PatientVerfyModel> Login(PatientLoginDto patientLogin);
        Task<IEnumerable<object>> GetAllDoctorsPaginted(int page = 1, int pageSize = 5, string search = null);
        Task<PatientVerfyModel> Booking(string id ,RequestCrtDto requestCrt);
        Task<IEnumerable<object>> PateintBookings(string id);
        Task<PatientVerfyModel> CancelBooking(int id);
    }
}
