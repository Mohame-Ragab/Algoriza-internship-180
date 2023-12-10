using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Dto;

namespace Vezeeta.Application.services
{
    public interface IAdminService
    {
        Task<object> NumOfDoctors();
        Task<object> NumOfPatients();
        Task<object> NumOfRequests();
        Task<IEnumerable<object>> Top5Specializations();
        Task<IEnumerable<object>> Top10Doctors();
        //doctors
        Task<IEnumerable<object>> GetAllDoctorsPaginted(int page = 1, int pageSize = 5, string search = null);
        Task<object> GetDoctorById(int id);
        Task<DoctorVerfyModel> AddNewDoctor(DoctorCreateUpDto doctorCreateUpDto);
        Task<DoctorVerfyModel> EditDoctor(int id, DoctorCreateUpDto doctorCreateUpDto);
        Task<DoctorVerfyModel> DelteDoctor(int id);
        //-----------pateints
        Task<IEnumerable<object>> GetAllPatientsPaginted(int page = 1, int pageSize = 5, string search = null);
        Task<object> GetPatientById(int id);
        //----------- discount
        Task<DiscountCheckModel> AddDiscount(DiscountCreateUpDto discountCreateUpDto);
        Task<DiscountCheckModel> UpdateDiscount(int id, DiscountCreateUpDto discountCreateUpDto);
        Task<DiscountCheckModel> DeleteDiscount(int id);
        Task<DiscountCheckModel> DeActiveDiscount(int id);
    }
}
