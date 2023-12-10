using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Domain.enums
{
    public enum Gender
    {
       Male = 0,
       Female = 1
    }

    public enum DiscountType
    {
        Pecentage =0,
        Value = 1
    }
    public enum RequestStatus
    {
        Pending,
        Completed,
        Canceled
        
    }

    public enum Days
    {   

        Sunday   ,
        Monday   ,
        Tuesday  ,
        Wednesday,
        Thursday ,
        Friday,
        Saturday,

    }
    public enum AccountType
    {
        Admin,
        Doctor,
        Patient
    }
    public class Helpers
    {
    }
}
