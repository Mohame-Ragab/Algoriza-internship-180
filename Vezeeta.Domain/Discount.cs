using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.enums;

namespace Vezeeta.Domain
{
    [Index(nameof(DicountCode),IsUnique =true)]
    public class Discount
    {
        public int Id { get; set; }
        
        public string DicountCode { get; set; }
        public DiscountType  DiscountType { get; set; }
        public int Value { get; set; }
        public bool IsActive { get; set; }//needed to check with patient

        public int NuberOfCompReqs { get; set; }
        public virtual List<Request>? Requests { get; set; }
        
    }
}
